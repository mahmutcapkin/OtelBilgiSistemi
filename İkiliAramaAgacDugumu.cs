using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelBilgiSistemi
{
    public class İkiliAramaAgacDugumu
    {
        public Otel otel;
        public İkiliAramaAgacDugumu sol;
        public İkiliAramaAgacDugumu sag;
        public İkiliAramaAgacDugumu()
        {
        }

        public İkiliAramaAgacDugumu(Otel otel)
        {
            this.otel = otel;
            sol = null;
            sag = null;
        }
    }
}
