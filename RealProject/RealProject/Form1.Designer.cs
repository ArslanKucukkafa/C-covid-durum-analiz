namespace RealProject
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblUserName = new System.Windows.Forms.Label();
            this.PnlMother = new System.Windows.Forms.Panel();
            this.smplÖgrenciKontrol = new DevExpress.XtraEditors.SimpleButton();
            this.SmplYönetici = new DevExpress.XtraEditors.SimpleButton();
            this.SmplGrafik = new DevExpress.XtraEditors.SimpleButton();
            this.SmplSorgu = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(82)))), ((int)(((byte)(86)))));
            this.panel1.Controls.Add(this.smplÖgrenciKontrol);
            this.panel1.Controls.Add(this.SmplYönetici);
            this.panel1.Controls.Add(this.SmplGrafik);
            this.panel1.Controls.Add(this.SmplSorgu);
            this.panel1.Controls.Add(this.LblUserName);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 563);
            this.panel1.TabIndex = 0;
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserName.ForeColor = System.Drawing.Color.White;
            this.LblUserName.Location = new System.Drawing.Point(81, 111);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(71, 24);
            this.LblUserName.TabIndex = 3;
            this.LblUserName.Text = "Username";
            // 
            // PnlMother
            // 
            this.PnlMother.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(121)))), ((int)(((byte)(128)))));
            this.PnlMother.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMother.Location = new System.Drawing.Point(231, 0);
            this.PnlMother.Name = "PnlMother";
            this.PnlMother.Size = new System.Drawing.Size(794, 563);
            this.PnlMother.TabIndex = 1;
            // 
            // smplÖgrenciKontrol
            // 
            this.smplÖgrenciKontrol.Appearance.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold);
            this.smplÖgrenciKontrol.Appearance.ForeColor = System.Drawing.Color.White;
            this.smplÖgrenciKontrol.Appearance.Options.UseFont = true;
            this.smplÖgrenciKontrol.Appearance.Options.UseForeColor = true;
            this.smplÖgrenciKontrol.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.smplÖgrenciKontrol.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("smplÖgrenciKontrol.ImageOptions.Image")));
            this.smplÖgrenciKontrol.Location = new System.Drawing.Point(0, 399);
            this.smplÖgrenciKontrol.Name = "smplÖgrenciKontrol";
            this.smplÖgrenciKontrol.Size = new System.Drawing.Size(228, 63);
            this.smplÖgrenciKontrol.TabIndex = 7;
            this.smplÖgrenciKontrol.Text = "ÖgrenciKontrol";
            this.smplÖgrenciKontrol.Click += new System.EventHandler(this.smplÖgrenciKontrol_Click);
            // 
            // SmplYönetici
            // 
            this.SmplYönetici.Appearance.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold);
            this.SmplYönetici.Appearance.ForeColor = System.Drawing.Color.White;
            this.SmplYönetici.Appearance.Options.UseFont = true;
            this.SmplYönetici.Appearance.Options.UseForeColor = true;
            this.SmplYönetici.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.SmplYönetici.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SmplYönetici.ImageOptions.Image")));
            this.SmplYönetici.Location = new System.Drawing.Point(0, 336);
            this.SmplYönetici.Name = "SmplYönetici";
            this.SmplYönetici.Size = new System.Drawing.Size(228, 63);
            this.SmplYönetici.TabIndex = 6;
            this.SmplYönetici.Text = "Yönetici Giriş";
            this.SmplYönetici.Click += new System.EventHandler(this.SmplYönetici_Click);
            // 
            // SmplGrafik
            // 
            this.SmplGrafik.Appearance.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold);
            this.SmplGrafik.Appearance.ForeColor = System.Drawing.Color.White;
            this.SmplGrafik.Appearance.Options.UseFont = true;
            this.SmplGrafik.Appearance.Options.UseForeColor = true;
            this.SmplGrafik.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.SmplGrafik.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SmplGrafik.ImageOptions.Image")));
            this.SmplGrafik.Location = new System.Drawing.Point(0, 267);
            this.SmplGrafik.Name = "SmplGrafik";
            this.SmplGrafik.Size = new System.Drawing.Size(228, 63);
            this.SmplGrafik.TabIndex = 5;
            this.SmplGrafik.Text = "Grafik Analiz";
            this.SmplGrafik.Click += new System.EventHandler(this.SmplGrafik_Click);
            // 
            // SmplSorgu
            // 
            this.SmplSorgu.Appearance.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold);
            this.SmplSorgu.Appearance.ForeColor = System.Drawing.Color.White;
            this.SmplSorgu.Appearance.Options.UseFont = true;
            this.SmplSorgu.Appearance.Options.UseForeColor = true;
            this.SmplSorgu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.SmplSorgu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SmplSorgu.ImageOptions.Image")));
            this.SmplSorgu.Location = new System.Drawing.Point(0, 198);
            this.SmplSorgu.Name = "SmplSorgu";
            this.SmplSorgu.Size = new System.Drawing.Size(228, 63);
            this.SmplSorgu.TabIndex = 4;
            this.SmplSorgu.Text = "Ögrenci Sorgulama";
            this.SmplSorgu.Click += new System.EventHandler(this.SmplSorgu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RealProject.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(82, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 563);
            this.Controls.Add(this.PnlMother);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton SmplYönetici;
        private DevExpress.XtraEditors.SimpleButton SmplGrafik;
        private DevExpress.XtraEditors.SimpleButton SmplSorgu;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.Panel PnlMother;
        private DevExpress.XtraEditors.SimpleButton smplÖgrenciKontrol;
    }
}

