import time
import pandas as pd
import yfinance as yf
import pyodbc

SYMBOLS = [
    "AKBNK.IS","ARCLK.IS","ASELS.IS","ASTOR.IS","BIMAS.IS","BRSAN.IS","EKGYO.IS","ENKAI.IS","EREGL.IS",
    "FROTO.IS","GARAN.IS","GUBRF.IS","HEKTS.IS","ISCTR.IS","KCHOL.IS","KOZAA.IS","KOZAL.IS","KRDMD.IS",
    "PGSUS.IS","PETKM.IS","SAHOL.IS","SASA.IS","SISE.IS","SOKM.IS","TCELL.IS","THYAO.IS",
    "TOASO.IS","TUPRS.IS","YKBNK.IS"
]
INTERVALS = ["15m"]
POLL_SEC  = 60
KEEP_BARS = 20
BACKFILL_ROWS = 40
PERIOD_HINT = {
    "1m":  "7d",
    "5m":  "10d",
    "15m": "2d",
    "30m": "10d",
    "1h":  "1mo",
    "1d":  "6mo",
}

def _pick_driver() -> str:
    cand = ["ODBC Driver 18 for SQL Server", "ODBC Driver 17 for SQL Server"]
    for d in cand:
        if d in pyodbc.drivers():
            return d
    raise RuntimeError("ODBC Driver 17/18 for SQL Server yüklü değil.")

DRV = _pick_driver()
CONN_STR = (
    f"Driver={{{DRV}}};"
    "Server=(localdb)\\MSSQLLocalDB;"
    "Database=PricesDb;"
    "Trusted_Connection=yes;"
    "TrustServerCertificate=yes;"
)

def to_utc_naive(ts) -> "datetime":
    ts = pd.Timestamp(ts)
    return ts.tz_convert("UTC").to_pydatetime().replace(tzinfo=None) if ts.tzinfo else ts.to_pydatetime()

def upsert_candle(cur, sym, interval, ts_utc, o, h, l, c, src="yf"):
    cur.execute("""
MERGE dbo.Candles AS T
USING (SELECT ? AS Symbol, ? AS Interval, ? AS TsUtc) S
ON T.Symbol=S.Symbol AND T.Interval=S.Interval AND T.TsUtc=S.TsUtc
WHEN MATCHED THEN UPDATE SET [Open]=?, [High]=?, [Low]=?, [Close]=?, Source=?
WHEN NOT MATCHED THEN
  INSERT(Symbol,Interval,TsUtc,[Open],[High],[Low],[Close],Source)
  VALUES(S.Symbol,S.Interval,S.TsUtc,?,?,?,?,?);
""", sym, interval, ts_utc, o, h, l, c, src, o, h, l, c, src)

def enforce_retention(cur, keep=KEEP_BARS):
    cur.execute(f"""
;WITH x AS (
  SELECT Id,
         ROW_NUMBER() OVER (PARTITION BY Symbol, Interval ORDER BY TsUtc DESC) rn
  FROM dbo.Candles
)
DELETE FROM x WHERE rn > ?;
""", keep)

def fetch_and_write(cur, sym, interval) -> int:
    period = PERIOD_HINT.get(interval, "5d")
    df = yf.download(sym, period=period, interval=interval, progress=False)
    if df is None or df.empty:
        print(f"[{sym} {interval}] veri yok.")
        return 0
    if len(df) > BACKFILL_ROWS:
        df = df.tail(BACKFILL_ROWS)

    count = 0
    for idx, row in df.iterrows():
        ts_utc = to_utc_naive(idx)
        o = float(row["Open"]); h = float(row["High"]); l = float(row["Low"]); c = float(row["Close"])
        upsert_candle(cur, sym, interval, ts_utc, o, h, l, c)
        count += 1
    return count

def main():
    print(f"[feeder] Candles yazıcı başladı | sürücü: {DRV}")
    with pyodbc.connect(CONN_STR, autocommit=False) as cn:
        cur = cn.cursor()

        for sym in SYMBOLS:
            for itv in INTERVALS:
                try:
                    n = fetch_and_write(cur, sym, itv)
                    print(f"[{sym} {itv}] backfill {n} satır")
                except Exception as e:
                    print(f"[{sym} {itv}] hata(backfill): {e}")
        cn.commit()
        enforce_retention(cur, KEEP_BARS)
        cn.commit()

        while True:
            for sym in SYMBOLS:
                for itv in INTERVALS:
                    try:
                        n = fetch_and_write(cur, sym, itv)
                        if n:
                            print(f"[{sym} {itv}] güncellendi (+{n})")
                    except Exception as e:
                        print(f"[{sym} {itv}] hata(loop): {e}")
            cn.commit()
            enforce_retention(cur, KEEP_BARS)
            cn.commit()
            time.sleep(POLL_SEC)

if __name__ == "__main__":
    try:
        main()
    except KeyboardInterrupt:
        print("\n[feeder] durduruldu.")
