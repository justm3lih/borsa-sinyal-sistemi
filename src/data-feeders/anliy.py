import time, pyodbc, yfinance as yf, pandas as pd
from datetime import datetime, timezone

SYMBOLS = [
    "AKBNK.IS","ARCLK.IS","ASELS.IS","ASTOR.IS","BIMAS.IS","BRSAN.IS","EKGYO.IS","ENKAI.IS","EREGL.IS",
    "FROTO.IS","GARAN.IS","GUBRF.IS","HEKTS.IS","ISCTR.IS","KCHOL.IS","KOZAA.IS","KOZAL.IS","KRDMD.IS",
    "PGSUS.IS","PETKM.IS","SAHOL.IS","SASA.IS","SISE.IS","SOKM.IS","TAKBN.IS","TCELL.IS","THYAO.IS",
    "TOASO.IS","TUPRS.IS","YKBNK.IS"
]

POLL = 15

drv = next((d for d in ["ODBC Driver 18 for SQL Server","ODBC Driver 17 for SQL Server"]
            if d in pyodbc.drivers()), None)
cn = pyodbc.connect(
    f"Driver={{{drv}}};Server=(localdb)\\MSSQLLocalDB;Database=PricesDb;"
    "Trusted_Connection=yes;TrustServerCertificate=yes;")
cur = cn.cursor()

def upsert(sym, ts, px, src):
    cur.execute("""
MERGE dbo.TicksLatest AS T
USING (SELECT ? AS Symbol) S ON T.Symbol=S.Symbol
WHEN MATCHED THEN UPDATE SET TsUtc=?, Price=?, Source=?
WHEN NOT MATCHED THEN INSERT(Symbol,TsUtc,Price,Source) VALUES(?,?,?,?);
""", sym, ts, px, src, sym, ts, px, src)

def live(symbol):
    ts = datetime.now(timezone.utc).replace(tzinfo=None)
    t = yf.Ticker(symbol)
    fi = getattr(t, "fast_info", None)
    if fi:
        for k in ("last_price","regular_market_price","regularMarketPrice","lastPrice"):
            try:
                v = fi.get(k)
                if v: return ts, float(v), "fast"
            except Exception: pass
    df = yf.download(symbol, period="1d", interval="1m", progress=False)
    if df is not None and not df.empty:
        idx = pd.Timestamp(df.index[-1])
        ts = (idx.tz_convert("UTC").to_pydatetime().replace(tzinfo=None)
              if idx.tzinfo else idx.to_pydatetime())
        return ts, float(df["Close"].iloc[-1]), "1m"
    return None, None, None

print("[ticks] start")
while True:
    for s in SYMBOLS:
        ts, px, src = live(s)
        if px is not None:
            upsert(s, ts, px, src)
            print(f"[{s}] {ts} {px} ({src})")
    cn.commit()
    time.sleep(POLL)
