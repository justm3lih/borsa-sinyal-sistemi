namespace SON_ORJİN
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            timer1 = new System.Windows.Forms.Timer(components);
            splitMain = new SplitContainer();
            tableStocks = new TableLayoutPanel();
            lbl_BIST30_Price = new MetroFramework.Controls.MetroLabel();
            lbl_BIST30_Symbol = new MetroFramework.Controls.MetroLabel();
            lbl_YKBNK_Price = new MetroFramework.Controls.MetroLabel();
            lbl_YKBNK_Symbol = new MetroFramework.Controls.MetroLabel();
            lbl_TUPRS_Price = new MetroFramework.Controls.MetroLabel();
            lbl_TUPRS_Symbol = new MetroFramework.Controls.MetroLabel();
            lbl_TOASO_Price = new MetroFramework.Controls.MetroLabel();
            lbl_TOASO_Symbol = new MetroFramework.Controls.MetroLabel();
            lbl_THYAO_Price = new MetroFramework.Controls.MetroLabel();
            lbl_THYAO_Symbol = new MetroFramework.Controls.MetroLabel();
            lbl_TCELL_Price = new MetroFramework.Controls.MetroLabel();
            lbl_TCELL_Symbol = new MetroFramework.Controls.MetroLabel();
            lbl_SOKM_Price = new MetroFramework.Controls.MetroLabel();
            lbl_SOKM_Symbol = new MetroFramework.Controls.MetroLabel();
            lbl_SISE_Price = new MetroFramework.Controls.MetroLabel();
            lbl_SISE_Symbol = new MetroFramework.Controls.MetroLabel();
            lbl_SASA_Price = new MetroFramework.Controls.MetroLabel();
            lbl_SASA_Symbol = new MetroFramework.Controls.MetroLabel();
            lbl_SAHOL_Price = new MetroFramework.Controls.MetroLabel();
            lbl_SAHOL_Symbol = new MetroFramework.Controls.MetroLabel();
            lbl_PGSUS_Price = new MetroFramework.Controls.MetroLabel();
            lbl_PGSUS_Symbol = new MetroFramework.Controls.MetroLabel();
            lbl_PETKM_Price = new MetroFramework.Controls.MetroLabel();
            lbl_PETKM_Symbol = new MetroFramework.Controls.MetroLabel();
            lbl_KRDMD_Price = new MetroFramework.Controls.MetroLabel();
            lbl_KRDMD_Symbol = new MetroFramework.Controls.MetroLabel();
            lbl_KOZAL_Price = new MetroFramework.Controls.MetroLabel();
            lbl_KOZAL_Symbol = new MetroFramework.Controls.MetroLabel();
            lbl_KOZAA_Price = new MetroFramework.Controls.MetroLabel();
            lbl_KOZAA_Symbol = new MetroFramework.Controls.MetroLabel();
            lbl_KCHOL_Price = new MetroFramework.Controls.MetroLabel();
            lbl_KCHOL_Symbol = new MetroFramework.Controls.MetroLabel();
            lbl_ISCTR_Price = new MetroFramework.Controls.MetroLabel();
            lbl_ISCTR_Symbol = new MetroFramework.Controls.MetroLabel();
            lbl_HEKTS_Price = new MetroFramework.Controls.MetroLabel();
            lbl_HEKTS_Symbol = new MetroFramework.Controls.MetroLabel();
            lbl_GUBRF_Price = new MetroFramework.Controls.MetroLabel();
            lbl_GUBRF_Symbol = new MetroFramework.Controls.MetroLabel();
            lbl_GARAN_Price = new MetroFramework.Controls.MetroLabel();
            lbl_GARAN_Symbol = new MetroFramework.Controls.MetroLabel();
            lbl_FROTO_Price = new MetroFramework.Controls.MetroLabel();
            lbl_FROTO_Symbol = new MetroFramework.Controls.MetroLabel();
            lbl_EREGL_Price = new MetroFramework.Controls.MetroLabel();
            lbl_EREGL_Symbol = new MetroFramework.Controls.MetroLabel();
            lbl_ENKAI_Price = new MetroFramework.Controls.MetroLabel();
            lbl_ENKAI_Symbol = new MetroFramework.Controls.MetroLabel();
            lbl_EKGYO_Price = new MetroFramework.Controls.MetroLabel();
            lbl_EKGYO_Symbol = new MetroFramework.Controls.MetroLabel();
            lbl_BRSAN_Price = new MetroFramework.Controls.MetroLabel();
            lbl_BRSAN_Symbol = new MetroFramework.Controls.MetroLabel();
            lbl_BIMAS_Price = new MetroFramework.Controls.MetroLabel();
            lbl_BIMAS_Symbol = new MetroFramework.Controls.MetroLabel();
            lbl_ASTOR_Price = new MetroFramework.Controls.MetroLabel();
            lbl_ASTOR_Symbol = new MetroFramework.Controls.MetroLabel();
            lbl_ARCLK_Price = new MetroFramework.Controls.MetroLabel();
            lbl_ARCLK_Symbol = new MetroFramework.Controls.MetroLabel();
            lbl_ASELS_Price = new MetroFramework.Controls.MetroLabel();
            lbl_ASELS_Symbol = new MetroFramework.Controls.MetroLabel();
            lbl_AKBNK_Symbol = new MetroFramework.Controls.MetroLabel();
            lbl_AKBNK_Price = new MetroFramework.Controls.MetroLabel();
            chartPrice = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
            splitMain.Panel1.SuspendLayout();
            splitMain.Panel2.SuspendLayout();
            splitMain.SuspendLayout();
            tableStocks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartPrice).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 15000;
            timer1.Tick += timer1_Tick;
            // 
            // splitMain
            // 
            splitMain.AccessibleName = "";
            splitMain.Dock = DockStyle.Fill;
            splitMain.Location = new Point(0, 0);
            splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            splitMain.Panel1.Controls.Add(tableStocks);
            // 
            // splitMain.Panel2
            // 
            splitMain.Panel2.Controls.Add(chartPrice);
            splitMain.Size = new Size(1284, 695);
            splitMain.SplitterDistance = 562;
            splitMain.TabIndex = 0;
            // 
            // tableStocks
            // 
            tableStocks.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableStocks.ColumnCount = 4;
            tableStocks.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableStocks.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableStocks.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableStocks.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableStocks.Controls.Add(lbl_BIST30_Price, 3, 14);
            tableStocks.Controls.Add(lbl_BIST30_Symbol, 2, 14);
            tableStocks.Controls.Add(lbl_YKBNK_Price, 1, 14);
            tableStocks.Controls.Add(lbl_YKBNK_Symbol, 0, 14);
            tableStocks.Controls.Add(lbl_TUPRS_Price, 3, 13);
            tableStocks.Controls.Add(lbl_TUPRS_Symbol, 2, 13);
            tableStocks.Controls.Add(lbl_TOASO_Price, 1, 13);
            tableStocks.Controls.Add(lbl_TOASO_Symbol, 0, 13);
            tableStocks.Controls.Add(lbl_THYAO_Price, 3, 12);
            tableStocks.Controls.Add(lbl_THYAO_Symbol, 2, 12);
            tableStocks.Controls.Add(lbl_TCELL_Price, 1, 12);
            tableStocks.Controls.Add(lbl_TCELL_Symbol, 0, 12);
            tableStocks.Controls.Add(lbl_SOKM_Price, 3, 11);
            tableStocks.Controls.Add(lbl_SOKM_Symbol, 2, 11);
            tableStocks.Controls.Add(lbl_SISE_Price, 1, 11);
            tableStocks.Controls.Add(lbl_SISE_Symbol, 0, 11);
            tableStocks.Controls.Add(lbl_SASA_Price, 3, 10);
            tableStocks.Controls.Add(lbl_SASA_Symbol, 2, 10);
            tableStocks.Controls.Add(lbl_SAHOL_Price, 1, 10);
            tableStocks.Controls.Add(lbl_SAHOL_Symbol, 0, 10);
            tableStocks.Controls.Add(lbl_PGSUS_Price, 3, 9);
            tableStocks.Controls.Add(lbl_PGSUS_Symbol, 2, 9);
            tableStocks.Controls.Add(lbl_PETKM_Price, 1, 9);
            tableStocks.Controls.Add(lbl_PETKM_Symbol, 0, 9);
            tableStocks.Controls.Add(lbl_KRDMD_Price, 3, 8);
            tableStocks.Controls.Add(lbl_KRDMD_Symbol, 2, 8);
            tableStocks.Controls.Add(lbl_KOZAL_Price, 1, 8);
            tableStocks.Controls.Add(lbl_KOZAL_Symbol, 0, 8);
            tableStocks.Controls.Add(lbl_KOZAA_Price, 3, 7);
            tableStocks.Controls.Add(lbl_KOZAA_Symbol, 2, 7);
            tableStocks.Controls.Add(lbl_KCHOL_Price, 1, 7);
            tableStocks.Controls.Add(lbl_KCHOL_Symbol, 0, 7);
            tableStocks.Controls.Add(lbl_ISCTR_Price, 3, 6);
            tableStocks.Controls.Add(lbl_ISCTR_Symbol, 2, 6);
            tableStocks.Controls.Add(lbl_HEKTS_Price, 1, 6);
            tableStocks.Controls.Add(lbl_HEKTS_Symbol, 0, 6);
            tableStocks.Controls.Add(lbl_GUBRF_Price, 3, 5);
            tableStocks.Controls.Add(lbl_GUBRF_Symbol, 2, 5);
            tableStocks.Controls.Add(lbl_GARAN_Price, 1, 5);
            tableStocks.Controls.Add(lbl_GARAN_Symbol, 0, 5);
            tableStocks.Controls.Add(lbl_FROTO_Price, 3, 4);
            tableStocks.Controls.Add(lbl_FROTO_Symbol, 2, 4);
            tableStocks.Controls.Add(lbl_EREGL_Price, 1, 4);
            tableStocks.Controls.Add(lbl_EREGL_Symbol, 0, 4);
            tableStocks.Controls.Add(lbl_ENKAI_Price, 3, 3);
            tableStocks.Controls.Add(lbl_ENKAI_Symbol, 2, 3);
            tableStocks.Controls.Add(lbl_EKGYO_Price, 1, 3);
            tableStocks.Controls.Add(lbl_EKGYO_Symbol, 0, 3);
            tableStocks.Controls.Add(lbl_BRSAN_Price, 3, 2);
            tableStocks.Controls.Add(lbl_BRSAN_Symbol, 2, 2);
            tableStocks.Controls.Add(lbl_BIMAS_Price, 1, 2);
            tableStocks.Controls.Add(lbl_BIMAS_Symbol, 0, 2);
            tableStocks.Controls.Add(lbl_ASTOR_Price, 3, 1);
            tableStocks.Controls.Add(lbl_ASTOR_Symbol, 2, 1);
            tableStocks.Controls.Add(lbl_ARCLK_Price, 1, 1);
            tableStocks.Controls.Add(lbl_ARCLK_Symbol, 0, 1);
            tableStocks.Controls.Add(lbl_ASELS_Price, 3, 0);
            tableStocks.Controls.Add(lbl_ASELS_Symbol, 2, 0);
            tableStocks.Controls.Add(lbl_AKBNK_Symbol, 0, 0);
            tableStocks.Controls.Add(lbl_AKBNK_Price, 1, 0);
            tableStocks.Dock = DockStyle.Fill;
            tableStocks.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableStocks.Location = new Point(0, 0);
            tableStocks.Name = "tableStocks";
            tableStocks.RowCount = 16;
            tableStocks.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableStocks.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableStocks.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableStocks.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableStocks.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableStocks.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableStocks.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableStocks.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableStocks.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableStocks.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableStocks.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableStocks.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableStocks.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableStocks.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableStocks.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableStocks.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableStocks.Size = new Size(562, 695);
            tableStocks.TabIndex = 0;
            // 
            // lbl_BIST30_Price
            // 
            lbl_BIST30_Price.AutoSize = true;
            lbl_BIST30_Price.Cursor = Cursors.Hand;
            lbl_BIST30_Price.CustomBackground = false;
            lbl_BIST30_Price.Dock = DockStyle.Fill;
            lbl_BIST30_Price.FontSize = MetroFramework.MetroLabelSize.Medium;
            lbl_BIST30_Price.FontWeight = MetroFramework.MetroLabelWeight.Light;
            lbl_BIST30_Price.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            lbl_BIST30_Price.Location = new Point(396, 645);
            lbl_BIST30_Price.Name = "lbl_BIST30_Price";
            lbl_BIST30_Price.Size = new Size(162, 45);
            lbl_BIST30_Price.Style = MetroFramework.MetroColorStyle.Blue;
            lbl_BIST30_Price.StyleManager = null;
            lbl_BIST30_Price.TabIndex = 59;
            lbl_BIST30_Price.Tag = "BIST30";
            lbl_BIST30_Price.Text = "-";
            lbl_BIST30_Price.TextAlign = ContentAlignment.MiddleRight;
            lbl_BIST30_Price.Theme = MetroFramework.MetroThemeStyle.Light;
            lbl_BIST30_Price.UseStyleColors = false;
            lbl_BIST30_Price.Click += lbl_Click;
            lbl_BIST30_Price.DoubleClick += PriceLabel_DoubleClick;
            // 
            // lbl_BIST30_Symbol
            // 
            lbl_BIST30_Symbol.AutoSize = true;
            lbl_BIST30_Symbol.Cursor = Cursors.Hand;
            lbl_BIST30_Symbol.CustomBackground = false;
            lbl_BIST30_Symbol.Dock = DockStyle.Fill;
            lbl_BIST30_Symbol.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbl_BIST30_Symbol.FontSize = MetroFramework.MetroLabelSize.Medium;
            lbl_BIST30_Symbol.FontWeight = MetroFramework.MetroLabelWeight.Light;
            lbl_BIST30_Symbol.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            lbl_BIST30_Symbol.Location = new Point(284, 645);
            lbl_BIST30_Symbol.Name = "lbl_BIST30_Symbol";
            lbl_BIST30_Symbol.Size = new Size(105, 45);
            lbl_BIST30_Symbol.Style = MetroFramework.MetroColorStyle.Blue;
            lbl_BIST30_Symbol.StyleManager = null;
            lbl_BIST30_Symbol.TabIndex = 58;
            lbl_BIST30_Symbol.Tag = "BIST30";
            lbl_BIST30_Symbol.Text = "BIST30";
            lbl_BIST30_Symbol.TextAlign = ContentAlignment.MiddleLeft;
            lbl_BIST30_Symbol.Theme = MetroFramework.MetroThemeStyle.Light;
            lbl_BIST30_Symbol.UseStyleColors = false;
            lbl_BIST30_Symbol.Click += lbl_Click;
            lbl_BIST30_Symbol.DoubleClick += PriceLabel_DoubleClick;
            // 
            // lbl_YKBNK_Price
            // 
            lbl_YKBNK_Price.AutoSize = true;
            lbl_YKBNK_Price.Cursor = Cursors.Hand;
            lbl_YKBNK_Price.CustomBackground = false;
            lbl_YKBNK_Price.Dock = DockStyle.Fill;
            lbl_YKBNK_Price.FontSize = MetroFramework.MetroLabelSize.Medium;
            lbl_YKBNK_Price.FontWeight = MetroFramework.MetroLabelWeight.Light;
            lbl_YKBNK_Price.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            lbl_YKBNK_Price.Location = new Point(116, 645);
            lbl_YKBNK_Price.Name = "lbl_YKBNK_Price";
            lbl_YKBNK_Price.Size = new Size(161, 45);
            lbl_YKBNK_Price.Style = MetroFramework.MetroColorStyle.Blue;
            lbl_YKBNK_Price.StyleManager = null;
            lbl_YKBNK_Price.TabIndex = 57;
            lbl_YKBNK_Price.Tag = "YKBNK";
            lbl_YKBNK_Price.Text = "-";
            lbl_YKBNK_Price.TextAlign = ContentAlignment.MiddleRight;
            lbl_YKBNK_Price.Theme = MetroFramework.MetroThemeStyle.Light;
            lbl_YKBNK_Price.UseStyleColors = false;
            lbl_YKBNK_Price.Click += lbl_Click;
            lbl_YKBNK_Price.DoubleClick += PriceLabel_DoubleClick;
            // 
            // lbl_YKBNK_Symbol
            // 
            lbl_YKBNK_Symbol.AutoSize = true;
            lbl_YKBNK_Symbol.Cursor = Cursors.Hand;
            lbl_YKBNK_Symbol.CustomBackground = false;
            lbl_YKBNK_Symbol.Dock = DockStyle.Fill;
            lbl_YKBNK_Symbol.FontSize = MetroFramework.MetroLabelSize.Medium;
            lbl_YKBNK_Symbol.FontWeight = MetroFramework.MetroLabelWeight.Light;
            lbl_YKBNK_Symbol.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            lbl_YKBNK_Symbol.Location = new Point(4, 645);
            lbl_YKBNK_Symbol.Name = "lbl_YKBNK_Symbol";
            lbl_YKBNK_Symbol.Size = new Size(105, 45);
            lbl_YKBNK_Symbol.Style = MetroFramework.MetroColorStyle.Blue;
            lbl_YKBNK_Symbol.StyleManager = null;
            lbl_YKBNK_Symbol.TabIndex = 56;
            lbl_YKBNK_Symbol.Tag = "YKBNK";
            lbl_YKBNK_Symbol.Text = "YKBNK";
            lbl_YKBNK_Symbol.TextAlign = ContentAlignment.MiddleLeft;
            lbl_YKBNK_Symbol.Theme = MetroFramework.MetroThemeStyle.Light;
            lbl_YKBNK_Symbol.UseStyleColors = false;
            lbl_YKBNK_Symbol.Click += lbl_Click;
            lbl_YKBNK_Symbol.DoubleClick += PriceLabel_DoubleClick;
            // 
            // lbl_TUPRS_Price
            // 
            lbl_TUPRS_Price.AutoSize = true;
            lbl_TUPRS_Price.Cursor = Cursors.Hand;
            lbl_TUPRS_Price.CustomBackground = false;
            lbl_TUPRS_Price.Dock = DockStyle.Fill;
            lbl_TUPRS_Price.FontSize = MetroFramework.MetroLabelSize.Medium;
            lbl_TUPRS_Price.FontWeight = MetroFramework.MetroLabelWeight.Light;
            lbl_TUPRS_Price.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            lbl_TUPRS_Price.Location = new Point(396, 599);
            lbl_TUPRS_Price.Name = "lbl_TUPRS_Price";
            lbl_TUPRS_Price.Size = new Size(162, 45);
            lbl_TUPRS_Price.Style = MetroFramework.MetroColorStyle.Blue;
            lbl_TUPRS_Price.StyleManager = null;
            lbl_TUPRS_Price.TabIndex = 55;
            lbl_TUPRS_Price.Tag = "TUPRS";
            lbl_TUPRS_Price.Text = "-";
            lbl_TUPRS_Price.TextAlign = ContentAlignment.MiddleRight;
            lbl_TUPRS_Price.Theme = MetroFramework.MetroThemeStyle.Light;
            lbl_TUPRS_Price.UseStyleColors = false;
            lbl_TUPRS_Price.Click += lbl_Click;
            lbl_TUPRS_Price.DoubleClick += PriceLabel_DoubleClick;
            // 
            // lbl_TUPRS_Symbol
            // 
            lbl_TUPRS_Symbol.AutoSize = true;
            lbl_TUPRS_Symbol.Cursor = Cursors.Hand;
            lbl_TUPRS_Symbol.CustomBackground = false;
            lbl_TUPRS_Symbol.Dock = DockStyle.Fill;
            lbl_TUPRS_Symbol.FontSize = MetroFramework.MetroLabelSize.Medium;
            lbl_TUPRS_Symbol.FontWeight = MetroFramework.MetroLabelWeight.Light;
            lbl_TUPRS_Symbol.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            lbl_TUPRS_Symbol.Location = new Point(284, 599);
            lbl_TUPRS_Symbol.Name = "lbl_TUPRS_Symbol";
            lbl_TUPRS_Symbol.Size = new Size(105, 45);
            lbl_TUPRS_Symbol.Style = MetroFramework.MetroColorStyle.Blue;
            lbl_TUPRS_Symbol.StyleManager = null;
            lbl_TUPRS_Symbol.TabIndex = 54;
            lbl_TUPRS_Symbol.Tag = "TUPRS";
            lbl_TUPRS_Symbol.Text = "TUPRS";
            lbl_TUPRS_Symbol.TextAlign = ContentAlignment.MiddleLeft;
            lbl_TUPRS_Symbol.Theme = MetroFramework.MetroThemeStyle.Light;
            lbl_TUPRS_Symbol.UseStyleColors = false;
            lbl_TUPRS_Symbol.Click += lbl_Click;
            lbl_TUPRS_Symbol.DoubleClick += PriceLabel_DoubleClick;
            // 
            // lbl_TOASO_Price
            // 
            lbl_TOASO_Price.AutoSize = true;
            lbl_TOASO_Price.Cursor = Cursors.Hand;
            lbl_TOASO_Price.CustomBackground = false;
            lbl_TOASO_Price.Dock = DockStyle.Fill;
            lbl_TOASO_Price.FontSize = MetroFramework.MetroLabelSize.Medium;
            lbl_TOASO_Price.FontWeight = MetroFramework.MetroLabelWeight.Light;
            lbl_TOASO_Price.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            lbl_TOASO_Price.Location = new Point(116, 599);
            lbl_TOASO_Price.Name = "lbl_TOASO_Price";
            lbl_TOASO_Price.Size = new Size(161, 45);
            lbl_TOASO_Price.Style = MetroFramework.MetroColorStyle.Blue;
            lbl_TOASO_Price.StyleManager = null;
            lbl_TOASO_Price.TabIndex = 53;
            lbl_TOASO_Price.Tag = "TOASO";
            lbl_TOASO_Price.Text = "-";
            lbl_TOASO_Price.TextAlign = ContentAlignment.MiddleRight;
            lbl_TOASO_Price.Theme = MetroFramework.MetroThemeStyle.Light;
            lbl_TOASO_Price.UseStyleColors = false;
            lbl_TOASO_Price.Click += lbl_Click;
            lbl_TOASO_Price.DoubleClick += PriceLabel_DoubleClick;
            // 
            // lbl_TOASO_Symbol
            // 
            lbl_TOASO_Symbol.AutoSize = true;
            lbl_TOASO_Symbol.Cursor = Cursors.Hand;
            lbl_TOASO_Symbol.CustomBackground = false;
            lbl_TOASO_Symbol.Dock = DockStyle.Fill;
            lbl_TOASO_Symbol.FontSize = MetroFramework.MetroLabelSize.Medium;
            lbl_TOASO_Symbol.FontWeight = MetroFramework.MetroLabelWeight.Light;
            lbl_TOASO_Symbol.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            lbl_TOASO_Symbol.Location = new Point(4, 599);
            lbl_TOASO_Symbol.Name = "lbl_TOASO_Symbol";
            lbl_TOASO_Symbol.Size = new Size(105, 45);
            lbl_TOASO_Symbol.Style = MetroFramework.MetroColorStyle.Blue;
            lbl_TOASO_Symbol.StyleManager = null;
            lbl_TOASO_Symbol.TabIndex = 52;
            lbl_TOASO_Symbol.Tag = "TOASO";
            lbl_TOASO_Symbol.Text = "TOASO";
            lbl_TOASO_Symbol.TextAlign = ContentAlignment.MiddleLeft;
            lbl_TOASO_Symbol.Theme = MetroFramework.MetroThemeStyle.Light;
            lbl_TOASO_Symbol.UseStyleColors = false;
            lbl_TOASO_Symbol.Click += lbl_Click;
            lbl_TOASO_Symbol.DoubleClick += PriceLabel_DoubleClick;
            // 
            // lbl_THYAO_Price
            // 
            lbl_THYAO_Price.AutoSize = true;
            lbl_THYAO_Price.Cursor = Cursors.Hand;
            lbl_THYAO_Price.CustomBackground = false;
            lbl_THYAO_Price.Dock = DockStyle.Fill;
            lbl_THYAO_Price.FontSize = MetroFramework.MetroLabelSize.Medium;
            lbl_THYAO_Price.FontWeight = MetroFramework.MetroLabelWeight.Light;
            lbl_THYAO_Price.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            lbl_THYAO_Price.Location = new Point(396, 553);
            lbl_THYAO_Price.Name = "lbl_THYAO_Price";
            lbl_THYAO_Price.Size = new Size(162, 45);
            lbl_THYAO_Price.Style = MetroFramework.MetroColorStyle.Blue;
            lbl_THYAO_Price.StyleManager = null;
            lbl_THYAO_Price.TabIndex = 51;
            lbl_THYAO_Price.Tag = "THYAO";
            lbl_THYAO_Price.Text = "-";
            lbl_THYAO_Price.TextAlign = ContentAlignment.MiddleRight;
            lbl_THYAO_Price.Theme = MetroFramework.MetroThemeStyle.Light;
            lbl_THYAO_Price.UseStyleColors = false;
            lbl_THYAO_Price.Click += lbl_Click;
            lbl_THYAO_Price.DoubleClick += PriceLabel_DoubleClick;
            // 
            // lbl_THYAO_Symbol
            // 
            lbl_THYAO_Symbol.AutoSize = true;
            lbl_THYAO_Symbol.Cursor = Cursors.Hand;
            lbl_THYAO_Symbol.CustomBackground = false;
            lbl_THYAO_Symbol.Dock = DockStyle.Fill;
            lbl_THYAO_Symbol.FontSize = MetroFramework.MetroLabelSize.Medium;
            lbl_THYAO_Symbol.FontWeight = MetroFramework.MetroLabelWeight.Light;
            lbl_THYAO_Symbol.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            lbl_THYAO_Symbol.Location = new Point(284, 553);
            lbl_THYAO_Symbol.Name = "lbl_THYAO_Symbol";
            lbl_THYAO_Symbol.Size = new Size(105, 45);
            lbl_THYAO_Symbol.Style = MetroFramework.MetroColorStyle.Blue;
            lbl_THYAO_Symbol.StyleManager = null;
            lbl_THYAO_Symbol.TabIndex = 50;
            lbl_THYAO_Symbol.Tag = "THYAO";
            lbl_THYAO_Symbol.Text = "THYAO";
            lbl_THYAO_Symbol.TextAlign = ContentAlignment.MiddleLeft;
            lbl_THYAO_Symbol.Theme = MetroFramework.MetroThemeStyle.Light;
            lbl_THYAO_Symbol.UseStyleColors = false;
            lbl_THYAO_Symbol.Click += lbl_Click;
            lbl_THYAO_Symbol.DoubleClick += PriceLabel_DoubleClick;
            // 
            // lbl_TCELL_Price
            // 
            lbl_TCELL_Price.AutoSize = true;
            lbl_TCELL_Price.Cursor = Cursors.Hand;
            lbl_TCELL_Price.CustomBackground = false;
            lbl_TCELL_Price.Dock = DockStyle.Fill;
            lbl_TCELL_Price.FontSize = MetroFramework.MetroLabelSize.Medium;
            lbl_TCELL_Price.FontWeight = MetroFramework.MetroLabelWeight.Light;
            lbl_TCELL_Price.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            lbl_TCELL_Price.Location = new Point(116, 553);
            lbl_TCELL_Price.Name = "lbl_TCELL_Price";
            lbl_TCELL_Price.Size = new Size(161, 45);
            lbl_TCELL_Price.Style = MetroFramework.MetroColorStyle.Blue;
            lbl_TCELL_Price.StyleManager = null;
            lbl_TCELL_Price.TabIndex = 49;
            lbl_TCELL_Price.Tag = "TCELL";
            lbl_TCELL_Price.Text = "-";
            lbl_TCELL_Price.TextAlign = ContentAlignment.MiddleRight;
            lbl_TCELL_Price.Theme = MetroFramework.MetroThemeStyle.Light;
            lbl_TCELL_Price.UseStyleColors = false;
            lbl_TCELL_Price.Click += lbl_Click;
            lbl_TCELL_Price.DoubleClick += PriceLabel_DoubleClick;
            // 
            // lbl_TCELL_Symbol
            // 
            lbl_TCELL_Symbol.AutoSize = true;
            lbl_TCELL_Symbol.Cursor = Cursors.Hand;
            lbl_TCELL_Symbol.CustomBackground = false;
            lbl_TCELL_Symbol.Dock = DockStyle.Fill;
            lbl_TCELL_Symbol.FontSize = MetroFramework.MetroLabelSize.Medium;
            lbl_TCELL_Symbol.FontWeight = MetroFramework.MetroLabelWeight.Light;
            lbl_TCELL_Symbol.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            lbl_TCELL_Symbol.Location = new Point(4, 553);
            lbl_TCELL_Symbol.Name = "lbl_TCELL_Symbol";
            lbl_TCELL_Symbol.Size = new Size(105, 45);
            lbl_TCELL_Symbol.Style = MetroFramework.MetroColorStyle.Blue;
            lbl_TCELL_Symbol.StyleManager = null;
            lbl_TCELL_Symbol.TabIndex = 48;
            lbl_TCELL_Symbol.Tag = "TCELL";
            lbl_TCELL_Symbol.Text = "TCELL";
            lbl_TCELL_Symbol.TextAlign = ContentAlignment.MiddleLeft;
            lbl_TCELL_Symbol.Theme = MetroFramework.MetroThemeStyle.Light;
            lbl_TCELL_Symbol.UseStyleColors = false;
            lbl_TCELL_Symbol.Click += lbl_Click;
            lbl_TCELL_Symbol.DoubleClick += PriceLabel_DoubleClick;
            // 
            // lbl_SOKM_Price
            // 
            lbl_SOKM_Price.AutoSize = true;
            lbl_SOKM_Price.Cursor = Cursors.Hand;
            lbl_SOKM_Price.CustomBackground = false;
            lbl_SOKM_Price.Dock = DockStyle.Fill;
            lbl_SOKM_Price.FontSize = MetroFramework.MetroLabelSize.Medium;
            lbl_SOKM_Price.FontWeight = MetroFramework.MetroLabelWeight.Light;
            lbl_SOKM_Price.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            lbl_SOKM_Price.Location = new Point(396, 507);
            lbl_SOKM_Price.Name = "lbl_SOKM_Price";
            lbl_SOKM_Price.Size = new Size(162, 45);
            lbl_SOKM_Price.Style = MetroFramework.MetroColorStyle.Blue;
            lbl_SOKM_Price.StyleManager = null;
            lbl_SOKM_Price.TabIndex = 47;
            lbl_SOKM_Price.Tag = "SOKM";
            lbl_SOKM_Price.Text = "-";
            lbl_SOKM_Price.TextAlign = ContentAlignment.MiddleRight;
            lbl_SOKM_Price.Theme = MetroFramework.MetroThemeStyle.Light;
            lbl_SOKM_Price.UseStyleColors = false;
            lbl_SOKM_Price.Click += lbl_Click;
            // 
            // lbl_SOKM_Symbol
            // 
            lbl_SOKM_Symbol.AutoSize = true;
            lbl_SOKM_Symbol.Cursor = Cursors.Hand;
            lbl_SOKM_Symbol.CustomBackground = false;
            lbl_SOKM_Symbol.Dock = DockStyle.Fill;
            lbl_SOKM_Symbol.FontSize = MetroFramework.MetroLabelSize.Medium;
            lbl_SOKM_Symbol.FontWeight = MetroFramework.MetroLabelWeight.Light;
            lbl_SOKM_Symbol.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            lbl_SOKM_Symbol.Location = new Point(284, 507);
            lbl_SOKM_Symbol.Name = "lbl_SOKM_Symbol";
            lbl_SOKM_Symbol.Size = new Size(105, 45);
            lbl_SOKM_Symbol.Style = MetroFramework.MetroColorStyle.Blue;
            lbl_SOKM_Symbol.StyleManager = null;
            lbl_SOKM_Symbol.TabIndex = 46;
            lbl_SOKM_Symbol.Tag = "SOKM";
            lbl_SOKM_Symbol.Text = "SOKM";
            lbl_SOKM_Symbol.TextAlign = ContentAlignment.MiddleLeft;
            lbl_SOKM_Symbol.Theme = MetroFramework.MetroThemeStyle.Light;
            lbl_SOKM_Symbol.UseStyleColors = false;
            lbl_SOKM_Symbol.Click += lbl_Click;
            lbl_SOKM_Symbol.DoubleClick += PriceLabel_DoubleClick;
            // 
            // lbl_SISE_Price
            // 
            lbl_SISE_Price.AutoSize = true;
            lbl_SISE_Price.Cursor = Cursors.Hand;
            lbl_SISE_Price.CustomBackground = false;
            lbl_SISE_Price.Dock = DockStyle.Fill;
            lbl_SISE_Price.FontSize = MetroFramework.MetroLabelSize.Medium;
            lbl_SISE_Price.FontWeight = MetroFramework.MetroLabelWeight.Light;
            lbl_SISE_Price.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            lbl_SISE_Price.Location = new Point(116, 507);
            lbl_SISE_Price.Name = "lbl_SISE_Price";
            lbl_SISE_Price.Size = new Size(161, 45);
            lbl_SISE_Price.Style = MetroFramework.MetroColorStyle.Blue;
            lbl_SISE_Price.StyleManager = null;
            lbl_SISE_Price.TabIndex = 45;
            lbl_SISE_Price.Tag = "SISE";
            lbl_SISE_Price.Text = "-";
            lbl_SISE_Price.TextAlign = ContentAlignment.MiddleRight;
            lbl_SISE_Price.Theme = MetroFramework.MetroThemeStyle.Light;
            lbl_SISE_Price.UseStyleColors = false;
            lbl_SISE_Price.Click += lbl_Click;
            lbl_SISE_Price.DoubleClick += PriceLabel_DoubleClick;
            // 
            // lbl_SISE_Symbol
            // 
            lbl_SISE_Symbol.AutoSize = true;
            lbl_SISE_Symbol.Cursor = Cursors.Hand;
            lbl_SISE_Symbol.CustomBackground = false;
            lbl_SISE_Symbol.Dock = DockStyle.Fill;
            lbl_SISE_Symbol.FontSize = MetroFramework.MetroLabelSize.Medium;
            lbl_SISE_Symbol.FontWeight = MetroFramework.MetroLabelWeight.Light;
            lbl_SISE_Symbol.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            lbl_SISE_Symbol.Location = new Point(4, 507);
            lbl_SISE_Symbol.Name = "lbl_SISE_Symbol";
            lbl_SISE_Symbol.Size = new Size(105, 45);
            lbl_SISE_Symbol.Style = MetroFramework.MetroColorStyle.Blue;
            lbl_SISE_Symbol.StyleManager = null;
            lbl_SISE_Symbol.TabIndex = 44;
            lbl_SISE_Symbol.Tag = "SISE";
            lbl_SISE_Symbol.Text = "SISE";
            lbl_SISE_Symbol.TextAlign = ContentAlignment.MiddleLeft;
            lbl_SISE_Symbol.Theme = MetroFramework.MetroThemeStyle.Light;
            lbl_SISE_Symbol.UseStyleColors = false;
            lbl_SISE_Symbol.Click += lbl_Click;
            lbl_SISE_Symbol.DoubleClick += PriceLabel_DoubleClick;
            // 
            // lbl_SASA_Price
            // 
            lbl_SASA_Price.AutoSize = true;
            lbl_SASA_Price.Cursor = Cursors.Hand;
            lbl_SASA_Price.CustomBackground = false;
            lbl_SASA_Price.Dock = DockStyle.Fill;
            lbl_SASA_Price.FontSize = MetroFramework.MetroLabelSize.Medium;
            lbl_SASA_Price.FontWeight = MetroFramework.MetroLabelWeight.Light;
            lbl_SASA_Price.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            lbl_SASA_Price.Location = new Point(396, 461);
            lbl_SASA_Price.Name = "lbl_SASA_Price";
            lbl_SASA_Price.Size = new Size(162, 45);
            lbl_SASA_Price.Style = MetroFramework.MetroColorStyle.Blue;
            lbl_SASA_Price.StyleManager = null;
            lbl_SASA_Price.TabIndex = 43;
            lbl_SASA_Price.Tag = "SASA";
            lbl_SASA_Price.Text = "-";
            lbl_SASA_Price.TextAlign = ContentAlignment.MiddleRight;
            lbl_SASA_Price.Theme = MetroFramework.MetroThemeStyle.Light;
            lbl_SASA_Price.UseStyleColors = false;
            lbl_SASA_Price.Click += lbl_Click;
            lbl_SASA_Price.DoubleClick += PriceLabel_DoubleClick;
            // 
            // lbl_SASA_Symbol
            // 
            lbl_SASA_Symbol.AutoSize = true;
            lbl_SASA_Symbol.Cursor = Cursors.Hand;
            lbl_SASA_Symbol.CustomBackground = false;
            lbl_SASA_Symbol.Dock = DockStyle.Fill;
            lbl_SASA_Symbol.FontSize = MetroFramework.MetroLabelSize.Medium;
            lbl_SASA_Symbol.FontWeight = MetroFramework.MetroLabelWeight.Light;
            lbl_SASA_Symbol.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            lbl_SASA_Symbol.Location = new Point(284, 461);
            lbl_SASA_Symbol.Name = "lbl_SASA_Symbol";
            lbl_SASA_Symbol.Size = new Size(105, 45);
            lbl_SASA_Symbol.Style = MetroFramework.MetroColorStyle.Blue;
            lbl_SASA_Symbol.StyleManager = null;
            lbl_SASA_Symbol.TabIndex = 42;
            lbl_SASA_Symbol.Tag = "SASA";
            lbl_SASA_Symbol.Text = "SASA";
            lbl_SASA_Symbol.TextAlign = ContentAlignment.MiddleLeft;
            lbl_SASA_Symbol.Theme = MetroFramework.MetroThemeStyle.Light;
            lbl_SASA_Symbol.UseStyleColors = false;
            lbl_SASA_Symbol.Click += lbl_Click;
            lbl_SASA_Symbol.DoubleClick += PriceLabel_DoubleClick;
            // 
            // lbl_SAHOL_Price
            // 
            lbl_SAHOL_Price.AutoSize = true;
            lbl_SAHOL_Price.Cursor = Cursors.Hand;
            lbl_SAHOL_Price.CustomBackground = false;
            lbl_SAHOL_Price.Dock = DockStyle.Fill;
            lbl_SAHOL_Price.FontSize = MetroFramework.MetroLabelSize.Medium;
            lbl_SAHOL_Price.FontWeight = MetroFramework.MetroLabelWeight.Light;
            lbl_SAHOL_Price.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            lbl_SAHOL_Price.Location = new Point(116, 461);
            lbl_SAHOL_Price.Name = "lbl_SAHOL_Price";
            lbl_SAHOL_Price.Size = new Size(161, 45);
            lbl_SAHOL_Price.Style = MetroFramework.MetroColorStyle.Blue;
            lbl_SAHOL_Price.StyleManager = null;
            lbl_SAHOL_Price.TabIndex = 41;
            lbl_SAHOL_Price.Tag = "SAHOL";
            lbl_SAHOL_Price.Text = "-";
            lbl_SAHOL_Price.TextAlign = ContentAlignment.MiddleRight;
            lbl_SAHOL_Price.Theme = MetroFramework.MetroThemeStyle.Light;
            lbl_SAHOL_Price.UseStyleColors = false;
            lbl_SAHOL_Price.Click += lbl_Click;
            lbl_SAHOL_Price.DoubleClick += PriceLabel_DoubleClick;
            // 
            // lbl_SAHOL_Symbol
            // 
            lbl_SAHOL_Symbol.AutoSize = true;
            lbl_SAHOL_Symbol.Cursor = Cursors.Hand;
            lbl_SAHOL_Symbol.CustomBackground = false;
            lbl_SAHOL_Symbol.Dock = DockStyle.Fill;
            lbl_SAHOL_Symbol.FontSize = MetroFramework.MetroLabelSize.Medium;
            lbl_SAHOL_Symbol.FontWeight = MetroFramework.MetroLabelWeight.Light;
            lbl_SAHOL_Symbol.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            lbl_SAHOL_Symbol.Location = new Point(4, 461);
            lbl_SAHOL_Symbol.Name = "lbl_SAHOL_Symbol";
            lbl_SAHOL_Symbol.Size = new Size(105, 45);
            lbl_SAHOL_Symbol.Style = MetroFramework.MetroColorStyle.Blue;
            lbl_SAHOL_Symbol.StyleManager = null;
            lbl_SAHOL_Symbol.TabIndex = 40;
            lbl_SAHOL_Symbol.Tag = "SAHOL";
            lbl_SAHOL_Symbol.Text = "SAHOL";
            lbl_SAHOL_Symbol.TextAlign = ContentAlignment.MiddleLeft;
            lbl_SAHOL_Symbol.Theme = MetroFramework.MetroThemeStyle.Light;
            lbl_SAHOL_Symbol.UseStyleColors = false;
            lbl_SAHOL_Symbol.Click += lbl_Click;
            lbl_SAHOL_Symbol.DoubleClick += PriceLabel_DoubleClick;
            // 
            // lbl_PGSUS_Price
            // 
            lbl_PGSUS_Price.AutoSize = true;
            lbl_PGSUS_Price.Cursor = Cursors.Hand;
            lbl_PGSUS_Price.CustomBackground = false;
            lbl_PGSUS_Price.Dock = DockStyle.Fill;
            lbl_PGSUS_Price.FontSize = MetroFramework.MetroLabelSize.Medium;
            lbl_PGSUS_Price.FontWeight = MetroFramework.MetroLabelWeight.Light;
            lbl_PGSUS_Price.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            lbl_PGSUS_Price.Location = new Point(396, 415);
            lbl_PGSUS_Price.Name = "lbl_PGSUS_Price";
            lbl_PGSUS_Price.Size = new Size(162, 45);
            lbl_PGSUS_Price.Style = MetroFramework.MetroColorStyle.Blue;
            lbl_PGSUS_Price.StyleManager = null;
            lbl_PGSUS_Price.TabIndex = 39;
            lbl_PGSUS_Price.Tag = "PGSUS";
            lbl_PGSUS_Price.Text = "-";
            lbl_PGSUS_Price.TextAlign = ContentAlignment.MiddleRight;
            lbl_PGSUS_Price.Theme = MetroFramework.MetroThemeStyle.Light;
            lbl_PGSUS_Price.UseStyleColors = false;
            lbl_PGSUS_Price.Click += lbl_Click;
            lbl_PGSUS_Price.DoubleClick += PriceLabel_DoubleClick;
            // 
            // lbl_PGSUS_Symbol
            // 
            lbl_PGSUS_Symbol.AutoSize = true;
            lbl_PGSUS_Symbol.Cursor = Cursors.Hand;
            lbl_PGSUS_Symbol.CustomBackground = false;
            lbl_PGSUS_Symbol.Dock = DockStyle.Fill;
            lbl_PGSUS_Symbol.FontSize = MetroFramework.MetroLabelSize.Medium;
            lbl_PGSUS_Symbol.FontWeight = MetroFramework.MetroLabelWeight.Light;
            lbl_PGSUS_Symbol.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            lbl_PGSUS_Symbol.Location = new Point(284, 415);
            lbl_PGSUS_Symbol.Name = "lbl_PGSUS_Symbol";
            lbl_PGSUS_Symbol.Size = new Size(105, 45);
            lbl_PGSUS_Symbol.Style = MetroFramework.MetroColorStyle.Blue;
            lbl_PGSUS_Symbol.StyleManager = null;
            lbl_PGSUS_Symbol.TabIndex = 38;
            lbl_PGSUS_Symbol.Tag = "PGSUS";
            lbl_PGSUS_Symbol.Text = "PGSUS";
            lbl_PGSUS_Symbol.TextAlign = ContentAlignment.MiddleLeft;
            lbl_PGSUS_Symbol.Theme = MetroFramework.MetroThemeStyle.Light;
            lbl_PGSUS_Symbol.UseStyleColors = false;
            lbl_PGSUS_Symbol.Click += lbl_Click;
            lbl_PGSUS_Symbol.DoubleClick += PriceLabel_DoubleClick;
            // 
            // lbl_PETKM_Price
            // 
            lbl_PETKM_Price.AutoSize = true;
            lbl_PETKM_Price.Cursor = Cursors.Hand;
            lbl_PETKM_Price.CustomBackground = false;
            lbl_PETKM_Price.Dock = DockStyle.Fill;
            lbl_PETKM_Price.FontSize = MetroFramework.MetroLabelSize.Medium;
            lbl_PETKM_Price.FontWeight = MetroFramework.MetroLabelWeight.Light;
            lbl_PETKM_Price.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            lbl_PETKM_Price.Location = new Point(116, 415);
            lbl_PETKM_Price.Name = "lbl_PETKM_Price";
            lbl_PETKM_Price.Size = new Size(161, 45);
            lbl_PETKM_Price.Style = MetroFramework.MetroColorStyle.Blue;
            lbl_PETKM_Price.StyleManager = null;
            lbl_PETKM_Price.TabIndex = 37;
            lbl_PETKM_Price.Tag = "PETKM";
            lbl_PETKM_Price.Text = "-";
            lbl_PETKM_Price.TextAlign = ContentAlignment.MiddleRight;
            lbl_PETKM_Price.Theme = MetroFramework.MetroThemeStyle.Light;
            lbl_PETKM_Price.UseStyleColors = false;
            lbl_PETKM_Price.Click += lbl_Click;
            lbl_PETKM_Price.DoubleClick += PriceLabel_DoubleClick;
            // 
            // lbl_PETKM_Symbol
            // 
            lbl_PETKM_Symbol.AutoSize = true;
            lbl_PETKM_Symbol.Cursor = Cursors.Hand;
            lbl_PETKM_Symbol.CustomBackground = false;
            lbl_PETKM_Symbol.Dock = DockStyle.Fill;
            lbl_PETKM_Symbol.FontSize = MetroFramework.MetroLabelSize.Medium;
            lbl_PETKM_Symbol.FontWeight = MetroFramework.MetroLabelWeight.Light;
            lbl_PETKM_Symbol.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            lbl_PETKM_Symbol.Location = new Point(4, 415);
            lbl_PETKM_Symbol.Name = "lbl_PETKM_Symbol";
            lbl_PETKM_Symbol.Size = new Size(105, 45);
            lbl_PETKM_Symbol.Style = MetroFramework.MetroColorStyle.Blue;
            lbl_PETKM_Symbol.StyleManager = null;
            lbl_PETKM_Symbol.TabIndex = 36;
            lbl_PETKM_Symbol.Tag = "PETKM";
            lbl_PETKM_Symbol.Text = "PETKM";
            lbl_PETKM_Symbol.TextAlign = ContentAlignment.MiddleLeft;
            lbl_PETKM_Symbol.Theme = MetroFramework.MetroThemeStyle.Light;
            lbl_PETKM_Symbol.UseStyleColors = false;
            lbl_PETKM_Symbol.Click += lbl_Click;
            lbl_PETKM_Symbol.DoubleClick += PriceLabel_DoubleClick;
            // 
            // lbl_KRDMD_Price
            // 
            lbl_KRDMD_Price.AutoSize = true;
            lbl_KRDMD_Price.Cursor = Cursors.Hand;
            lbl_KRDMD_Price.CustomBackground = false;
            lbl_KRDMD_Price.Dock = DockStyle.Fill;
            lbl_KRDMD_Price.FontSize = MetroFramework.MetroLabelSize.Medium;
            lbl_KRDMD_Price.FontWeight = MetroFramework.MetroLabelWeight.Light;
            lbl_KRDMD_Price.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            lbl_KRDMD_Price.Location = new Point(396, 369);
            lbl_KRDMD_Price.Name = "lbl_KRDMD_Price";
            lbl_KRDMD_Price.Size = new Size(162, 45);
            lbl_KRDMD_Price.Style = MetroFramework.MetroColorStyle.Blue;
            lbl_KRDMD_Price.StyleManager = null;
            lbl_KRDMD_Price.TabIndex = 35;
            lbl_KRDMD_Price.Tag = "KRDMD";
            lbl_KRDMD_Price.Text = "-";
            lbl_KRDMD_Price.TextAlign = ContentAlignment.MiddleRight;
            lbl_KRDMD_Price.Theme = MetroFramework.MetroThemeStyle.Light;
            lbl_KRDMD_Price.UseStyleColors = false;
            lbl_KRDMD_Price.Click += lbl_Click;
            lbl_KRDMD_Price.DoubleClick += PriceLabel_DoubleClick;
            // 
            // lbl_KRDMD_Symbol
            // 
            lbl_KRDMD_Symbol.AutoSize = true;
            lbl_KRDMD_Symbol.Cursor = Cursors.Hand;
            lbl_KRDMD_Symbol.CustomBackground = false;
            lbl_KRDMD_Symbol.Dock = DockStyle.Fill;
            lbl_KRDMD_Symbol.FontSize = MetroFramework.MetroLabelSize.Medium;
            lbl_KRDMD_Symbol.FontWeight = MetroFramework.MetroLabelWeight.Light;
            lbl_KRDMD_Symbol.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            lbl_KRDMD_Symbol.Location = new Point(284, 369);
            lbl_KRDMD_Symbol.Name = "lbl_KRDMD_Symbol";
            lbl_KRDMD_Symbol.Size = new Size(105, 45);
            lbl_KRDMD_Symbol.Style = MetroFramework.MetroColorStyle.Blue;
            lbl_KRDMD_Symbol.StyleManager = null;
            lbl_KRDMD_Symbol.TabIndex = 34;
            lbl_KRDMD_Symbol.Tag = "KRDMD";
            lbl_KRDMD_Symbol.Text = "KRDMD";
            lbl_KRDMD_Symbol.TextAlign = ContentAlignment.MiddleLeft;
            lbl_KRDMD_Symbol.Theme = MetroFramework.MetroThemeStyle.Light;
            lbl_KRDMD_Symbol.UseStyleColors = false;
            lbl_KRDMD_Symbol.Click += lbl_Click;
            lbl_KRDMD_Symbol.DoubleClick += PriceLabel_DoubleClick;
            // 
            // lbl_KOZAL_Price
            // 
            lbl_KOZAL_Price.AutoSize = true;
            lbl_KOZAL_Price.Cursor = Cursors.Hand;
            lbl_KOZAL_Price.CustomBackground = false;
            lbl_KOZAL_Price.Dock = DockStyle.Fill;
            lbl_KOZAL_Price.FontSize = MetroFramework.MetroLabelSize.Medium;
            lbl_KOZAL_Price.FontWeight = MetroFramework.MetroLabelWeight.Light;
            lbl_KOZAL_Price.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            lbl_KOZAL_Price.Location = new Point(116, 369);
            lbl_KOZAL_Price.Name = "lbl_KOZAL_Price";
            lbl_KOZAL_Price.Size = new Size(161, 45);
            lbl_KOZAL_Price.Style = MetroFramework.MetroColorStyle.Blue;
            lbl_KOZAL_Price.StyleManager = null;
            lbl_KOZAL_Price.TabIndex = 33;
            lbl_KOZAL_Price.Tag = "KOZAL";
            lbl_KOZAL_Price.Text = "-";
            lbl_KOZAL_Price.TextAlign = ContentAlignment.MiddleRight;
            lbl_KOZAL_Price.Theme = MetroFramework.MetroThemeStyle.Light;
            lbl_KOZAL_Price.UseStyleColors = false;
            lbl_KOZAL_Price.Click += lbl_Click;
            lbl_KOZAL_Price.DoubleClick += PriceLabel_DoubleClick;
            // 
            // lbl_KOZAL_Symbol
            // 
            lbl_KOZAL_Symbol.AutoSize = true;
            lbl_KOZAL_Symbol.Cursor = Cursors.Hand;
            lbl_KOZAL_Symbol.CustomBackground = false;
            lbl_KOZAL_Symbol.Dock = DockStyle.Fill;
            lbl_KOZAL_Symbol.FontSize = MetroFramework.MetroLabelSize.Medium;
            lbl_KOZAL_Symbol.FontWeight = MetroFramework.MetroLabelWeight.Light;
            lbl_KOZAL_Symbol.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            lbl_KOZAL_Symbol.Location = new Point(4, 369);
            lbl_KOZAL_Symbol.Name = "lbl_KOZAL_Symbol";
            lbl_KOZAL_Symbol.Size = new Size(105, 45);
            lbl_KOZAL_Symbol.Style = MetroFramework.MetroColorStyle.Blue;
            lbl_KOZAL_Symbol.StyleManager = null;
            lbl_KOZAL_Symbol.TabIndex = 32;
            lbl_KOZAL_Symbol.Tag = "KOZAL";
            lbl_KOZAL_Symbol.Text = "KOZAL";
            lbl_KOZAL_Symbol.TextAlign = ContentAlignment.MiddleLeft;
            lbl_KOZAL_Symbol.Theme = MetroFramework.MetroThemeStyle.Light;
            lbl_KOZAL_Symbol.UseStyleColors = false;
            lbl_KOZAL_Symbol.Click += lbl_Click;
            lbl_KOZAL_Symbol.DoubleClick += PriceLabel_DoubleClick;
            // 
            // lbl_KOZAA_Price
            // 
            lbl_KOZAA_Price.AutoSize = true;
            lbl_KOZAA_Price.Cursor = Cursors.Hand;
            lbl_KOZAA_Price.CustomBackground = false;
            lbl_KOZAA_Price.Dock = DockStyle.Fill;
            lbl_KOZAA_Price.FontSize = MetroFramework.MetroLabelSize.Medium;
            lbl_KOZAA_Price.FontWeight = MetroFramework.MetroLabelWeight.Light;
            lbl_KOZAA_Price.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            lbl_KOZAA_Price.Location = new Point(396, 323);
            lbl_KOZAA_Price.Name = "lbl_KOZAA_Price";
            lbl_KOZAA_Price.Size = new Size(162, 45);
            lbl_KOZAA_Price.Style = MetroFramework.MetroColorStyle.Blue;
            lbl_KOZAA_Price.StyleManager = null;
            lbl_KOZAA_Price.TabIndex = 31;
            lbl_KOZAA_Price.Tag = "KOZAA";
            lbl_KOZAA_Price.Text = "-";
            lbl_KOZAA_Price.TextAlign = ContentAlignment.MiddleRight;
            lbl_KOZAA_Price.Theme = MetroFramework.MetroThemeStyle.Light;
            lbl_KOZAA_Price.UseStyleColors = false;
            lbl_KOZAA_Price.Click += lbl_Click;
            lbl_KOZAA_Price.DoubleClick += PriceLabel_DoubleClick;
            // 
            // lbl_KOZAA_Symbol
            // 
            lbl_KOZAA_Symbol.AutoSize = true;
            lbl_KOZAA_Symbol.Cursor = Cursors.Hand;
            lbl_KOZAA_Symbol.CustomBackground = false;
            lbl_KOZAA_Symbol.Dock = DockStyle.Fill;
            lbl_KOZAA_Symbol.FontSize = MetroFramework.MetroLabelSize.Medium;
            lbl_KOZAA_Symbol.FontWeight = MetroFramework.MetroLabelWeight.Light;
            lbl_KOZAA_Symbol.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            lbl_KOZAA_Symbol.Location = new Point(284, 323);
            lbl_KOZAA_Symbol.Name = "lbl_KOZAA_Symbol";
            lbl_KOZAA_Symbol.Size = new Size(105, 45);
            lbl_KOZAA_Symbol.Style = MetroFramework.MetroColorStyle.Blue;
            lbl_KOZAA_Symbol.StyleManager = null;
            lbl_KOZAA_Symbol.TabIndex = 30;
            lbl_KOZAA_Symbol.Tag = "KOZAA";
            lbl_KOZAA_Symbol.Text = "KOZAA";
            lbl_KOZAA_Symbol.TextAlign = ContentAlignment.MiddleLeft;
            lbl_KOZAA_Symbol.Theme = MetroFramework.MetroThemeStyle.Light;
            lbl_KOZAA_Symbol.UseStyleColors = false;
            lbl_KOZAA_Symbol.Click += lbl_Click;
            lbl_KOZAA_Symbol.DoubleClick += PriceLabel_DoubleClick;
            // 
            // lbl_KCHOL_Price
            // 
            lbl_KCHOL_Price.AutoSize = true;
            lbl_KCHOL_Price.Cursor = Cursors.Hand;
            lbl_KCHOL_Price.CustomBackground = false;
            lbl_KCHOL_Price.Dock = DockStyle.Fill;
            lbl_KCHOL_Price.FontSize = MetroFramework.MetroLabelSize.Medium;
            lbl_KCHOL_Price.FontWeight = MetroFramework.MetroLabelWeight.Light;
            lbl_KCHOL_Price.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            lbl_KCHOL_Price.Location = new Point(116, 323);
            lbl_KCHOL_Price.Name = "lbl_KCHOL_Price";
            lbl_KCHOL_Price.Size = new Size(161, 45);
            lbl_KCHOL_Price.Style = MetroFramework.MetroColorStyle.Blue;
            lbl_KCHOL_Price.StyleManager = null;
            lbl_KCHOL_Price.TabIndex = 29;
            lbl_KCHOL_Price.Tag = "KCHOL";
            lbl_KCHOL_Price.Text = "-";
            lbl_KCHOL_Price.TextAlign = ContentAlignment.MiddleRight;
            lbl_KCHOL_Price.Theme = MetroFramework.MetroThemeStyle.Light;
            lbl_KCHOL_Price.UseStyleColors = false;
            lbl_KCHOL_Price.Click += lbl_Click;
            lbl_KCHOL_Price.DoubleClick += PriceLabel_DoubleClick;
            // 
            // lbl_KCHOL_Symbol
            // 
            lbl_KCHOL_Symbol.AutoSize = true;
            lbl_KCHOL_Symbol.Cursor = Cursors.Hand;
            lbl_KCHOL_Symbol.CustomBackground = false;
            lbl_KCHOL_Symbol.Dock = DockStyle.Fill;
            lbl_KCHOL_Symbol.FontSize = MetroFramework.MetroLabelSize.Medium;
            lbl_KCHOL_Symbol.FontWeight = MetroFramework.MetroLabelWeight.Light;
            lbl_KCHOL_Symbol.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            lbl_KCHOL_Symbol.Location = new Point(4, 323);
            lbl_KCHOL_Symbol.Name = "lbl_KCHOL_Symbol";
            lbl_KCHOL_Symbol.Size = new Size(105, 45);
            lbl_KCHOL_Symbol.Style = MetroFramework.MetroColorStyle.Blue;
            lbl_KCHOL_Symbol.StyleManager = null;
            lbl_KCHOL_Symbol.TabIndex = 28;
            lbl_KCHOL_Symbol.Tag = "KCHOL";
            lbl_KCHOL_Symbol.Text = "KCHOL";
            lbl_KCHOL_Symbol.TextAlign = ContentAlignment.MiddleLeft;
            lbl_KCHOL_Symbol.Theme = MetroFramework.MetroThemeStyle.Light;
            lbl_KCHOL_Symbol.UseStyleColors = false;
            lbl_KCHOL_Symbol.Click += lbl_Click;
            lbl_KCHOL_Symbol.DoubleClick += PriceLabel_DoubleClick;
            // 
            // lbl_ISCTR_Price
            // 
            lbl_ISCTR_Price.AutoSize = true;
            lbl_ISCTR_Price.Cursor = Cursors.Hand;
            lbl_ISCTR_Price.CustomBackground = false;
            lbl_ISCTR_Price.Dock = DockStyle.Fill;
            lbl_ISCTR_Price.FontSize = MetroFramework.MetroLabelSize.Medium;
            lbl_ISCTR_Price.FontWeight = MetroFramework.MetroLabelWeight.Light;
            lbl_ISCTR_Price.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            lbl_ISCTR_Price.Location = new Point(396, 277);
            lbl_ISCTR_Price.Name = "lbl_ISCTR_Price";
            lbl_ISCTR_Price.Size = new Size(162, 45);
            lbl_ISCTR_Price.Style = MetroFramework.MetroColorStyle.Blue;
            lbl_ISCTR_Price.StyleManager = null;
            lbl_ISCTR_Price.TabIndex = 27;
            lbl_ISCTR_Price.Tag = "ISCTR";
            lbl_ISCTR_Price.Text = "-";
            lbl_ISCTR_Price.TextAlign = ContentAlignment.MiddleRight;
            lbl_ISCTR_Price.Theme = MetroFramework.MetroThemeStyle.Light;
            lbl_ISCTR_Price.UseStyleColors = false;
            lbl_ISCTR_Price.Click += lbl_Click;
            lbl_ISCTR_Price.DoubleClick += PriceLabel_DoubleClick;
            // 
            // lbl_ISCTR_Symbol
            // 
            lbl_ISCTR_Symbol.AutoSize = true;
            lbl_ISCTR_Symbol.Cursor = Cursors.Hand;
            lbl_ISCTR_Symbol.CustomBackground = false;
            lbl_ISCTR_Symbol.Dock = DockStyle.Fill;
            lbl_ISCTR_Symbol.FontSize = MetroFramework.MetroLabelSize.Medium;
            lbl_ISCTR_Symbol.FontWeight = MetroFramework.MetroLabelWeight.Light;
            lbl_ISCTR_Symbol.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            lbl_ISCTR_Symbol.Location = new Point(284, 277);
            lbl_ISCTR_Symbol.Name = "lbl_ISCTR_Symbol";
            lbl_ISCTR_Symbol.Size = new Size(105, 45);
            lbl_ISCTR_Symbol.Style = MetroFramework.MetroColorStyle.Blue;
            lbl_ISCTR_Symbol.StyleManager = null;
            lbl_ISCTR_Symbol.TabIndex = 26;
            lbl_ISCTR_Symbol.Tag = "ISCTR";
            lbl_ISCTR_Symbol.Text = "ISCTR";
            lbl_ISCTR_Symbol.TextAlign = ContentAlignment.MiddleLeft;
            lbl_ISCTR_Symbol.Theme = MetroFramework.MetroThemeStyle.Light;
            lbl_ISCTR_Symbol.UseStyleColors = false;
            lbl_ISCTR_Symbol.Click += lbl_Click;
            lbl_ISCTR_Symbol.DoubleClick += PriceLabel_DoubleClick;
            // 
            // lbl_HEKTS_Price
            // 
            lbl_HEKTS_Price.AutoSize = true;
            lbl_HEKTS_Price.Cursor = Cursors.Hand;
            lbl_HEKTS_Price.CustomBackground = false;
            lbl_HEKTS_Price.Dock = DockStyle.Fill;
            lbl_HEKTS_Price.FontSize = MetroFramework.MetroLabelSize.Medium;
            lbl_HEKTS_Price.FontWeight = MetroFramework.MetroLabelWeight.Light;
            lbl_HEKTS_Price.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            lbl_HEKTS_Price.Location = new Point(116, 277);
            lbl_HEKTS_Price.Name = "lbl_HEKTS_Price";
            lbl_HEKTS_Price.Size = new Size(161, 45);
            lbl_HEKTS_Price.Style = MetroFramework.MetroColorStyle.Blue;
            lbl_HEKTS_Price.StyleManager = null;
            lbl_HEKTS_Price.TabIndex = 25;
            lbl_HEKTS_Price.Tag = "HEKTS";
            lbl_HEKTS_Price.Text = "-";
            lbl_HEKTS_Price.TextAlign = ContentAlignment.MiddleRight;
            lbl_HEKTS_Price.Theme = MetroFramework.MetroThemeStyle.Light;
            lbl_HEKTS_Price.UseStyleColors = false;
            lbl_HEKTS_Price.Click += lbl_Click;
            lbl_HEKTS_Price.DoubleClick += PriceLabel_DoubleClick;
            // 
            // lbl_HEKTS_Symbol
            // 
            lbl_HEKTS_Symbol.AutoSize = true;
            lbl_HEKTS_Symbol.Cursor = Cursors.Hand;
            lbl_HEKTS_Symbol.CustomBackground = false;
            lbl_HEKTS_Symbol.Dock = DockStyle.Fill;
            lbl_HEKTS_Symbol.FontSize = MetroFramework.MetroLabelSize.Medium;
            lbl_HEKTS_Symbol.FontWeight = MetroFramework.MetroLabelWeight.Light;
            lbl_HEKTS_Symbol.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            lbl_HEKTS_Symbol.Location = new Point(4, 277);
            lbl_HEKTS_Symbol.Name = "lbl_HEKTS_Symbol";
            lbl_HEKTS_Symbol.Size = new Size(105, 45);
            lbl_HEKTS_Symbol.Style = MetroFramework.MetroColorStyle.Blue;
            lbl_HEKTS_Symbol.StyleManager = null;
            lbl_HEKTS_Symbol.TabIndex = 24;
            lbl_HEKTS_Symbol.Tag = "HEKTS";
            lbl_HEKTS_Symbol.Text = "HEKTS";
            lbl_HEKTS_Symbol.TextAlign = ContentAlignment.MiddleLeft;
            lbl_HEKTS_Symbol.Theme = MetroFramework.MetroThemeStyle.Light;
            lbl_HEKTS_Symbol.UseStyleColors = false;
            lbl_HEKTS_Symbol.Click += lbl_Click;
            lbl_HEKTS_Symbol.DoubleClick += PriceLabel_DoubleClick;
            // 
            // lbl_GUBRF_Price
            // 
            lbl_GUBRF_Price.AutoSize = true;
            lbl_GUBRF_Price.Cursor = Cursors.Hand;
            lbl_GUBRF_Price.CustomBackground = false;
            lbl_GUBRF_Price.Dock = DockStyle.Fill;
            lbl_GUBRF_Price.FontSize = MetroFramework.MetroLabelSize.Medium;
            lbl_GUBRF_Price.FontWeight = MetroFramework.MetroLabelWeight.Light;
            lbl_GUBRF_Price.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            lbl_GUBRF_Price.Location = new Point(396, 231);
            lbl_GUBRF_Price.Name = "lbl_GUBRF_Price";
            lbl_GUBRF_Price.Size = new Size(162, 45);
            lbl_GUBRF_Price.Style = MetroFramework.MetroColorStyle.Blue;
            lbl_GUBRF_Price.StyleManager = null;
            lbl_GUBRF_Price.TabIndex = 23;
            lbl_GUBRF_Price.Tag = "GUBRF";
            lbl_GUBRF_Price.Text = "-";
            lbl_GUBRF_Price.TextAlign = ContentAlignment.MiddleRight;
            lbl_GUBRF_Price.Theme = MetroFramework.MetroThemeStyle.Light;
            lbl_GUBRF_Price.UseStyleColors = false;
            lbl_GUBRF_Price.Click += lbl_Click;
            lbl_GUBRF_Price.DoubleClick += PriceLabel_DoubleClick;
            // 
            // lbl_GUBRF_Symbol
            // 
            lbl_GUBRF_Symbol.AutoSize = true;
            lbl_GUBRF_Symbol.Cursor = Cursors.Hand;
            lbl_GUBRF_Symbol.CustomBackground = false;
            lbl_GUBRF_Symbol.Dock = DockStyle.Fill;
            lbl_GUBRF_Symbol.FontSize = MetroFramework.MetroLabelSize.Medium;
            lbl_GUBRF_Symbol.FontWeight = MetroFramework.MetroLabelWeight.Light;
            lbl_GUBRF_Symbol.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            lbl_GUBRF_Symbol.Location = new Point(284, 231);
            lbl_GUBRF_Symbol.Name = "lbl_GUBRF_Symbol";
            lbl_GUBRF_Symbol.Size = new Size(105, 45);
            lbl_GUBRF_Symbol.Style = MetroFramework.MetroColorStyle.Blue;
            lbl_GUBRF_Symbol.StyleManager = null;
            lbl_GUBRF_Symbol.TabIndex = 22;
            lbl_GUBRF_Symbol.Tag = "GUBRF";
            lbl_GUBRF_Symbol.Text = "GUBRF";
            lbl_GUBRF_Symbol.TextAlign = ContentAlignment.MiddleLeft;
            lbl_GUBRF_Symbol.Theme = MetroFramework.MetroThemeStyle.Light;
            lbl_GUBRF_Symbol.UseStyleColors = false;
            lbl_GUBRF_Symbol.Click += lbl_Click;
            lbl_GUBRF_Symbol.DoubleClick += PriceLabel_DoubleClick;
            // 
            // lbl_GARAN_Price
            // 
            lbl_GARAN_Price.AutoSize = true;
            lbl_GARAN_Price.Cursor = Cursors.Hand;
            lbl_GARAN_Price.CustomBackground = false;
            lbl_GARAN_Price.Dock = DockStyle.Fill;
            lbl_GARAN_Price.FontSize = MetroFramework.MetroLabelSize.Medium;
            lbl_GARAN_Price.FontWeight = MetroFramework.MetroLabelWeight.Light;
            lbl_GARAN_Price.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            lbl_GARAN_Price.Location = new Point(116, 231);
            lbl_GARAN_Price.Name = "lbl_GARAN_Price";
            lbl_GARAN_Price.Size = new Size(161, 45);
            lbl_GARAN_Price.Style = MetroFramework.MetroColorStyle.Blue;
            lbl_GARAN_Price.StyleManager = null;
            lbl_GARAN_Price.TabIndex = 21;
            lbl_GARAN_Price.Tag = "GARAN";
            lbl_GARAN_Price.Text = "-";
            lbl_GARAN_Price.TextAlign = ContentAlignment.MiddleRight;
            lbl_GARAN_Price.Theme = MetroFramework.MetroThemeStyle.Light;
            lbl_GARAN_Price.UseStyleColors = false;
            lbl_GARAN_Price.Click += lbl_Click;
            lbl_GARAN_Price.DoubleClick += PriceLabel_DoubleClick;
            // 
            // lbl_GARAN_Symbol
            // 
            lbl_GARAN_Symbol.AutoSize = true;
            lbl_GARAN_Symbol.Cursor = Cursors.Hand;
            lbl_GARAN_Symbol.CustomBackground = false;
            lbl_GARAN_Symbol.Dock = DockStyle.Fill;
            lbl_GARAN_Symbol.FontSize = MetroFramework.MetroLabelSize.Medium;
            lbl_GARAN_Symbol.FontWeight = MetroFramework.MetroLabelWeight.Light;
            lbl_GARAN_Symbol.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            lbl_GARAN_Symbol.Location = new Point(4, 231);
            lbl_GARAN_Symbol.Name = "lbl_GARAN_Symbol";
            lbl_GARAN_Symbol.Size = new Size(105, 45);
            lbl_GARAN_Symbol.Style = MetroFramework.MetroColorStyle.Blue;
            lbl_GARAN_Symbol.StyleManager = null;
            lbl_GARAN_Symbol.TabIndex = 20;
            lbl_GARAN_Symbol.Tag = "GARAN";
            lbl_GARAN_Symbol.Text = "GARAN";
            lbl_GARAN_Symbol.TextAlign = ContentAlignment.MiddleLeft;
            lbl_GARAN_Symbol.Theme = MetroFramework.MetroThemeStyle.Light;
            lbl_GARAN_Symbol.UseStyleColors = false;
            lbl_GARAN_Symbol.Click += lbl_Click;
            lbl_GARAN_Symbol.DoubleClick += PriceLabel_DoubleClick;
            // 
            // lbl_FROTO_Price
            // 
            lbl_FROTO_Price.AutoSize = true;
            lbl_FROTO_Price.Cursor = Cursors.Hand;
            lbl_FROTO_Price.CustomBackground = false;
            lbl_FROTO_Price.Dock = DockStyle.Fill;
            lbl_FROTO_Price.FontSize = MetroFramework.MetroLabelSize.Medium;
            lbl_FROTO_Price.FontWeight = MetroFramework.MetroLabelWeight.Light;
            lbl_FROTO_Price.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            lbl_FROTO_Price.Location = new Point(396, 185);
            lbl_FROTO_Price.Name = "lbl_FROTO_Price";
            lbl_FROTO_Price.Size = new Size(162, 45);
            lbl_FROTO_Price.Style = MetroFramework.MetroColorStyle.Blue;
            lbl_FROTO_Price.StyleManager = null;
            lbl_FROTO_Price.TabIndex = 19;
            lbl_FROTO_Price.Tag = "FROTO";
            lbl_FROTO_Price.Text = "-";
            lbl_FROTO_Price.TextAlign = ContentAlignment.MiddleRight;
            lbl_FROTO_Price.Theme = MetroFramework.MetroThemeStyle.Light;
            lbl_FROTO_Price.UseStyleColors = false;
            lbl_FROTO_Price.Click += lbl_Click;
            lbl_FROTO_Price.DoubleClick += PriceLabel_DoubleClick;
            // 
            // lbl_FROTO_Symbol
            // 
            lbl_FROTO_Symbol.AutoSize = true;
            lbl_FROTO_Symbol.Cursor = Cursors.Hand;
            lbl_FROTO_Symbol.CustomBackground = false;
            lbl_FROTO_Symbol.Dock = DockStyle.Fill;
            lbl_FROTO_Symbol.FontSize = MetroFramework.MetroLabelSize.Medium;
            lbl_FROTO_Symbol.FontWeight = MetroFramework.MetroLabelWeight.Light;
            lbl_FROTO_Symbol.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            lbl_FROTO_Symbol.Location = new Point(284, 185);
            lbl_FROTO_Symbol.Name = "lbl_FROTO_Symbol";
            lbl_FROTO_Symbol.Size = new Size(105, 45);
            lbl_FROTO_Symbol.Style = MetroFramework.MetroColorStyle.Blue;
            lbl_FROTO_Symbol.StyleManager = null;
            lbl_FROTO_Symbol.TabIndex = 18;
            lbl_FROTO_Symbol.Tag = "FROTO";
            lbl_FROTO_Symbol.Text = "FROTO";
            lbl_FROTO_Symbol.TextAlign = ContentAlignment.MiddleLeft;
            lbl_FROTO_Symbol.Theme = MetroFramework.MetroThemeStyle.Light;
            lbl_FROTO_Symbol.UseStyleColors = false;
            lbl_FROTO_Symbol.Click += lbl_Click;
            lbl_FROTO_Symbol.DoubleClick += PriceLabel_DoubleClick;
            // 
            // lbl_EREGL_Price
            // 
            lbl_EREGL_Price.AutoSize = true;
            lbl_EREGL_Price.Cursor = Cursors.Hand;
            lbl_EREGL_Price.CustomBackground = false;
            lbl_EREGL_Price.Dock = DockStyle.Fill;
            lbl_EREGL_Price.FontSize = MetroFramework.MetroLabelSize.Medium;
            lbl_EREGL_Price.FontWeight = MetroFramework.MetroLabelWeight.Light;
            lbl_EREGL_Price.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            lbl_EREGL_Price.Location = new Point(116, 185);
            lbl_EREGL_Price.Name = "lbl_EREGL_Price";
            lbl_EREGL_Price.Size = new Size(161, 45);
            lbl_EREGL_Price.Style = MetroFramework.MetroColorStyle.Blue;
            lbl_EREGL_Price.StyleManager = null;
            lbl_EREGL_Price.TabIndex = 17;
            lbl_EREGL_Price.Tag = "EREGL";
            lbl_EREGL_Price.Text = "-";
            lbl_EREGL_Price.TextAlign = ContentAlignment.MiddleRight;
            lbl_EREGL_Price.Theme = MetroFramework.MetroThemeStyle.Light;
            lbl_EREGL_Price.UseStyleColors = false;
            lbl_EREGL_Price.Click += lbl_Click;
            lbl_EREGL_Price.DoubleClick += PriceLabel_DoubleClick;
            // 
            // lbl_EREGL_Symbol
            // 
            lbl_EREGL_Symbol.AutoSize = true;
            lbl_EREGL_Symbol.Cursor = Cursors.Hand;
            lbl_EREGL_Symbol.CustomBackground = false;
            lbl_EREGL_Symbol.Dock = DockStyle.Fill;
            lbl_EREGL_Symbol.FontSize = MetroFramework.MetroLabelSize.Medium;
            lbl_EREGL_Symbol.FontWeight = MetroFramework.MetroLabelWeight.Light;
            lbl_EREGL_Symbol.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            lbl_EREGL_Symbol.Location = new Point(4, 185);
            lbl_EREGL_Symbol.Name = "lbl_EREGL_Symbol";
            lbl_EREGL_Symbol.Size = new Size(105, 45);
            lbl_EREGL_Symbol.Style = MetroFramework.MetroColorStyle.Blue;
            lbl_EREGL_Symbol.StyleManager = null;
            lbl_EREGL_Symbol.TabIndex = 16;
            lbl_EREGL_Symbol.Tag = "EREGL";
            lbl_EREGL_Symbol.Text = "EREGL";
            lbl_EREGL_Symbol.TextAlign = ContentAlignment.MiddleLeft;
            lbl_EREGL_Symbol.Theme = MetroFramework.MetroThemeStyle.Light;
            lbl_EREGL_Symbol.UseStyleColors = false;
            lbl_EREGL_Symbol.Click += lbl_Click;
            lbl_EREGL_Symbol.DoubleClick += PriceLabel_DoubleClick;
            // 
            // lbl_ENKAI_Price
            // 
            lbl_ENKAI_Price.AutoSize = true;
            lbl_ENKAI_Price.Cursor = Cursors.Hand;
            lbl_ENKAI_Price.CustomBackground = false;
            lbl_ENKAI_Price.Dock = DockStyle.Fill;
            lbl_ENKAI_Price.FontSize = MetroFramework.MetroLabelSize.Medium;
            lbl_ENKAI_Price.FontWeight = MetroFramework.MetroLabelWeight.Light;
            lbl_ENKAI_Price.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            lbl_ENKAI_Price.Location = new Point(396, 139);
            lbl_ENKAI_Price.Name = "lbl_ENKAI_Price";
            lbl_ENKAI_Price.Size = new Size(162, 45);
            lbl_ENKAI_Price.Style = MetroFramework.MetroColorStyle.Blue;
            lbl_ENKAI_Price.StyleManager = null;
            lbl_ENKAI_Price.TabIndex = 15;
            lbl_ENKAI_Price.Tag = "ENKAI";
            lbl_ENKAI_Price.Text = "-";
            lbl_ENKAI_Price.TextAlign = ContentAlignment.MiddleRight;
            lbl_ENKAI_Price.Theme = MetroFramework.MetroThemeStyle.Light;
            lbl_ENKAI_Price.UseStyleColors = false;
            lbl_ENKAI_Price.Click += lbl_Click;
            lbl_ENKAI_Price.DoubleClick += PriceLabel_DoubleClick;
            // 
            // lbl_ENKAI_Symbol
            // 
            lbl_ENKAI_Symbol.AutoSize = true;
            lbl_ENKAI_Symbol.Cursor = Cursors.Hand;
            lbl_ENKAI_Symbol.CustomBackground = false;
            lbl_ENKAI_Symbol.Dock = DockStyle.Fill;
            lbl_ENKAI_Symbol.FontSize = MetroFramework.MetroLabelSize.Medium;
            lbl_ENKAI_Symbol.FontWeight = MetroFramework.MetroLabelWeight.Light;
            lbl_ENKAI_Symbol.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            lbl_ENKAI_Symbol.Location = new Point(284, 139);
            lbl_ENKAI_Symbol.Name = "lbl_ENKAI_Symbol";
            lbl_ENKAI_Symbol.Size = new Size(105, 45);
            lbl_ENKAI_Symbol.Style = MetroFramework.MetroColorStyle.Blue;
            lbl_ENKAI_Symbol.StyleManager = null;
            lbl_ENKAI_Symbol.TabIndex = 14;
            lbl_ENKAI_Symbol.Tag = "ENKAI";
            lbl_ENKAI_Symbol.Text = "ENKAI";
            lbl_ENKAI_Symbol.TextAlign = ContentAlignment.MiddleLeft;
            lbl_ENKAI_Symbol.Theme = MetroFramework.MetroThemeStyle.Light;
            lbl_ENKAI_Symbol.UseStyleColors = false;
            lbl_ENKAI_Symbol.Click += lbl_Click;
            lbl_ENKAI_Symbol.DoubleClick += PriceLabel_DoubleClick;
            // 
            // lbl_EKGYO_Price
            // 
            lbl_EKGYO_Price.AutoSize = true;
            lbl_EKGYO_Price.Cursor = Cursors.Hand;
            lbl_EKGYO_Price.CustomBackground = false;
            lbl_EKGYO_Price.Dock = DockStyle.Fill;
            lbl_EKGYO_Price.FontSize = MetroFramework.MetroLabelSize.Medium;
            lbl_EKGYO_Price.FontWeight = MetroFramework.MetroLabelWeight.Light;
            lbl_EKGYO_Price.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            lbl_EKGYO_Price.Location = new Point(116, 139);
            lbl_EKGYO_Price.Name = "lbl_EKGYO_Price";
            lbl_EKGYO_Price.Size = new Size(161, 45);
            lbl_EKGYO_Price.Style = MetroFramework.MetroColorStyle.Blue;
            lbl_EKGYO_Price.StyleManager = null;
            lbl_EKGYO_Price.TabIndex = 13;
            lbl_EKGYO_Price.Tag = "EKGYO";
            lbl_EKGYO_Price.Text = "-";
            lbl_EKGYO_Price.TextAlign = ContentAlignment.MiddleRight;
            lbl_EKGYO_Price.Theme = MetroFramework.MetroThemeStyle.Light;
            lbl_EKGYO_Price.UseStyleColors = false;
            lbl_EKGYO_Price.Click += lbl_Click;
            lbl_EKGYO_Price.DoubleClick += PriceLabel_DoubleClick;
            // 
            // lbl_EKGYO_Symbol
            // 
            lbl_EKGYO_Symbol.AutoSize = true;
            lbl_EKGYO_Symbol.Cursor = Cursors.Hand;
            lbl_EKGYO_Symbol.CustomBackground = false;
            lbl_EKGYO_Symbol.Dock = DockStyle.Fill;
            lbl_EKGYO_Symbol.FontSize = MetroFramework.MetroLabelSize.Medium;
            lbl_EKGYO_Symbol.FontWeight = MetroFramework.MetroLabelWeight.Light;
            lbl_EKGYO_Symbol.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            lbl_EKGYO_Symbol.Location = new Point(4, 139);
            lbl_EKGYO_Symbol.Name = "lbl_EKGYO_Symbol";
            lbl_EKGYO_Symbol.Size = new Size(105, 45);
            lbl_EKGYO_Symbol.Style = MetroFramework.MetroColorStyle.Blue;
            lbl_EKGYO_Symbol.StyleManager = null;
            lbl_EKGYO_Symbol.TabIndex = 12;
            lbl_EKGYO_Symbol.Tag = "EKGYO";
            lbl_EKGYO_Symbol.Text = "EKGYO";
            lbl_EKGYO_Symbol.TextAlign = ContentAlignment.MiddleLeft;
            lbl_EKGYO_Symbol.Theme = MetroFramework.MetroThemeStyle.Light;
            lbl_EKGYO_Symbol.UseStyleColors = false;
            lbl_EKGYO_Symbol.Click += lbl_Click;
            lbl_EKGYO_Symbol.DoubleClick += PriceLabel_DoubleClick;
            // 
            // lbl_BRSAN_Price
            // 
            lbl_BRSAN_Price.AutoSize = true;
            lbl_BRSAN_Price.Cursor = Cursors.Hand;
            lbl_BRSAN_Price.CustomBackground = false;
            lbl_BRSAN_Price.Dock = DockStyle.Fill;
            lbl_BRSAN_Price.FontSize = MetroFramework.MetroLabelSize.Medium;
            lbl_BRSAN_Price.FontWeight = MetroFramework.MetroLabelWeight.Light;
            lbl_BRSAN_Price.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            lbl_BRSAN_Price.Location = new Point(396, 93);
            lbl_BRSAN_Price.Name = "lbl_BRSAN_Price";
            lbl_BRSAN_Price.Size = new Size(162, 45);
            lbl_BRSAN_Price.Style = MetroFramework.MetroColorStyle.Blue;
            lbl_BRSAN_Price.StyleManager = null;
            lbl_BRSAN_Price.TabIndex = 11;
            lbl_BRSAN_Price.Tag = "BRSAN";
            lbl_BRSAN_Price.Text = "-";
            lbl_BRSAN_Price.TextAlign = ContentAlignment.MiddleRight;
            lbl_BRSAN_Price.Theme = MetroFramework.MetroThemeStyle.Light;
            lbl_BRSAN_Price.UseStyleColors = false;
            lbl_BRSAN_Price.Click += lbl_Click;
            lbl_BRSAN_Price.DoubleClick += PriceLabel_DoubleClick;
            // 
            // lbl_BRSAN_Symbol
            // 
            lbl_BRSAN_Symbol.AutoSize = true;
            lbl_BRSAN_Symbol.Cursor = Cursors.Hand;
            lbl_BRSAN_Symbol.CustomBackground = false;
            lbl_BRSAN_Symbol.Dock = DockStyle.Fill;
            lbl_BRSAN_Symbol.FontSize = MetroFramework.MetroLabelSize.Medium;
            lbl_BRSAN_Symbol.FontWeight = MetroFramework.MetroLabelWeight.Light;
            lbl_BRSAN_Symbol.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            lbl_BRSAN_Symbol.Location = new Point(284, 93);
            lbl_BRSAN_Symbol.Name = "lbl_BRSAN_Symbol";
            lbl_BRSAN_Symbol.Size = new Size(105, 45);
            lbl_BRSAN_Symbol.Style = MetroFramework.MetroColorStyle.Blue;
            lbl_BRSAN_Symbol.StyleManager = null;
            lbl_BRSAN_Symbol.TabIndex = 10;
            lbl_BRSAN_Symbol.Tag = "BRSAN";
            lbl_BRSAN_Symbol.Text = "BRSAN";
            lbl_BRSAN_Symbol.TextAlign = ContentAlignment.MiddleLeft;
            lbl_BRSAN_Symbol.Theme = MetroFramework.MetroThemeStyle.Light;
            lbl_BRSAN_Symbol.UseStyleColors = false;
            lbl_BRSAN_Symbol.Click += lbl_Click;
            lbl_BRSAN_Symbol.DoubleClick += PriceLabel_DoubleClick;
            // 
            // lbl_BIMAS_Price
            // 
            lbl_BIMAS_Price.AutoSize = true;
            lbl_BIMAS_Price.Cursor = Cursors.Hand;
            lbl_BIMAS_Price.CustomBackground = false;
            lbl_BIMAS_Price.Dock = DockStyle.Fill;
            lbl_BIMAS_Price.FontSize = MetroFramework.MetroLabelSize.Medium;
            lbl_BIMAS_Price.FontWeight = MetroFramework.MetroLabelWeight.Light;
            lbl_BIMAS_Price.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            lbl_BIMAS_Price.Location = new Point(116, 93);
            lbl_BIMAS_Price.Name = "lbl_BIMAS_Price";
            lbl_BIMAS_Price.Size = new Size(161, 45);
            lbl_BIMAS_Price.Style = MetroFramework.MetroColorStyle.Blue;
            lbl_BIMAS_Price.StyleManager = null;
            lbl_BIMAS_Price.TabIndex = 9;
            lbl_BIMAS_Price.Tag = "BIMAS";
            lbl_BIMAS_Price.Text = "-";
            lbl_BIMAS_Price.TextAlign = ContentAlignment.MiddleRight;
            lbl_BIMAS_Price.Theme = MetroFramework.MetroThemeStyle.Light;
            lbl_BIMAS_Price.UseStyleColors = false;
            lbl_BIMAS_Price.Click += lbl_Click;
            lbl_BIMAS_Price.DoubleClick += PriceLabel_DoubleClick;
            // 
            // lbl_BIMAS_Symbol
            // 
            lbl_BIMAS_Symbol.AutoSize = true;
            lbl_BIMAS_Symbol.Cursor = Cursors.Hand;
            lbl_BIMAS_Symbol.CustomBackground = false;
            lbl_BIMAS_Symbol.Dock = DockStyle.Fill;
            lbl_BIMAS_Symbol.FontSize = MetroFramework.MetroLabelSize.Medium;
            lbl_BIMAS_Symbol.FontWeight = MetroFramework.MetroLabelWeight.Light;
            lbl_BIMAS_Symbol.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            lbl_BIMAS_Symbol.Location = new Point(4, 93);
            lbl_BIMAS_Symbol.Name = "lbl_BIMAS_Symbol";
            lbl_BIMAS_Symbol.Size = new Size(105, 45);
            lbl_BIMAS_Symbol.Style = MetroFramework.MetroColorStyle.Blue;
            lbl_BIMAS_Symbol.StyleManager = null;
            lbl_BIMAS_Symbol.TabIndex = 8;
            lbl_BIMAS_Symbol.Tag = "BIMAS";
            lbl_BIMAS_Symbol.Text = "BIMAS";
            lbl_BIMAS_Symbol.TextAlign = ContentAlignment.MiddleLeft;
            lbl_BIMAS_Symbol.Theme = MetroFramework.MetroThemeStyle.Light;
            lbl_BIMAS_Symbol.UseStyleColors = false;
            lbl_BIMAS_Symbol.Click += lbl_Click;
            lbl_BIMAS_Symbol.DoubleClick += PriceLabel_DoubleClick;
            // 
            // lbl_ASTOR_Price
            // 
            lbl_ASTOR_Price.AutoSize = true;
            lbl_ASTOR_Price.Cursor = Cursors.Hand;
            lbl_ASTOR_Price.CustomBackground = false;
            lbl_ASTOR_Price.Dock = DockStyle.Fill;
            lbl_ASTOR_Price.FontSize = MetroFramework.MetroLabelSize.Medium;
            lbl_ASTOR_Price.FontWeight = MetroFramework.MetroLabelWeight.Light;
            lbl_ASTOR_Price.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            lbl_ASTOR_Price.Location = new Point(396, 47);
            lbl_ASTOR_Price.Name = "lbl_ASTOR_Price";
            lbl_ASTOR_Price.Size = new Size(162, 45);
            lbl_ASTOR_Price.Style = MetroFramework.MetroColorStyle.Blue;
            lbl_ASTOR_Price.StyleManager = null;
            lbl_ASTOR_Price.TabIndex = 7;
            lbl_ASTOR_Price.Tag = "ASTOR";
            lbl_ASTOR_Price.Text = "-";
            lbl_ASTOR_Price.TextAlign = ContentAlignment.MiddleRight;
            lbl_ASTOR_Price.Theme = MetroFramework.MetroThemeStyle.Light;
            lbl_ASTOR_Price.UseStyleColors = false;
            lbl_ASTOR_Price.Click += lbl_Click;
            lbl_ASTOR_Price.DoubleClick += PriceLabel_DoubleClick;
            // 
            // lbl_ASTOR_Symbol
            // 
            lbl_ASTOR_Symbol.AutoSize = true;
            lbl_ASTOR_Symbol.Cursor = Cursors.Hand;
            lbl_ASTOR_Symbol.CustomBackground = false;
            lbl_ASTOR_Symbol.Dock = DockStyle.Fill;
            lbl_ASTOR_Symbol.FontSize = MetroFramework.MetroLabelSize.Medium;
            lbl_ASTOR_Symbol.FontWeight = MetroFramework.MetroLabelWeight.Light;
            lbl_ASTOR_Symbol.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            lbl_ASTOR_Symbol.Location = new Point(284, 47);
            lbl_ASTOR_Symbol.Name = "lbl_ASTOR_Symbol";
            lbl_ASTOR_Symbol.Size = new Size(105, 45);
            lbl_ASTOR_Symbol.Style = MetroFramework.MetroColorStyle.Blue;
            lbl_ASTOR_Symbol.StyleManager = null;
            lbl_ASTOR_Symbol.TabIndex = 6;
            lbl_ASTOR_Symbol.Tag = "ASTOR";
            lbl_ASTOR_Symbol.Text = "ASTOR";
            lbl_ASTOR_Symbol.TextAlign = ContentAlignment.MiddleLeft;
            lbl_ASTOR_Symbol.Theme = MetroFramework.MetroThemeStyle.Light;
            lbl_ASTOR_Symbol.UseStyleColors = false;
            lbl_ASTOR_Symbol.Click += lbl_Click;
            lbl_ASTOR_Symbol.DoubleClick += PriceLabel_DoubleClick;
            // 
            // lbl_ARCLK_Price
            // 
            lbl_ARCLK_Price.AutoSize = true;
            lbl_ARCLK_Price.Cursor = Cursors.Hand;
            lbl_ARCLK_Price.CustomBackground = false;
            lbl_ARCLK_Price.Dock = DockStyle.Fill;
            lbl_ARCLK_Price.FontSize = MetroFramework.MetroLabelSize.Medium;
            lbl_ARCLK_Price.FontWeight = MetroFramework.MetroLabelWeight.Light;
            lbl_ARCLK_Price.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            lbl_ARCLK_Price.Location = new Point(116, 47);
            lbl_ARCLK_Price.Name = "lbl_ARCLK_Price";
            lbl_ARCLK_Price.Size = new Size(161, 45);
            lbl_ARCLK_Price.Style = MetroFramework.MetroColorStyle.Blue;
            lbl_ARCLK_Price.StyleManager = null;
            lbl_ARCLK_Price.TabIndex = 5;
            lbl_ARCLK_Price.Tag = "ARCLK";
            lbl_ARCLK_Price.Text = "-";
            lbl_ARCLK_Price.TextAlign = ContentAlignment.MiddleRight;
            lbl_ARCLK_Price.Theme = MetroFramework.MetroThemeStyle.Light;
            lbl_ARCLK_Price.UseStyleColors = false;
            lbl_ARCLK_Price.Click += lbl_Click;
            lbl_ARCLK_Price.DoubleClick += PriceLabel_DoubleClick;
            // 
            // lbl_ARCLK_Symbol
            // 
            lbl_ARCLK_Symbol.AutoSize = true;
            lbl_ARCLK_Symbol.Cursor = Cursors.Hand;
            lbl_ARCLK_Symbol.CustomBackground = false;
            lbl_ARCLK_Symbol.Dock = DockStyle.Fill;
            lbl_ARCLK_Symbol.FontSize = MetroFramework.MetroLabelSize.Medium;
            lbl_ARCLK_Symbol.FontWeight = MetroFramework.MetroLabelWeight.Light;
            lbl_ARCLK_Symbol.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            lbl_ARCLK_Symbol.Location = new Point(4, 47);
            lbl_ARCLK_Symbol.Name = "lbl_ARCLK_Symbol";
            lbl_ARCLK_Symbol.Size = new Size(105, 45);
            lbl_ARCLK_Symbol.Style = MetroFramework.MetroColorStyle.Blue;
            lbl_ARCLK_Symbol.StyleManager = null;
            lbl_ARCLK_Symbol.TabIndex = 4;
            lbl_ARCLK_Symbol.Tag = "ARCLK";
            lbl_ARCLK_Symbol.Text = "ARCLK";
            lbl_ARCLK_Symbol.TextAlign = ContentAlignment.MiddleLeft;
            lbl_ARCLK_Symbol.Theme = MetroFramework.MetroThemeStyle.Light;
            lbl_ARCLK_Symbol.UseStyleColors = false;
            lbl_ARCLK_Symbol.Click += lbl_Click;
            lbl_ARCLK_Symbol.DoubleClick += PriceLabel_DoubleClick;
            // 
            // lbl_ASELS_Price
            // 
            lbl_ASELS_Price.AutoSize = true;
            lbl_ASELS_Price.Cursor = Cursors.Hand;
            lbl_ASELS_Price.CustomBackground = false;
            lbl_ASELS_Price.Dock = DockStyle.Fill;
            lbl_ASELS_Price.FontSize = MetroFramework.MetroLabelSize.Medium;
            lbl_ASELS_Price.FontWeight = MetroFramework.MetroLabelWeight.Light;
            lbl_ASELS_Price.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            lbl_ASELS_Price.Location = new Point(396, 1);
            lbl_ASELS_Price.Name = "lbl_ASELS_Price";
            lbl_ASELS_Price.Size = new Size(162, 45);
            lbl_ASELS_Price.Style = MetroFramework.MetroColorStyle.Blue;
            lbl_ASELS_Price.StyleManager = null;
            lbl_ASELS_Price.TabIndex = 3;
            lbl_ASELS_Price.Tag = "ASELS";
            lbl_ASELS_Price.Text = "-";
            lbl_ASELS_Price.TextAlign = ContentAlignment.MiddleRight;
            lbl_ASELS_Price.Theme = MetroFramework.MetroThemeStyle.Light;
            lbl_ASELS_Price.UseStyleColors = false;
            lbl_ASELS_Price.Click += lbl_Click;
            lbl_ASELS_Price.DoubleClick += PriceLabel_DoubleClick;
            // 
            // lbl_ASELS_Symbol
            // 
            lbl_ASELS_Symbol.AutoSize = true;
            lbl_ASELS_Symbol.Cursor = Cursors.Hand;
            lbl_ASELS_Symbol.CustomBackground = false;
            lbl_ASELS_Symbol.Dock = DockStyle.Fill;
            lbl_ASELS_Symbol.FontSize = MetroFramework.MetroLabelSize.Medium;
            lbl_ASELS_Symbol.FontWeight = MetroFramework.MetroLabelWeight.Light;
            lbl_ASELS_Symbol.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            lbl_ASELS_Symbol.Location = new Point(284, 1);
            lbl_ASELS_Symbol.Name = "lbl_ASELS_Symbol";
            lbl_ASELS_Symbol.Size = new Size(105, 45);
            lbl_ASELS_Symbol.Style = MetroFramework.MetroColorStyle.Blue;
            lbl_ASELS_Symbol.StyleManager = null;
            lbl_ASELS_Symbol.TabIndex = 2;
            lbl_ASELS_Symbol.Tag = "ASELS";
            lbl_ASELS_Symbol.Text = "ASELS";
            lbl_ASELS_Symbol.TextAlign = ContentAlignment.MiddleLeft;
            lbl_ASELS_Symbol.Theme = MetroFramework.MetroThemeStyle.Light;
            lbl_ASELS_Symbol.UseStyleColors = false;
            lbl_ASELS_Symbol.Click += lbl_Click;
            lbl_ASELS_Symbol.DoubleClick += PriceLabel_DoubleClick;
            // 
            // lbl_AKBNK_Symbol
            // 
            lbl_AKBNK_Symbol.AutoSize = true;
            lbl_AKBNK_Symbol.Cursor = Cursors.Hand;
            lbl_AKBNK_Symbol.CustomBackground = false;
            lbl_AKBNK_Symbol.Dock = DockStyle.Fill;
            lbl_AKBNK_Symbol.FontSize = MetroFramework.MetroLabelSize.Medium;
            lbl_AKBNK_Symbol.FontWeight = MetroFramework.MetroLabelWeight.Light;
            lbl_AKBNK_Symbol.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            lbl_AKBNK_Symbol.Location = new Point(4, 1);
            lbl_AKBNK_Symbol.Name = "lbl_AKBNK_Symbol";
            lbl_AKBNK_Symbol.Size = new Size(105, 45);
            lbl_AKBNK_Symbol.Style = MetroFramework.MetroColorStyle.Blue;
            lbl_AKBNK_Symbol.StyleManager = null;
            lbl_AKBNK_Symbol.TabIndex = 0;
            lbl_AKBNK_Symbol.Tag = "AKBNK";
            lbl_AKBNK_Symbol.Text = "AKBNK";
            lbl_AKBNK_Symbol.TextAlign = ContentAlignment.MiddleLeft;
            lbl_AKBNK_Symbol.Theme = MetroFramework.MetroThemeStyle.Light;
            lbl_AKBNK_Symbol.UseStyleColors = false;
            lbl_AKBNK_Symbol.Click += lbl_Click;
            lbl_AKBNK_Symbol.DoubleClick += PriceLabel_DoubleClick;
            // 
            // lbl_AKBNK_Price
            // 
            lbl_AKBNK_Price.AutoSize = true;
            lbl_AKBNK_Price.Cursor = Cursors.Hand;
            lbl_AKBNK_Price.CustomBackground = false;
            lbl_AKBNK_Price.Dock = DockStyle.Fill;
            lbl_AKBNK_Price.FontSize = MetroFramework.MetroLabelSize.Medium;
            lbl_AKBNK_Price.FontWeight = MetroFramework.MetroLabelWeight.Light;
            lbl_AKBNK_Price.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            lbl_AKBNK_Price.Location = new Point(116, 1);
            lbl_AKBNK_Price.Name = "lbl_AKBNK_Price";
            lbl_AKBNK_Price.Size = new Size(161, 45);
            lbl_AKBNK_Price.Style = MetroFramework.MetroColorStyle.Blue;
            lbl_AKBNK_Price.StyleManager = null;
            lbl_AKBNK_Price.TabIndex = 1;
            lbl_AKBNK_Price.Tag = "AKBNK";
            lbl_AKBNK_Price.Text = "-";
            lbl_AKBNK_Price.TextAlign = ContentAlignment.MiddleRight;
            lbl_AKBNK_Price.Theme = MetroFramework.MetroThemeStyle.Light;
            lbl_AKBNK_Price.UseStyleColors = false;
            lbl_AKBNK_Price.Click += lbl_Click;
            lbl_AKBNK_Price.DoubleClick += PriceLabel_DoubleClick;
            // 
            // chartPrice
            // 
            chartArea1.AxisX.Interval = 5D;
            chartArea1.AxisX.LabelStyle.Format = "HH:mm:ss";
            chartArea1.Name = "ChartArea1";
            chartPrice.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartPrice.Legends.Add(legend1);
            chartPrice.Location = new Point(3, 3);
            chartPrice.Name = "chartPrice";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Price";
            chartPrice.Series.Add(series1);
            chartPrice.Size = new Size(715, 689);
            chartPrice.TabIndex = 0;
            chartPrice.Text = "chart1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 695);
            Controls.Add(splitMain);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            splitMain.Panel1.ResumeLayout(false);
            splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitMain).EndInit();
            splitMain.ResumeLayout(false);
            tableStocks.ResumeLayout(false);
            tableStocks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartPrice).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private SplitContainer splitMain;
        private TableLayoutPanel tableStocks;
        private MetroFramework.Controls.MetroLabel lbl_TUPRS_Price;
        private MetroFramework.Controls.MetroLabel lbl_TUPRS_Symbol;
        private MetroFramework.Controls.MetroLabel lbl_TOASO_Price;
        private MetroFramework.Controls.MetroLabel lbl_TOASO_Symbol;
        private MetroFramework.Controls.MetroLabel lbl_THYAO_Price;
        private MetroFramework.Controls.MetroLabel lbl_THYAO_Symbol;
        private MetroFramework.Controls.MetroLabel lbl_TCELL_Price;
        private MetroFramework.Controls.MetroLabel lbl_TCELL_Symbol;
        private MetroFramework.Controls.MetroLabel lbl_SOKM_Price;
        private MetroFramework.Controls.MetroLabel lbl_SOKM_Symbol;
        private MetroFramework.Controls.MetroLabel lbl_SISE_Price;
        private MetroFramework.Controls.MetroLabel lbl_SISE_Symbol;
        private MetroFramework.Controls.MetroLabel lbl_SASA_Price;
        private MetroFramework.Controls.MetroLabel lbl_SASA_Symbol;
        private MetroFramework.Controls.MetroLabel lbl_SAHOL_Price;
        private MetroFramework.Controls.MetroLabel lbl_SAHOL_Symbol;
        private MetroFramework.Controls.MetroLabel lbl_PGSUS_Price;
        private MetroFramework.Controls.MetroLabel lbl_PGSUS_Symbol;
        private MetroFramework.Controls.MetroLabel lbl_PETKM_Price;
        private MetroFramework.Controls.MetroLabel lbl_PETKM_Symbol;
        private MetroFramework.Controls.MetroLabel lbl_KRDMD_Price;
        private MetroFramework.Controls.MetroLabel lbl_KRDMD_Symbol;
        private MetroFramework.Controls.MetroLabel lbl_KOZAL_Price;
        private MetroFramework.Controls.MetroLabel lbl_KOZAL_Symbol;
        private MetroFramework.Controls.MetroLabel lbl_KOZAA_Price;
        private MetroFramework.Controls.MetroLabel lbl_KOZAA_Symbol;
        private MetroFramework.Controls.MetroLabel lbl_KCHOL_Price;
        private MetroFramework.Controls.MetroLabel lbl_KCHOL_Symbol;
        private MetroFramework.Controls.MetroLabel lbl_ISCTR_Price;
        private MetroFramework.Controls.MetroLabel lbl_ISCTR_Symbol;
        private MetroFramework.Controls.MetroLabel lbl_HEKTS_Price;
        private MetroFramework.Controls.MetroLabel lbl_HEKTS_Symbol;
        private MetroFramework.Controls.MetroLabel lbl_GUBRF_Price;
        private MetroFramework.Controls.MetroLabel lbl_GUBRF_Symbol;
        private MetroFramework.Controls.MetroLabel lbl_GARAN_Price;
        private MetroFramework.Controls.MetroLabel lbl_GARAN_Symbol;
        private MetroFramework.Controls.MetroLabel lbl_FROTO_Price;
        private MetroFramework.Controls.MetroLabel lbl_FROTO_Symbol;
        private MetroFramework.Controls.MetroLabel lbl_EREGL_Price;
        private MetroFramework.Controls.MetroLabel lbl_EREGL_Symbol;
        private MetroFramework.Controls.MetroLabel lbl_ENKAI_Price;
        private MetroFramework.Controls.MetroLabel lbl_ENKAI_Symbol;
        private MetroFramework.Controls.MetroLabel lbl_EKGYO_Price;
        private MetroFramework.Controls.MetroLabel lbl_EKGYO_Symbol;
        private MetroFramework.Controls.MetroLabel lbl_BRSAN_Price;
        private MetroFramework.Controls.MetroLabel lbl_BRSAN_Symbol;
        private MetroFramework.Controls.MetroLabel lbl_BIMAS_Price;
        private MetroFramework.Controls.MetroLabel lbl_BIMAS_Symbol;
        private MetroFramework.Controls.MetroLabel lbl_ASTOR_Price;
        private MetroFramework.Controls.MetroLabel lbl_ASTOR_Symbol;
        private MetroFramework.Controls.MetroLabel lbl_ARCLK_Price;
        private MetroFramework.Controls.MetroLabel lbl_ARCLK_Symbol;
        private MetroFramework.Controls.MetroLabel lbl_ASELS_Price;
        private MetroFramework.Controls.MetroLabel lbl_ASELS_Symbol;
        private MetroFramework.Controls.MetroLabel lbl_AKBNK_Symbol;
        private MetroFramework.Controls.MetroLabel lbl_AKBNK_Price;
        private MetroFramework.Controls.MetroLabel lbl_YKBNK_Price;
        private MetroFramework.Controls.MetroLabel lbl_YKBNK_Symbol;
        private MetroFramework.Controls.MetroLabel lbl_BIST30_Price;
        private MetroFramework.Controls.MetroLabel lbl_BIST30_Symbol;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPrice;
    }
}
