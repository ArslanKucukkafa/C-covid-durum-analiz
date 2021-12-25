namespace RealProject
{
    partial class BölümYönetim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BölümYönetim));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbxBölüm = new System.Windows.Forms.TextBox();
            this.txbxFakülte = new System.Windows.Forms.TextBox();
            this.txbxBlmNo = new System.Windows.Forms.TextBox();
            this.SmplEkle = new DevExpress.XtraEditors.SimpleButton();
            this.SmplGüncelle = new DevExpress.XtraEditors.SimpleButton();
            this.SmplSil = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bölüm :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fakülte :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bölüm No :";
            // 
            // txbxBölüm
            // 
            this.txbxBölüm.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxBölüm.Location = new System.Drawing.Point(128, 58);
            this.txbxBölüm.Name = "txbxBölüm";
            this.txbxBölüm.Size = new System.Drawing.Size(226, 25);
            this.txbxBölüm.TabIndex = 3;
            // 
            // txbxFakülte
            // 
            this.txbxFakülte.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxFakülte.Location = new System.Drawing.Point(128, 105);
            this.txbxFakülte.Name = "txbxFakülte";
            this.txbxFakülte.Size = new System.Drawing.Size(226, 25);
            this.txbxFakülte.TabIndex = 4;
            // 
            // txbxBlmNo
            // 
            this.txbxBlmNo.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxBlmNo.Location = new System.Drawing.Point(128, 153);
            this.txbxBlmNo.Name = "txbxBlmNo";
            this.txbxBlmNo.Size = new System.Drawing.Size(106, 25);
            this.txbxBlmNo.TabIndex = 5;
            // 
            // SmplEkle
            // 
            this.SmplEkle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SmplEkle.Appearance.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SmplEkle.Appearance.Options.UseFont = true;
            this.SmplEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SmplEkle.ImageOptions.Image")));
            this.SmplEkle.Location = new System.Drawing.Point(577, 50);
            this.SmplEkle.Name = "SmplEkle";
            this.SmplEkle.Size = new System.Drawing.Size(126, 39);
            this.SmplEkle.TabIndex = 27;
            this.SmplEkle.Text = "Ekle";
            this.SmplEkle.Click += new System.EventHandler(this.SmplEkle_Click);
            // 
            // SmplGüncelle
            // 
            this.SmplGüncelle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SmplGüncelle.Appearance.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SmplGüncelle.Appearance.Options.UseFont = true;
            this.SmplGüncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SmplGüncelle.ImageOptions.Image")));
            this.SmplGüncelle.Location = new System.Drawing.Point(577, 173);
            this.SmplGüncelle.Name = "SmplGüncelle";
            this.SmplGüncelle.Size = new System.Drawing.Size(128, 39);
            this.SmplGüncelle.TabIndex = 26;
            this.SmplGüncelle.Text = "Güncelle";
            this.SmplGüncelle.Click += new System.EventHandler(this.SmplGüncelle_Click);
            // 
            // SmplSil
            // 
            this.SmplSil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SmplSil.Appearance.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SmplSil.Appearance.Options.UseFont = true;
            this.SmplSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SmplSil.ImageOptions.Image")));
            this.SmplSil.Location = new System.Drawing.Point(577, 111);
            this.SmplSil.Name = "SmplSil";
            this.SmplSil.Size = new System.Drawing.Size(128, 39);
            this.SmplSil.TabIndex = 28;
            this.SmplSil.Text = "Sil";
            this.SmplSil.Click += new System.EventHandler(this.SmplSil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 276);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(771, 244);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // BölümYönetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(771, 520);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SmplEkle);
            this.Controls.Add(this.SmplGüncelle);
            this.Controls.Add(this.SmplSil);
            this.Controls.Add(this.txbxBlmNo);
            this.Controls.Add(this.txbxFakülte);
            this.Controls.Add(this.txbxBölüm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BölümYönetim";
            this.Text = "BölümYönetim";
            this.Load += new System.EventHandler(this.BölümYönetim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbxBölüm;
        private System.Windows.Forms.TextBox txbxFakülte;
        private System.Windows.Forms.TextBox txbxBlmNo;
        private DevExpress.XtraEditors.SimpleButton SmplEkle;
        private DevExpress.XtraEditors.SimpleButton SmplGüncelle;
        private DevExpress.XtraEditors.SimpleButton SmplSil;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}