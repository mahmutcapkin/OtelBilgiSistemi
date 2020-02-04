using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelBilgiSistemi
{
    public partial class FrmKayitOl : Form
    {
        public FrmKayitOl()
        {
            InitializeComponent();
        }
        Musteri musteri = new Musteri();
        private  void btnKaydol_Click(object sender, EventArgs e)
        {
            musteri.Ad = txtAd.Text;
            musteri.Soyad = txtSoyad.Text;
            musteri.Mail = txtMail.Text;
            musteri.Telefon = mskTelefon.Text;
            musteri.Sifre = txtKsifre.Text;
            musteri.KisiEkle();
            MessageBox.Show("Yeni Üye Eklendi...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }
    }
}
