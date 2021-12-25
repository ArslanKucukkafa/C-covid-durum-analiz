namespace RealProject
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.CmbxBölüm = new System.Windows.Forms.ComboBox();
            this.CmbxFakülte = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PcrGrafik = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CrcleYogunluk = new CircularProgressBar.CircularProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.SmplGöster = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.PcrGrafik)).BeginInit();
            this.SuspendLayout();
            // 
            // CmbxBölüm
            // 
            this.CmbxBölüm.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbxBölüm.FormattingEnabled = true;
            this.CmbxBölüm.Location = new System.Drawing.Point(121, 80);
            this.CmbxBölüm.Name = "CmbxBölüm";
            this.CmbxBölüm.Size = new System.Drawing.Size(228, 25);
            this.CmbxBölüm.TabIndex = 31;
            this.CmbxBölüm.SelectedIndexChanged += new System.EventHandler(this.CmbxBölüm_SelectedIndexChanged);
            // 
            // CmbxFakülte
            // 
            this.CmbxFakülte.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbxFakülte.FormattingEnabled = true;
            this.CmbxFakülte.Items.AddRange(new object[] {
            "Pozitif",
            "Negatif"});
            this.CmbxFakülte.Location = new System.Drawing.Point(121, 40);
            this.CmbxFakülte.Name = "CmbxFakülte";
            this.CmbxFakülte.Size = new System.Drawing.Size(228, 25);
            this.CmbxFakülte.TabIndex = 30;
            this.CmbxFakülte.SelectedIndexChanged += new System.EventHandler(this.CmbxFakülte_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Bölüm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Fakülte:";
            // 
            // PcrGrafik
            // 
            this.PcrGrafik.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.PcrGrafik.ChartAreas.Add(chartArea1);
            this.PcrGrafik.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend1.Name = "Legend1";
            this.PcrGrafik.Legends.Add(legend1);
            this.PcrGrafik.Location = new System.Drawing.Point(0, 191);
            this.PcrGrafik.Name = "PcrGrafik";
            this.PcrGrafik.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(211)))), ((int)(((byte)(207)))));
            series1.Legend = "Legend1";
            series1.Name = "Aylar";
            this.PcrGrafik.Series.Add(series1);
            this.PcrGrafik.Size = new System.Drawing.Size(771, 329);
            this.PcrGrafik.TabIndex = 32;
            this.PcrGrafik.Text = "chart1";
            // 
            // CrcleYogunluk
            // 
            this.CrcleYogunluk.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.CrcleYogunluk.AnimationSpeed = 500;
            this.CrcleYogunluk.BackColor = System.Drawing.Color.Transparent;
            this.CrcleYogunluk.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CrcleYogunluk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CrcleYogunluk.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CrcleYogunluk.InnerMargin = 2;
            this.CrcleYogunluk.InnerWidth = -1;
            this.CrcleYogunluk.Location = new System.Drawing.Point(555, 7);
            this.CrcleYogunluk.MarqueeAnimationSpeed = 2000;
            this.CrcleYogunluk.Name = "CrcleYogunluk";
            this.CrcleYogunluk.OuterColor = System.Drawing.Color.White;
            this.CrcleYogunluk.OuterMargin = -25;
            this.CrcleYogunluk.OuterWidth = 26;
            this.CrcleYogunluk.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(211)))), ((int)(((byte)(207)))));
            this.CrcleYogunluk.ProgressWidth = 25;
            this.CrcleYogunluk.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.CrcleYogunluk.Size = new System.Drawing.Size(216, 178);
            this.CrcleYogunluk.StartAngle = 270;
            this.CrcleYogunluk.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.CrcleYogunluk.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.CrcleYogunluk.SubscriptText = ".23";
            this.CrcleYogunluk.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.CrcleYogunluk.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.CrcleYogunluk.SuperscriptText = "°C";
            this.CrcleYogunluk.TabIndex = 33;
            this.CrcleYogunluk.Text = "%100";
            this.CrcleYogunluk.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.CrcleYogunluk.Value = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(351, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 29);
            this.label3.TabIndex = 34;
            this.label3.Text = "Analiz";
            // 
            // SmplGöster
            // 
            this.SmplGöster.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SmplGöster.Appearance.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SmplGöster.Appearance.Options.UseFont = true;
            this.SmplGöster.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SmplGöster.ImageOptions.Image")));
            this.SmplGöster.Location = new System.Drawing.Point(121, 155);
            this.SmplGöster.Name = "SmplGöster";
            this.SmplGöster.Size = new System.Drawing.Size(126, 30);
            this.SmplGöster.TabIndex = 28;
            this.SmplGöster.Text = "Göster";
            this.SmplGöster.Click += new System.EventHandler(this.SmplGöster_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(121)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(771, 520);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CrcleYogunluk);
            this.Controls.Add(this.PcrGrafik);
            this.Controls.Add(this.CmbxBölüm);
            this.Controls.Add(this.CmbxFakülte);
            this.Controls.Add(this.SmplGöster);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PcrGrafik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CmbxBölüm;
        private System.Windows.Forms.ComboBox CmbxFakülte;
        private DevExpress.XtraEditors.SimpleButton SmplGöster;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart PcrGrafik;
        private CircularProgressBar.CircularProgressBar CrcleYogunluk;
        private System.Windows.Forms.Label label3;
    }
}