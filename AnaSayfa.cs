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
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmGiris frm = new FrmGiris();
            frm.MdiParent = this;
            frm.Show();
        }

        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {

        }
        FrmOtelBilgi otelbilgi;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(otelbilgi==null)
            {
                otelbilgi = new FrmOtelBilgi();
                otelbilgi.MdiParent = this;
                otelbilgi.Show();

            }
            

        }
        FrmOtelListele OtelListele;
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if (OtelListele == null)
            {
                OtelListele = new FrmOtelListele();
                OtelListele.MdiParent = this;
                OtelListele.Show();
            }

        }
        FrmDegerlendirme Degerlendirme;
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if (Degerlendirme == null)
            {
                Degerlendirme = new FrmDegerlendirme();

                Degerlendirme.MdiParent = this;
                Degerlendirme.Show();
            }
        }
        FrmTumOteller TumOteller;
        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TumOteller == null)
            {
                TumOteller = new FrmTumOteller();
                TumOteller.MdiParent = this;
                TumOteller.Show();
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();

        }
    }
}
