using Microsoft.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace SON_ORJİN
{
    public partial class Form1 : Form
    {
        private readonly string _connStr =
    @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=PricesDb;Integrated Security=True";
        private string _currentInterval = "1m";

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdatePriceLabels();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdatePriceLabels();
            if (!string.IsNullOrWhiteSpace(_selectedSymbol))
                LoadChartForSelectedSymbol();
        }
        private string _selectedSymbol;

        private void lbl_Click(object? sender, EventArgs e)
        {
            string sym = null;

            if (sender is MetroFramework.Controls.MetroLabel ml && ml.Tag is string t1)
                sym = t1;
            else if (sender is Label l && l.Tag is string t2)
                sym = t2;

            if (string.IsNullOrWhiteSpace(sym))
                return;

            _selectedSymbol = sym.Trim().ToUpperInvariant(); 
            LoadChartForSelectedSymbol();                   
        }
        private void button1_Click(object sender, EventArgs e){}
        private void PriceLabel_DoubleClick(object sender, EventArgs e)
        {
            var result = ShowSignalSummary(_selectedSymbol);
            if (result == null)
            {
                MessageBox.Show("Yeterli veri yok", "Sinyal Değerlendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show($"RSI: {result.Value.RsiLabel} \n " +
                $"SMA/EMA: {result.Value.SmaEmaLabel} \n " +
                $"Bollinger: {result.Value.BollLabel} \n " +
                $"--------------------- \n " +
                $"Genel: {result.Value.OverallLabel} " , _selectedSymbol);
        }
        private Dictionary<string, double> GetLatestPricesForSymbols(List<string> symbols)
        {
            var dict = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase);
            if (symbols == null || symbols.Count == 0) return dict;

            var sql = @"SELECT Symbol, Price FROM dbo.TicksLatest;";

            using var conn = new SqlConnection(_connStr);
            using var cmd = new SqlCommand(sql, conn);

            conn.Open();
            using var r = cmd.ExecuteReader();
            while (r.Read())
            {
                var s = r.GetString(0).Trim().ToUpperInvariant();
                if (s.EndsWith(".IS")) s = s[..^3];

                var p = (double)r.GetDecimal(1);
                dict[s] = p;
            }
            return dict;
        }

        private void UpdatePriceLabels()
        {
            var priceLabels = tableStocks.Controls
                .OfType<MetroFramework.Controls.MetroLabel>()
                .Where(l => l.Name.EndsWith("_Price", StringComparison.OrdinalIgnoreCase) && l.Tag is string)
                .Select(l => (Symbol: ((string)l.Tag).Trim().ToUpperInvariant(), Label: l))
                .ToList();

            if (priceLabels.Count == 0) return;

            var symbols = priceLabels.Select(x => x.Symbol).Distinct().ToList();
            var latest = GetLatestPricesForSymbols(symbols);

            foreach (var item in priceLabels)
            {
                var sym = item.Symbol.EndsWith(".IS") ? item.Symbol[..^3] : item.Symbol;

                if (latest.TryGetValue(sym, out var price))
                    item.Label.Text = price.ToString("N2", System.Globalization.CultureInfo.GetCultureInfo("tr-TR"));
                else
                    item.Label.Text = "-";
            }
        }
       
        
        //CHART İÇİN
        private static string ToDbSymbol(string uiSymbol)
        {
            var s = (uiSymbol ?? "").Trim().ToUpperInvariant();
            return s.EndsWith(".IS") ? s : s + ".IS";
        }
        private List<(DateTime t, double close)> GetRecentCloses(string uiSymbol, string interval = "1m", int count = 150)
        {
            var list = new List<(DateTime, double)>();
            if (string.IsNullOrWhiteSpace(uiSymbol)) return list;

            var sym1 = ToDbSymbol(uiSymbol);               
            var sym2 = uiSymbol.Trim().ToUpperInvariant();  

            const string sqlFetch = @"
    SELECT TOP (@n) [TsUtc], [Close]
    FROM dbo.[Candles] WITH (NOLOCK)
    WHERE [Symbol] = @sym AND [Interval] = @int
    ORDER BY [TsUtc] DESC;";


            const string sqlPickInt = @"
        SELECT TOP 1 [Interval]
        FROM dbo.Candles
        WHERE Symbol = @sym
        GROUP BY [Interval]
        ORDER BY MAX(TsUtc) DESC;";

            using var conn = new Microsoft.Data.SqlClient.SqlConnection(_connStr);
            conn.Open();
            using (var cmd = new Microsoft.Data.SqlClient.SqlCommand(sqlFetch, conn))
            {
                cmd.Parameters.AddWithValue("@n", count);
                cmd.Parameters.AddWithValue("@sym", sym1);
                cmd.Parameters.AddWithValue("@int", interval);
                using var r = cmd.ExecuteReader();
                while (r.Read()) list.Add((r.GetDateTime(0), (double)r.GetDecimal(1)));
            }
            if (list.Count > 0) { list.Reverse(); return list; }
            string? int1 = null;
            using (var cmd = new Microsoft.Data.SqlClient.SqlCommand(sqlPickInt, conn))
            {
                cmd.Parameters.AddWithValue("@sym", sym1);
                int1 = cmd.ExecuteScalar() as string;
            }
            if (!string.IsNullOrEmpty(int1))
            {
                using var cmd = new Microsoft.Data.SqlClient.SqlCommand(sqlFetch, conn);
                cmd.Parameters.AddWithValue("@n", count);
                cmd.Parameters.AddWithValue("@sym", sym1);
                cmd.Parameters.AddWithValue("@int", int1);
                using var r = cmd.ExecuteReader();
                while (r.Read()) list.Add((r.GetDateTime(0), (double)r.GetDecimal(1)));
            }
            if (list.Count > 0) { list.Reverse(); return list; }
            string? int2 = null;
            using (var cmd = new Microsoft.Data.SqlClient.SqlCommand(sqlPickInt, conn))
            {
                cmd.Parameters.AddWithValue("@sym", sym2);
                int2 = cmd.ExecuteScalar() as string;
            }
            if (!string.IsNullOrEmpty(int2))
            {
                using var cmd = new Microsoft.Data.SqlClient.SqlCommand(sqlFetch, conn);
                cmd.Parameters.AddWithValue("@n", count);
                cmd.Parameters.AddWithValue("@sym", sym2);
                cmd.Parameters.AddWithValue("@int", int2);
                using var r = cmd.ExecuteReader();
                while (r.Read()) list.Add((r.GetDateTime(0), (double)r.GetDecimal(1)));
            }

            list.Reverse();
            return list;
        }
        private void LoadChartForSelectedSymbol(string? interval = null, int count = 150)
        {
            if (string.IsNullOrWhiteSpace(_selectedSymbol)) return;

            _currentInterval = interval ?? _currentInterval;

            var data = GetRecentCloses(_selectedSymbol, _currentInterval, count);

            var series = chartPrice.Series["Price"];
            series.Points.Clear();
            series.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;

            foreach (var (t, close) in data)
                series.Points.AddXY(t.ToLocalTime(), close);

            chartPrice.ChartAreas[0].RecalculateAxesScale();
        }


        public static class Indicators
        {
            //RSI HESAPLAYICI
            public static double CalculateRSI(double[] closes, int period = 14)
            {
                if (closes == null || closes.Length < period + 1)
                {
                    throw new Exception("Yeterli veri yok");
                }
                double gain = 0.0;
                double loss = 0.0;
                for (int i = closes.Length - period; i < closes.Length; i++)
                {
                    double change = closes[i] - closes[i - 1];
                    if (change > 0)
                    {
                        gain += change;
                    }
                    else
                    {
                        loss -= change;
                    }
                }
                double avgGain = gain / period;
                double avgLoss = loss / period;
                if (avgLoss == 0)
                {
                    return 100.0;
                }
                double rs = avgGain / avgLoss;
                return 100.0 - (100.0 / (1.0 + rs));
            }
            //SMA HESAPLAYICI
            public static double CalculateSMA(double[] closes, int period)
            {
                if (closes.Length < period)
                {
                    throw new Exception("Yeterli veri yok");
                }
                double sum = 0.0;
                for (int i = closes.Length - period; i < closes.Length; i++)
                {
                    sum += closes[i];
                }
                return sum / period;
            }
            //EMA HESAPLAYICI
            public static double CalculateEMA(double[] closes, int period)
            {
                if (closes == null || closes.Length < period)
                    throw new Exception("Yeterli veri yok");

                double ema = 0.0;
                for (int i = 0; i < period; i++) ema += closes[i];
                ema /= period;

                if (closes.Length == period) return ema;

                double k = 2.0 / (period + 1);
                for (int i = period; i < closes.Length; i++)
                    ema = (closes[i] - ema) * k + ema;

                return ema;
            }
            public static (double üst, double alt, double mid) CalculateBollinger(double[] closes, int period)
            {
                double mid = CalculateSMA(closes, period);
                double üst = 0.0;
                double alt = 0.0;
                double y = 0.0;
                for (int i = closes.Length - period; i < closes.Length; i++)
                {
                    double x = closes[i] - mid;
                    y += x * x;
                }
                double z = y / period;
                double m = Math.Sqrt(z);
                üst = mid + (2 * m);
                alt = mid - (2 * m);


                return (üst, alt, mid);
            }
        }
        private IndicatorSinyal.Result? ShowSignalSummary(string uiSymbol)
        {
            var closes = GetRecentCloses(uiSymbol, _currentInterval, 200)
                 .Select(x => x.Item2)
                 .ToArray();
            if (closes.Length < 20) { return null; }
            double last = closes[^1];
            double rsi = Indicators.CalculateRSI(closes, 14);
            double sma20 = Indicators.CalculateSMA(closes, 20);
            double ema20 = Indicators.CalculateEMA(closes, 20);
            var boll = Indicators.CalculateBollinger(closes, 20);
            double bolüst = boll.üst;
            double bolmid = boll.mid;
            double bolalt = boll.alt;
            return IndicatorSinyal.Evaluate(last, rsi, sma20, ema20, bolüst, bolmid, bolalt);
        }
        public static class IndicatorSinyal
        {
            const int HIZLI_AL = 3;
            const int AL = 2;
            const int NOTR = 0;
            const int SAT = -2;
            const int HIZLI_SAT = -3;

            public struct Result
            {
                public int RsiScore; public string RsiLabel;
                public int SmaEmaScore; public string SmaEmaLabel;
                public int BollScore; public string BollLabel;
                public int TotalScore; public string OverallLabel;
            }
            public static Result Evaluate(double last, double rsi, double sma20, double ema20, double bolüst, double bolmid, double bolalt)
            {
                int rsiScore = ScoreRsi(rsi);
                int smaEmaScore = ScoreSmaEma(last,sma20, ema20);
                int bollScore = ScoreBoll(last, bolüst, bolmid, bolalt);
                int total = rsiScore + smaEmaScore + bollScore;
                return new Result
                {
                    RsiScore = rsiScore,
                    RsiLabel = LabelFromScore(rsiScore),
                    SmaEmaScore = smaEmaScore,
                    SmaEmaLabel = LabelFromScore(smaEmaScore),
                    BollScore = bollScore,
                    BollLabel = LabelFromScore(bollScore),
                    TotalScore = total,
                    OverallLabel = LabelFromScore(total)
                };
            }
            static int ScoreRsi(double rsi)
            {
                if (rsi < 30) return +2;
                else if (rsi < 45) return +1;           // 30–45
                else if (rsi <= 55) return 0;           // 45–55
                else if (rsi <= 70) return -1;           // 55–70
                else return -2;           // >70
            }
            static int ScoreSmaEma(double price, double sma, double ema)
            {
                int s = 0;
                
                if (price < sma && price < ema) s += 1;  
                else if (price > sma && price > ema) s -= 1;  

               
                if (ema > sma) s += 1;
                else if (ema < sma) s -= 1;

                return Math.Max(-2, Math.Min(2, s));
            }
            static int ScoreBoll(double price, double upper, double middle, double lower)
            {
                if (price <= lower) return +2;  // Alt banda temas
                else if (price < middle) return +1;  // Alt yarı 
                else if (price >= upper) return -2;  // Üst banda temas
                else if (price > middle) return -1;  // Üst yarı 
                else return 0;  // Tam orta bant
            }
            static string LabelFromScore(int score)
            {
                if (score >= HIZLI_AL) return "Hızlı Al";
                if (score == AL) return "Al";
                if (score <= HIZLI_SAT) return "Hızlı Sat";
                if (score == SAT) return "Sat";
                // 0 veya 1
                return "Nötr";
            }


        }
    }
}
