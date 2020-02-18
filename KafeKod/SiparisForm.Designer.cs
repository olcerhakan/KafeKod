namespace KafeKod
{
    partial class SiparisForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudAdet = new System.Windows.Forms.NumericUpDown();
            this.cboUrun = new System.Windows.Forms.ComboBox();
            this.cboMasaNo = new System.Windows.Forms.ComboBox();
            this.btnMasaTasi = new System.Windows.Forms.Button();
            this.dgvSiparisDetaylari = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblMasaNo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.btnSiparisIptal = new System.Windows.Forms.Button();
            this.btnOdemeAl = new System.Windows.Forms.Button();
            this.btnAnaSayfa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisDetaylari)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(140, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adet";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(447, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Masa No :";
            // 
            // nudAdet
            // 
            this.nudAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudAdet.Location = new System.Drawing.Point(144, 44);
            this.nudAdet.Name = "nudAdet";
            this.nudAdet.Size = new System.Drawing.Size(58, 29);
            this.nudAdet.TabIndex = 3;
            // 
            // cboUrun
            // 
            this.cboUrun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboUrun.FormattingEnabled = true;
            this.cboUrun.Location = new System.Drawing.Point(13, 44);
            this.cboUrun.Name = "cboUrun";
            this.cboUrun.Size = new System.Drawing.Size(116, 28);
            this.cboUrun.TabIndex = 4;
            // 
            // cboMasaNo
            // 
            this.cboMasaNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMasaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboMasaNo.FormattingEnabled = true;
            this.cboMasaNo.Location = new System.Drawing.Point(451, 41);
            this.cboMasaNo.Name = "cboMasaNo";
            this.cboMasaNo.Size = new System.Drawing.Size(83, 32);
            this.cboMasaNo.TabIndex = 5;
            // 
            // btnMasaTasi
            // 
            this.btnMasaTasi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMasaTasi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMasaTasi.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMasaTasi.ForeColor = System.Drawing.Color.Black;
            this.btnMasaTasi.Location = new System.Drawing.Point(582, 40);
            this.btnMasaTasi.Name = "btnMasaTasi";
            this.btnMasaTasi.Size = new System.Drawing.Size(93, 37);
            this.btnMasaTasi.TabIndex = 6;
            this.btnMasaTasi.Text = "TAŞI";
            this.btnMasaTasi.UseVisualStyleBackColor = false;
            // 
            // dgvSiparisDetaylari
            // 
            this.dgvSiparisDetaylari.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSiparisDetaylari.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dgvSiparisDetaylari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparisDetaylari.Location = new System.Drawing.Point(13, 86);
            this.dgvSiparisDetaylari.Name = "dgvSiparisDetaylari";
            this.dgvSiparisDetaylari.Size = new System.Drawing.Size(318, 379);
            this.dgvSiparisDetaylari.TabIndex = 7;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEkle.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.Black;
            this.btnEkle.Location = new System.Drawing.Point(242, 41);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(89, 33);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            // 
            // lblMasaNo
            // 
            this.lblMasaNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMasaNo.BackColor = System.Drawing.Color.Tomato;
            this.lblMasaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMasaNo.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.lblMasaNo.Location = new System.Drawing.Point(389, 86);
            this.lblMasaNo.Name = "lblMasaNo";
            this.lblMasaNo.Size = new System.Drawing.Size(286, 191);
            this.lblMasaNo.TabIndex = 9;
            this.lblMasaNo.Text = "00";
            this.lblMasaNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(428, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ödeme Tutarı :";
            // 
            // lblTutar
            // 
            this.lblTutar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTutar.AutoSize = true;
            this.lblTutar.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTutar.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblTutar.Location = new System.Drawing.Point(558, 304);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(64, 23);
            this.lblTutar.TabIndex = 11;
            this.lblTutar.Text = "9.99 ₺";
            // 
            // btnSiparisIptal
            // 
            this.btnSiparisIptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSiparisIptal.BackColor = System.Drawing.Color.DarkRed;
            this.btnSiparisIptal.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisIptal.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSiparisIptal.Location = new System.Drawing.Point(389, 344);
            this.btnSiparisIptal.Name = "btnSiparisIptal";
            this.btnSiparisIptal.Size = new System.Drawing.Size(145, 66);
            this.btnSiparisIptal.TabIndex = 12;
            this.btnSiparisIptal.TabStop = false;
            this.btnSiparisIptal.Text = "SİPARİŞ İPTAL ";
            this.btnSiparisIptal.UseVisualStyleBackColor = false;
            // 
            // btnOdemeAl
            // 
            this.btnOdemeAl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOdemeAl.BackColor = System.Drawing.Color.Green;
            this.btnOdemeAl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdemeAl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOdemeAl.Location = new System.Drawing.Point(556, 344);
            this.btnOdemeAl.Name = "btnOdemeAl";
            this.btnOdemeAl.Size = new System.Drawing.Size(119, 66);
            this.btnOdemeAl.TabIndex = 13;
            this.btnOdemeAl.Text = "ÖDEME AL";
            this.btnOdemeAl.UseVisualStyleBackColor = false;
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnaSayfa.BackColor = System.Drawing.Color.Yellow;
            this.btnAnaSayfa.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaSayfa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAnaSayfa.Location = new System.Drawing.Point(389, 416);
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Size = new System.Drawing.Size(286, 49);
            this.btnAnaSayfa.TabIndex = 14;
            this.btnAnaSayfa.Text = "ANASAYFAYA DÖN";
            this.btnAnaSayfa.UseVisualStyleBackColor = false;
            // 
            // SiparisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(734, 500);
            this.Controls.Add(this.btnAnaSayfa);
            this.Controls.Add(this.btnOdemeAl);
            this.Controls.Add(this.btnSiparisIptal);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblMasaNo);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dgvSiparisDetaylari);
            this.Controls.Add(this.btnMasaTasi);
            this.Controls.Add(this.cboMasaNo);
            this.Controls.Add(this.cboUrun);
            this.Controls.Add(this.nudAdet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(750, 539);
            this.Name = "SiparisForm";
            this.Text = "Masa 0";
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisDetaylari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudAdet;
        private System.Windows.Forms.ComboBox cboUrun;
        private System.Windows.Forms.ComboBox cboMasaNo;
        private System.Windows.Forms.Button btnMasaTasi;
        private System.Windows.Forms.DataGridView dgvSiparisDetaylari;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lblMasaNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Button btnSiparisIptal;
        private System.Windows.Forms.Button btnOdemeAl;
        private System.Windows.Forms.Button btnAnaSayfa;
    }
}