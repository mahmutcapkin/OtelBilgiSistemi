using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelBilgiSistemi
{
    public class LinkedHashEntry
    {
        private int plakaKodu;

        private Otel otel;

        private LinkedHashEntry next;

        public Otel Deger
        {
            get { return otel; }
            set { otel = value; }
        }
        public int Anahtar
        {
            get { return plakaKodu; }
            set { plakaKodu = value; }
        }


        public LinkedHashEntry Next
        {
            get { return next; }
            set { next = value; }
        }

        public LinkedHashEntry(int anahtar,Otel otel)
        {
            this.plakaKodu = anahtar;
            this.otel = otel;
            this.next = null;
        }
    }
}
