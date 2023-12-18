namespace tiyatro
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.chkMüzik = new System.Windows.Forms.CheckBox();
            this.cmbSahne = new System.Windows.Forms.ComboBox();
            this.cmbOyunAd = new System.Windows.Forms.ComboBox();
            this.nupOyunSuresi = new System.Windows.Forms.NumericUpDown();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncele = new System.Windows.Forms.Button();
            this.dgrTiyotro = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nupOyunSuresi)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrTiyotro)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Image = global::tiyatro.Properties.Resources._002_diskette;
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEkle.Location = new System.Drawing.Point(146, 176);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(155, 58);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // chkMüzik
            // 
            this.chkMüzik.AutoSize = true;
            this.chkMüzik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkMüzik.Location = new System.Drawing.Point(626, 43);
            this.chkMüzik.Name = "chkMüzik";
            this.chkMüzik.Size = new System.Drawing.Size(78, 28);
            this.chkMüzik.TabIndex = 1;
            this.chkMüzik.Text = "Müzik";
            this.chkMüzik.UseVisualStyleBackColor = true;
            // 
            // cmbSahne
            // 
            this.cmbSahne.FormattingEnabled = true;
            this.cmbSahne.Items.AddRange(new object[] {
            "Gaziosmanpaşa Sahnesi",
            "Harbiye Cemil Topuzlu Açıkhava Tiyatrosu",
            "Harbiye Muhsin Ertuğrul Sahnesi",
            "Fatih Reşat Nuri Sahnesi",
            "Gaziosmanpaşa Ferih Egemen Çocuk Tiyatrosu Sahnesi"});
            this.cmbSahne.Location = new System.Drawing.Point(417, 69);
            this.cmbSahne.Name = "cmbSahne";
            this.cmbSahne.Size = new System.Drawing.Size(172, 21);
            this.cmbSahne.TabIndex = 2;
            // 
            // cmbOyunAd
            // 
            this.cmbOyunAd.FormattingEnabled = true;
            this.cmbOyunAd.Items.AddRange(new object[] {
            "Gül\'e Ağıt",
            "İfigenya",
            "Komik Para",
            "Çingene Boksör"});
            this.cmbOyunAd.Location = new System.Drawing.Point(129, 68);
            this.cmbOyunAd.Name = "cmbOyunAd";
            this.cmbOyunAd.Size = new System.Drawing.Size(172, 21);
            this.cmbOyunAd.TabIndex = 3;
            // 
            // nupOyunSuresi
            // 
            this.nupOyunSuresi.Location = new System.Drawing.Point(417, 41);
            this.nupOyunSuresi.Name = "nupOyunSuresi";
            this.nupOyunSuresi.Size = new System.Drawing.Size(172, 20);
            this.nupOyunSuresi.TabIndex = 4;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(129, 105);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(172, 20);
            this.dtpTarih.TabIndex = 5;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFiyat.Location = new System.Drawing.Point(417, 96);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(172, 29);
            this.txtFiyat.TabIndex = 6;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtId.Location = new System.Drawing.Point(119, 32);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(172, 29);
            this.txtId.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(37, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Oyun İd";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(38, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Oyun Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(19, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Oyun Tarih";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(297, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Oyun Süresi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(346, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Sahne";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(362, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Fiyat";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGuncele);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.chkMüzik);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbSahne);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbOyunAd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nupOyunSuresi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpTarih);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFiyat);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(798, 240);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Image = global::tiyatro.Properties.Resources._003_bin;
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSil.Location = new System.Drawing.Point(329, 176);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(155, 58);
            this.btnSil.TabIndex = 15;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnGuncele
            // 
            this.btnGuncele.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncele.Image = global::tiyatro.Properties.Resources._001_refresh;
            this.btnGuncele.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuncele.Location = new System.Drawing.Point(513, 176);
            this.btnGuncele.Name = "btnGuncele";
            this.btnGuncele.Size = new System.Drawing.Size(155, 58);
            this.btnGuncele.TabIndex = 16;
            this.btnGuncele.Text = "Güncele";
            this.btnGuncele.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuncele.UseVisualStyleBackColor = true;
            // 
            // dgrTiyotro
            // 
            this.dgrTiyotro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrTiyotro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrTiyotro.Location = new System.Drawing.Point(4, 244);
            this.dgrTiyotro.Name = "dgrTiyotro";
            this.dgrTiyotro.Size = new System.Drawing.Size(798, 236);
            this.dgrTiyotro.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 479);
            this.Controls.Add(this.dgrTiyotro);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupOyunSuresi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrTiyotro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.CheckBox chkMüzik;
        private System.Windows.Forms.ComboBox cmbSahne;
        private System.Windows.Forms.ComboBox cmbOyunAd;
        private System.Windows.Forms.NumericUpDown nupOyunSuresi;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGuncele;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dgrTiyotro;
    }
}

