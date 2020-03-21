using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //Bu kod satırında giriş butonuna basıldığı zaman Form1 kapanıp frmYönetici sayfasına geçiş yapılacaktır.
        {
            string kullaniciadi;
            string sifre;

            kullaniciadi = txtKullaniciGiris.Text;
            sifre = txtSifre.Text;

            if (kullaniciadi == "seyda" && sifre == "1234")
            {
                this.Hide(); //Açık olan From1 sayfası gizlenir.

                frmYönetici frm = new frmYönetici(); //frmYönetici isimli form sayfasından nesne oluşturuldu.
                frm.Show(); //frmYöneticiden oluşturulan nesne kullanılarak frmYönetici isimli formumuz gözükür. Kısacası formlar arası geçiş yapılır.
            }
            else
            {
                MessageBox.Show("YANLIŞ KULLANICI ADI VE/VEYA ŞİFRE GİRDİNİZ");
            } 
        }

       
        private void frmGiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Burada yapmak istediğimiz formumuz kapatdan (x tuşudan) kapattığımızda Uygulamamız kapansın diyoruz 
            Application.Exit();
        }

        private void frmGiris_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblBaslik_Click(object sender, EventArgs e)
        {

        }
    }
}
