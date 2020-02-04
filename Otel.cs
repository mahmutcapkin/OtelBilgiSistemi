using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelBilgiSistemi
{
    public class Otel
    {
        public string OtelAd { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Adres { get; set; }
        public string Eposta { get; set; }
        public string Telefon { get; set; }
        public int YildizSayisi { get; set; }
        public int OdaSayisi { get; set; }
        public string OtelPuani { get; set; }
        //public List<Personel> personel;
        //  public List<OtelYorum> otelyorum;
        public LinkedListPersonel PersonelHead = new LinkedListPersonel();
        public LinkedListYorum OtelYorumHead = new LinkedListYorum();


    }
}
