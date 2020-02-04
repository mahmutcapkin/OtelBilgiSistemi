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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click_1(object sender, EventArgs e)
        {
            if(rdbUye.Checked==true)
            {
                GirisServisi giris = new GirisServisi();
                bool kontrol=giris.KullaniciUyeDogrula(txtMail.Text, txtSifre.Text);
                if (kontrol == true)
                {
                    FrmAnaSayfa anasayfa = new FrmAnaSayfa();
                    anasayfa.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı Kullanıcı Adı veya Sifre!");
                }
            }
            else if (rdbYetkili.Checked==true)
            {
                if ((txtMail.Text=="admin")&&(txtSifre.Text=="admin"))
                {
                    FrmYetkili yetkili = new FrmYetkili();
                    yetkili.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı Kullanıcı Adı veya Sifre!");
                }
            }
            else
            {
                MessageBox.Show("Giris Tipinizi Seçiniz");
            }
        }
        
        private void btnKayıtOl_Click(object sender, EventArgs e)
        {
            FrmKayitOl kayit = new FrmKayitOl();
            kayit.Show();
            FrmGiris giris = new FrmGiris();
            giris.Hide();
        }
    }
}
