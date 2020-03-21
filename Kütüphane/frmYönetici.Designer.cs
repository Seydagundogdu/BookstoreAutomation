namespace Kütüphane
{
    partial class frmYönetici
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
            this.lblBaslik = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSilinecekKitap = new System.Windows.Forms.TextBox();
            this.txtAranacakKitap = new System.Windows.Forms.TextBox();
            this.btnKayitSil = new System.Windows.Forms.Button();
            this.btnKayitAra = new System.Windows.Forms.Button();
            this.dtgKitapBilgileri = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.txtYazarAdi = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtYayinevi = new System.Windows.Forms.TextBox();
            this.txtBasimYili = new System.Windows.Forms.TextBox();
            this.txtBaskıSayisi = new System.Windows.Forms.TextBox();
            this.txtSayfaSayisi = new System.Windows.Forms.TextBox();
            this.txtKonu = new System.Windows.Forms.TextBox();
            this.txtTür = new System.Windows.Forms.TextBox();
            this.btnYeniKayit = new System.Windows.Forms.Button();
            this.btnKayitEkle = new System.Windows.Forms.Button();
            this.btnKayitGüncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgKitapBilgileri)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.ForeColor = System.Drawing.Color.Teal;
            this.lblBaslik.Location = new System.Drawing.Point(351, 20);
            this.lblBaslik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(288, 38);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "SG KÜTÜPHANE SİSTEMİ";
            this.lblBaslik.UseMnemonic = false;
            this.lblBaslik.Click += new System.EventHandler(this.lblBaslik_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Silinecek Kitap Adı:\r\n\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Aranacak Kitap Adı:\r\n";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtSilinecekKitap
            // 
            this.txtSilinecekKitap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtSilinecekKitap.Location = new System.Drawing.Point(209, 91);
            this.txtSilinecekKitap.Margin = new System.Windows.Forms.Padding(2);
            this.txtSilinecekKitap.Name = "txtSilinecekKitap";
            this.txtSilinecekKitap.Size = new System.Drawing.Size(108, 20);
            this.txtSilinecekKitap.TabIndex = 3;
            // 
            // txtAranacakKitap
            // 
            this.txtAranacakKitap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtAranacakKitap.Location = new System.Drawing.Point(209, 134);
            this.txtAranacakKitap.Margin = new System.Windows.Forms.Padding(2);
            this.txtAranacakKitap.Name = "txtAranacakKitap";
            this.txtAranacakKitap.Size = new System.Drawing.Size(108, 20);
            this.txtAranacakKitap.TabIndex = 4;
            this.txtAranacakKitap.TextChanged += new System.EventHandler(this.txtAranacakKitap_TextChanged);
            // 
            // btnKayitSil
            // 
            this.btnKayitSil.BackColor = System.Drawing.Color.White;
            this.btnKayitSil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnKayitSil.Location = new System.Drawing.Point(345, 85);
            this.btnKayitSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnKayitSil.Name = "btnKayitSil";
            this.btnKayitSil.Size = new System.Drawing.Size(74, 30);
            this.btnKayitSil.TabIndex = 5;
            this.btnKayitSil.Text = "KAYIT SİL";
            this.btnKayitSil.UseVisualStyleBackColor = false;
            this.btnKayitSil.Click += new System.EventHandler(this.btnKayitSil_Click);
            // 
            // btnKayitAra
            // 
            this.btnKayitAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnKayitAra.Location = new System.Drawing.Point(345, 128);
            this.btnKayitAra.Margin = new System.Windows.Forms.Padding(2);
            this.btnKayitAra.Name = "btnKayitAra";
            this.btnKayitAra.Size = new System.Drawing.Size(74, 30);
            this.btnKayitAra.TabIndex = 6;
            this.btnKayitAra.Text = "KAYIT ARA";
            this.btnKayitAra.UseVisualStyleBackColor = false;
            this.btnKayitAra.Click += new System.EventHandler(this.btnKayitAra_Click);
            // 
            // dtgKitapBilgileri
            // 
            this.dtgKitapBilgileri.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgKitapBilgileri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgKitapBilgileri.Location = new System.Drawing.Point(33, 196);
            this.dtgKitapBilgileri.Margin = new System.Windows.Forms.Padding(2);
            this.dtgKitapBilgileri.Name = "dtgKitapBilgileri";
            this.dtgKitapBilgileri.RowHeadersWidth = 51;
            this.dtgKitapBilgileri.RowTemplate.Height = 24;
            this.dtgKitapBilgileri.Size = new System.Drawing.Size(910, 187);
            this.dtgKitapBilgileri.TabIndex = 7;
            this.dtgKitapBilgileri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgKitapBilgileri_CellClick);
            this.dtgKitapBilgileri.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgKitapBilgileri_CellContentClick);
            this.dtgKitapBilgileri.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgKitapBilgileri_CellEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 426);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 475);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = " KİTAP ADI: ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 530);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "YAZAR ADI: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 581);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "ISBN: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(342, 426);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "YAYINEVİ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(333, 501);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "BASIM YILI: ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(320, 574);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "BASKI SAYISI: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(555, 425);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "SAYFA SAYISI: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(595, 519);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "KONU: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(595, 475);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "TÜRÜ: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(295, 529);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 13);
            this.label13.TabIndex = 18;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtID.Location = new System.Drawing.Point(153, 418);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(76, 20);
            this.txtID.TabIndex = 19;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtKitapAdi.ForeColor = System.Drawing.Color.Black;
            this.txtKitapAdi.Location = new System.Drawing.Point(153, 468);
            this.txtKitapAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(76, 20);
            this.txtKitapAdi.TabIndex = 20;
            // 
            // txtYazarAdi
            // 
            this.txtYazarAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtYazarAdi.Location = new System.Drawing.Point(153, 523);
            this.txtYazarAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txtYazarAdi.Name = "txtYazarAdi";
            this.txtYazarAdi.Size = new System.Drawing.Size(76, 20);
            this.txtYazarAdi.TabIndex = 21;
            // 
            // txtISBN
            // 
            this.txtISBN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtISBN.Location = new System.Drawing.Point(153, 574);
            this.txtISBN.Margin = new System.Windows.Forms.Padding(2);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(76, 20);
            this.txtISBN.TabIndex = 22;
            // 
            // txtYayinevi
            // 
            this.txtYayinevi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtYayinevi.Location = new System.Drawing.Point(433, 419);
            this.txtYayinevi.Margin = new System.Windows.Forms.Padding(2);
            this.txtYayinevi.Name = "txtYayinevi";
            this.txtYayinevi.Size = new System.Drawing.Size(76, 20);
            this.txtYayinevi.TabIndex = 23;
            this.txtYayinevi.TextChanged += new System.EventHandler(this.txtYayinevi_TextChanged);
            // 
            // txtBasimYili
            // 
            this.txtBasimYili.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtBasimYili.Location = new System.Drawing.Point(433, 494);
            this.txtBasimYili.Margin = new System.Windows.Forms.Padding(2);
            this.txtBasimYili.Name = "txtBasimYili";
            this.txtBasimYili.Size = new System.Drawing.Size(76, 20);
            this.txtBasimYili.TabIndex = 24;
            // 
            // txtBaskıSayisi
            // 
            this.txtBaskıSayisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtBaskıSayisi.Location = new System.Drawing.Point(433, 567);
            this.txtBaskıSayisi.Margin = new System.Windows.Forms.Padding(2);
            this.txtBaskıSayisi.Name = "txtBaskıSayisi";
            this.txtBaskıSayisi.Size = new System.Drawing.Size(76, 20);
            this.txtBaskıSayisi.TabIndex = 25;
            // 
            // txtSayfaSayisi
            // 
            this.txtSayfaSayisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtSayfaSayisi.Location = new System.Drawing.Point(671, 422);
            this.txtSayfaSayisi.Margin = new System.Windows.Forms.Padding(2);
            this.txtSayfaSayisi.Name = "txtSayfaSayisi";
            this.txtSayfaSayisi.Size = new System.Drawing.Size(76, 20);
            this.txtSayfaSayisi.TabIndex = 26;
            // 
            // txtKonu
            // 
            this.txtKonu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtKonu.Location = new System.Drawing.Point(671, 519);
            this.txtKonu.Margin = new System.Windows.Forms.Padding(2);
            this.txtKonu.Multiline = true;
            this.txtKonu.Name = "txtKonu";
            this.txtKonu.Size = new System.Drawing.Size(76, 79);
            this.txtKonu.TabIndex = 27;
            // 
            // txtTür
            // 
            this.txtTür.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtTür.Location = new System.Drawing.Point(671, 468);
            this.txtTür.Margin = new System.Windows.Forms.Padding(2);
            this.txtTür.Name = "txtTür";
            this.txtTür.Size = new System.Drawing.Size(76, 20);
            this.txtTür.TabIndex = 28;
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnYeniKayit.Location = new System.Drawing.Point(839, 411);
            this.btnYeniKayit.Margin = new System.Windows.Forms.Padding(2);
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.Size = new System.Drawing.Size(114, 32);
            this.btnYeniKayit.TabIndex = 29;
            this.btnYeniKayit.Text = "YENİ KAYIT";
            this.btnYeniKayit.UseVisualStyleBackColor = false;
            this.btnYeniKayit.Click += new System.EventHandler(this.btnYeniKayit_Click);
            // 
            // btnKayitEkle
            // 
            this.btnKayitEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnKayitEkle.Location = new System.Drawing.Point(839, 482);
            this.btnKayitEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnKayitEkle.Name = "btnKayitEkle";
            this.btnKayitEkle.Size = new System.Drawing.Size(114, 32);
            this.btnKayitEkle.TabIndex = 30;
            this.btnKayitEkle.Text = "KAYIT EKLE";
            this.btnKayitEkle.UseVisualStyleBackColor = false;
            this.btnKayitEkle.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnKayitGüncelle
            // 
            this.btnKayitGüncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnKayitGüncelle.Location = new System.Drawing.Point(839, 555);
            this.btnKayitGüncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btnKayitGüncelle.Name = "btnKayitGüncelle";
            this.btnKayitGüncelle.Size = new System.Drawing.Size(114, 32);
            this.btnKayitGüncelle.TabIndex = 31;
            this.btnKayitGüncelle.Text = "KAYIT GÜNCELLE";
            this.btnKayitGüncelle.UseVisualStyleBackColor = false;
            this.btnKayitGüncelle.Click += new System.EventHandler(this.btnKayitGüncelle_Click);
            // 
            // frmYönetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(989, 609);
            this.Controls.Add(this.btnKayitGüncelle);
            this.Controls.Add(this.btnKayitEkle);
            this.Controls.Add(this.btnYeniKayit);
            this.Controls.Add(this.txtTür);
            this.Controls.Add(this.txtKonu);
            this.Controls.Add(this.txtSayfaSayisi);
            this.Controls.Add(this.txtBaskıSayisi);
            this.Controls.Add(this.txtBasimYili);
            this.Controls.Add(this.txtYayinevi);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.txtYazarAdi);
            this.Controls.Add(this.txtKitapAdi);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgKitapBilgileri);
            this.Controls.Add(this.btnKayitAra);
            this.Controls.Add(this.btnKayitSil);
            this.Controls.Add(this.txtAranacakKitap);
            this.Controls.Add(this.txtSilinecekKitap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBaslik);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmYönetici";
            this.Text = "SG KÜTÜPHANE SİSTEMİ";
            this.Load += new System.EventHandler(this.frmYönetici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgKitapBilgileri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSilinecekKitap;
        private System.Windows.Forms.TextBox txtAranacakKitap;
        private System.Windows.Forms.Button btnKayitSil;
        private System.Windows.Forms.Button btnKayitAra;
        private System.Windows.Forms.DataGridView dtgKitapBilgileri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.TextBox txtYazarAdi;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtYayinevi;
        private System.Windows.Forms.TextBox txtBasimYili;
        private System.Windows.Forms.TextBox txtBaskıSayisi;
        private System.Windows.Forms.TextBox txtSayfaSayisi;
        private System.Windows.Forms.TextBox txtKonu;
        private System.Windows.Forms.TextBox txtTür;
        private System.Windows.Forms.Button btnYeniKayit;
        private System.Windows.Forms.Button btnKayitEkle;
        private System.Windows.Forms.Button btnKayitGüncelle;
    }
}