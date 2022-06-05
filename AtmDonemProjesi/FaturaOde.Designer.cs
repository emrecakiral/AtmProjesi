namespace AtmDonemProjesi
{
    partial class FaturaOde
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FaturaOde));
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnFaturaOde = new System.Windows.Forms.Button();
            this.lblFaturaBilgi = new System.Windows.Forms.Label();
            this.cBoxKurum = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.Transparent;
            this.btnGeri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGeri.BackgroundImage")));
            this.btnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGeri.FlatAppearance.BorderSize = 0;
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeri.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGeri.Location = new System.Drawing.Point(12, 661);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(80, 80);
            this.btnGeri.TabIndex = 30;
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnFaturaOde
            // 
            this.btnFaturaOde.BackColor = System.Drawing.Color.YellowGreen;
            this.btnFaturaOde.Enabled = false;
            this.btnFaturaOde.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFaturaOde.Location = new System.Drawing.Point(330, 464);
            this.btnFaturaOde.Name = "btnFaturaOde";
            this.btnFaturaOde.Size = new System.Drawing.Size(257, 90);
            this.btnFaturaOde.TabIndex = 32;
            this.btnFaturaOde.Text = "Ödemeyi Tamamla";
            this.btnFaturaOde.UseVisualStyleBackColor = false;
            this.btnFaturaOde.Click += new System.EventHandler(this.btnFaturaOde_Click);
            // 
            // lblFaturaBilgi
            // 
            this.lblFaturaBilgi.AutoSize = true;
            this.lblFaturaBilgi.BackColor = System.Drawing.Color.Transparent;
            this.lblFaturaBilgi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFaturaBilgi.Location = new System.Drawing.Point(267, 313);
            this.lblFaturaBilgi.Name = "lblFaturaBilgi";
            this.lblFaturaBilgi.Size = new System.Drawing.Size(0, 28);
            this.lblFaturaBilgi.TabIndex = 33;
            // 
            // cBoxKurum
            // 
            this.cBoxKurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxKurum.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cBoxKurum.FormattingEnabled = true;
            this.cBoxKurum.Items.AddRange(new object[] {
            "CK BOĞAZİÇİ ELEKTRİK PERAKENDE SATIŞ AŞ",
            "İSKİ",
            "SUPERONLINE",
            "TÜRK TELEKOM İNTERNET (TTNET)",
            "İGDAŞ",
            "TURKCELL",
            "VODAFONE",
            "TÜRK TELEKOM MOBİL"});
            this.cBoxKurum.Location = new System.Drawing.Point(251, 227);
            this.cBoxKurum.Name = "cBoxKurum";
            this.cBoxKurum.Size = new System.Drawing.Size(415, 38);
            this.cBoxKurum.TabIndex = 34;
            this.cBoxKurum.SelectedValueChanged += new System.EventHandler(this.cBoxKurum_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(330, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 35);
            this.label1.TabIndex = 35;
            this.label1.Text = "Lütfen kurum seçin";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(906, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(64, 64);
            this.btnClose.TabIndex = 36;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FaturaOde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBoxKurum);
            this.Controls.Add(this.lblFaturaBilgi);
            this.Controls.Add(this.btnFaturaOde);
            this.Controls.Add(this.btnGeri);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FaturaOde";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FaturaOde";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FaturaOde_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGeri;
        private Button btnFaturaOde;
        private Label lblFaturaBilgi;
        private ComboBox cBoxKurum;
        private Label label1;
        private Button btnClose;
    }
}