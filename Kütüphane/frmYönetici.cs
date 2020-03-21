using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; //Veritabanı bağlantı kütüphanesi

namespace Kütüphane
{
    public partial class frmYönetici : Form
    {
        public frmYönetici()
        {
            InitializeComponent();
        }

        //Veri Tabanı Değişkenlerini Tanımlama Bölümü

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kutuphane.accdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbDataAdapter adaptor = new OleDbDataAdapter();

        DataSet tasima = new DataSet();


        void listele()  //DataGridWiev de kayıtları listeleme bölümü
        {
            baglanti.Open();
            OleDbDataAdapter adaptor = new OleDbDataAdapter("Select * from kitap", baglanti); //Veritabanımızda kitap isimli tablodan bilgilerimiz listelenecek.
            adaptor.Fill(tasima, "kitap");
            dtgKitapBilgileri.DataSource = tasima.Tables["kitap"];
            adaptor.Dispose();
            baglanti.Close();
        }

        private void frmYönetici_Load(object sender, EventArgs e)
        {
            listele(); //Programımızı çalıştırdığımız anda veritabanında kayıtlı olan kitap bilgilerimiz karşıma gelecek.
        }

        private void btnYeniKayit_Click(object sender, EventArgs e) //Yeni kayıt ekleme bölümü
        {
            txtID.Text = "";
            txtKitapAdi.Text = "";
            txtYazarAdi.Text = "";
            txtISBN.Text = "";
            txtYayinevi.Text = "";
            txtBasimYili.Text = "";
            txtBaskıSayisi.Text = "";
            txtSayfaSayisi.Text = "";
            txtTür.Text = "";
            txtKonu.Text = "";
        }

        private void button2_Click(object sender, EventArgs e) //Kayıt Ekleme Bölümü
        {
            if (txtKitapAdi.Text != "" && txtYazarAdi.Text != "" && txtISBN.Text != "" && txtYayinevi.Text != "" && txtBasimYili.Text != "" && txtBaskıSayisi.Text != "" && txtSayfaSayisi.Text != "" && txtKonu.Text != "" && txtTür.Text != "")
            {
                komut.Connection = baglanti;
                komut.CommandText = "Insert Into kitap(k_adi, k_yazari, k_isbn, k_yayinevi, k_basimyili, k_baski, k_sayfasayisi, k_turu, k_konu) Values ('" + txtKitapAdi.Text + "','" + txtYazarAdi.Text + "','" + txtISBN.Text + "','" + txtYayinevi.Text + "','" + txtBasimYili.Text + "','" + txtBaskıSayisi.Text + "','" + txtSayfaSayisi.Text + "','" + txtTür.Text + "','" + txtKonu.Text + "')";
                baglanti.Open();
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                MessageBox.Show("Kayıt Tamamlandı!");
                tasima.Clear();
                listele();
            }

            else
            {
                MessageBox.Show("Boş alan bırakmayınız!");
            }

        }

        private void btnKayitGüncelle_Click(object sender, EventArgs e) //Kayıt Güncelleme Bölümü
        {
            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "update kitap set k_adi='" + txtKitapAdi.Text + "',k_yazari='" + txtYazarAdi.Text + "',k_yayinevi='" + txtYayinevi.Text + "',k_basimyili='" + txtBasimYili.Text + "',k_baski='" + txtBaskıSayisi.Text + "',k_sayfasayisi='" + txtSayfaSayisi.Text + "',k_konu='" + txtKonu.Text + "',k_turu='" + txtTür.Text + "'  where k_id =" + txtID.Text + "";
            komut.ExecuteNonQuery();
            baglanti.Close();
            tasima.Clear();
            listele();
        }

        private void btnKayitAra_Click(object sender, EventArgs e) //Kayıt Arama Bölümü
        {
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=kutuphane.accdb");
            adaptor = new OleDbDataAdapter("Select * from kitap where k_adi like '%" + txtAranacakKitap.Text + "%'", baglanti);
            tasima = new DataSet();
            baglanti.Open();
            adaptor.Fill(tasima, "kitap");
            dtgKitapBilgileri.DataSource = tasima.Tables["kitap"];
            baglanti.Close();

            //Bulunan kayıt textboxlara atanarak gösteriliyor.
            txtID.Text = dtgKitapBilgileri.CurrentRow.Cells[0].Value.ToString();
            txtKitapAdi.Text = dtgKitapBilgileri.CurrentRow.Cells[1].Value.ToString();
            txtYazarAdi.Text = dtgKitapBilgileri.CurrentRow.Cells[2].Value.ToString();
            txtISBN.Text = dtgKitapBilgileri.CurrentRow.Cells[3].Value.ToString();
            txtYayinevi.Text = dtgKitapBilgileri.CurrentRow.Cells[4].Value.ToString();
            txtBasimYili.Text = dtgKitapBilgileri.CurrentRow.Cells[5].Value.ToString();
            txtBaskıSayisi.Text = dtgKitapBilgileri.CurrentRow.Cells[6].Value.ToString();
            txtSayfaSayisi.Text = dtgKitapBilgileri.CurrentRow.Cells[7].Value.ToString();
            txtTür.Text = dtgKitapBilgileri.CurrentRow.Cells[8].Value.ToString();
            txtKonu.Text = dtgKitapBilgileri.CurrentRow.Cells[9].Value.ToString();

        }

        private void btnKayitSil_Click(object sender, EventArgs e) //Kayıt Silme Bölümü
        {
            DialogResult c;
            c = MessageBox.Show("Silmek istediğinizden emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (c == DialogResult.Yes)
            {
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "Delete from kitap where k_adi=" + txtSilinecekKitap.Text + "";
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                tasima.Clear();
                listele();
            }
        }

        private void dtgKitapBilgileri_CellClick(object sender, DataGridViewCellEventArgs e) //DataGridView üzerinde tıklanan kaydın ekranda gösterilmesi
        {

        }

        private void dtgKitapBilgileri_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dtgKitapBilgileri.CurrentRow.Cells[0].Value.ToString();
            txtKitapAdi.Text = dtgKitapBilgileri.CurrentRow.Cells[1].Value.ToString();
            txtYazarAdi.Text = dtgKitapBilgileri.CurrentRow.Cells[2].Value.ToString();
            txtISBN.Text = dtgKitapBilgileri.CurrentRow.Cells[3].Value.ToString();
            txtYayinevi.Text = dtgKitapBilgileri.CurrentRow.Cells[4].Value.ToString();
            txtBasimYili.Text = dtgKitapBilgileri.CurrentRow.Cells[5].Value.ToString();
            txtBaskıSayisi.Text = dtgKitapBilgileri.CurrentRow.Cells[6].Value.ToString();
            txtSayfaSayisi.Text = dtgKitapBilgileri.CurrentRow.Cells[7].Value.ToString();
            txtTür.Text = dtgKitapBilgileri.CurrentRow.Cells[8].Value.ToString();
            txtKonu.Text = dtgKitapBilgileri.CurrentRow.Cells[9].Value.ToString();
        }

        private void frmYönetici_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Burada yapmak istediğimiz formumuz kapatdan (x tuşudan) kapattığımızda Uygulamamız kapansın diyoruz 
            Application.Exit();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dtgKitapBilgileri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtYayinevi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtAranacakKitap_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblBaslik_Click(object sender, EventArgs e)
        {

        }
    }
}
