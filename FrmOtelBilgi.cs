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
    public partial class FrmOtelBilgi : Form
    {
        public FrmOtelBilgi()
        {
            InitializeComponent();
        }

        private void btnOtelBilgi_Click(object sender, EventArgs e)
        {

        }

        private void FrmOtelBilgi_Load(object sender, EventArgs e)
        {
          

        }

        private void btndeneme_Click(object sender, EventArgs e)
        {
            SQLVeriGetirme verigetir = new SQLVeriGetirme();

            List<Otel> oteller = new List<Otel>();

            İkiliAramaAgaci ikiliAramaAgaci = new İkiliAramaAgaci();

            oteller = verigetir.OtelBilgiGetir();

            for (int i = 0; i < oteller.Count; i++)
            {
                ikiliAramaAgaci.Ekle(oteller[i]);

            }

            List<Personel> personels = new List<Personel>();

            personels = verigetir.PersonelBilgiGetir();

            Otel tempOtel = new Otel();
            for (int i = 0; i < personels.Count; i++)
            {
                string otelIsmi = personels[i].CalistigiOtel;
                tempOtel = ikiliAramaAgaci.Ara(otelIsmi).otel;
                tempOtel.PersonelHead.InsertLast(personels[i]);
            }
            List<OtelYorum> otelyorumları = new List<OtelYorum>();

            otelyorumları = verigetir.OtelYorumGetir();

            for (int i = 0; i < otelyorumları.Count; i++)
            {
                string otelIsmi = otelyorumları[i].YorumlananOtel;
                tempOtel = ikiliAramaAgaci.Ara(otelIsmi).otel;

                tempOtel.OtelYorumHead.InsertLast(otelyorumları[i]);

            }

            //HashZincirleme hashZincirleme = new HashZincirleme();

            /*for (int i = 0; i < oteller.Count; i++)
            {
                hashZincirleme.OtelEkle(oteller[i].plakaKodu, oteller[i]);
            }*/

            
            
            //Veritabanına eklemek için.
           /* ikiliAramaAgaci.InOrder();
            ikiliAramaAgaci.DugumleriYazdir();*/
        }
    }
}
