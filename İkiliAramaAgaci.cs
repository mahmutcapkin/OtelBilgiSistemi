using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelBilgiSistemi
{
    public class İkiliAramaAgaci
    {
        private İkiliAramaAgacDugumu kok;
        
        private string dugumler;
        public İkiliAramaAgaci()
        {
        }
        public İkiliAramaAgaci(İkiliAramaAgacDugumu kok)
        {
            this.kok = kok;
        }
        public int DugumSayisi()
        {
            return DugumSayisi(kok);
        }
        public int DugumSayisi(İkiliAramaAgacDugumu dugum)
        {
            int count = 0;
            if (dugum != null)
            {
                count = 1;
                count += DugumSayisi(dugum.sol);
                count += DugumSayisi(dugum.sag);
            }
            return count;
        }

        public string DugumleriYazdir()
        {
            return dugumler;
        }
        public void PreOrder()
        {
            dugumler = "";
            PreOrderInt(kok);
        }
        private void PreOrderInt(İkiliAramaAgacDugumu dugum)
        {
            if (dugum == null)
                return;
            Ziyaret(dugum);
            PreOrderInt(dugum.sol);
            PreOrderInt(dugum.sag);
        }
        public void InOrder()
        {
            dugumler = "";
            InOrderInt(kok);
        }
        private void InOrderInt(İkiliAramaAgacDugumu dugum)
        {
            if (dugum == null)
                return;
            InOrderInt(dugum.sol);
            Ziyaret(dugum);
            InOrderInt(dugum.sag);
        }
        private void Ziyaret(İkiliAramaAgacDugumu dugum)
        {
            dugumler += dugum.otel + " ";
        }
        public void PostOrder()
        {
            dugumler = "";
            PostOrderInt(kok);
        }
        private void PostOrderInt(İkiliAramaAgacDugumu dugum)
        {
            if (dugum == null)
                return;
            PostOrderInt(dugum.sol);
            PostOrderInt(dugum.sag);
            Ziyaret(dugum);
        }
        public void Ekle(Otel otel)
        {
            
            //Yeni eklenecek düğümün parent'ı
            İkiliAramaAgacDugumu tempParent = new İkiliAramaAgacDugumu();
            //Kökten başla ve ilerle

            İkiliAramaAgacDugumu tempSearch = kok;
            // BURAYA DİKKAT ET HATA BURDAN CIKMIS OLABLİİR
            while (tempSearch != null)
            {
                tempParent = tempSearch;
                
                //Deger zaten var, çık.
                if (otel == tempSearch.otel)
                    return;
                else if (string.Compare(otel.OtelAd ,tempSearch.otel.OtelAd) == -1)
                    tempSearch = tempSearch.sol;
                else
                    tempSearch = tempSearch.sag;
            }
            İkiliAramaAgacDugumu eklenecek = new İkiliAramaAgacDugumu(otel);
            //Ağaç boş, köke ekle

            if (kok == null)
            {
                kok = eklenecek;
            }
            else if (string.Compare(otel.OtelAd, tempParent.otel.OtelAd) == -1)
            {

                tempParent.sol = eklenecek;
            }
            else
                tempParent.sag = eklenecek;

        }

        public İkiliAramaAgacDugumu Ara(string otelad)
        {
            return AraInt(kok,otelad);
        }// BURAYA DİKKAT ET HATA BURDAN CIKMIS OLABLİİR
        private İkiliAramaAgacDugumu AraInt(İkiliAramaAgacDugumu dugum,
                                            string otelad)
        {
            if (dugum == null)
                return null;
            else if (string.Compare(dugum.otel.OtelAd, otelad) == 0)
                return dugum;
            else if (string.Compare(otelad, dugum.otel.OtelAd) ==-1)
                return (AraInt(dugum.sol, otelad));
            else
                return (AraInt(dugum.sag, otelad));
        }
        /*
        public İkiliAramaAgacDugumu MinDeger()
        {
            İkiliAramaAgacDugumu tempSol = kok;
            while (tempSol.sol != null)
                tempSol = tempSol.sol;
            return tempSol;
        }

        public İkiliAramaAgacDugumu MaksDeger()
        {
            İkiliAramaAgacDugumu tempSag = kok;
            while (tempSag.sag != null)
                tempSag = tempSag.sag;
            return tempSag;
        }
        */

        private İkiliAramaAgacDugumu Successor(İkiliAramaAgacDugumu silDugum)
        {
            İkiliAramaAgacDugumu successorParent = silDugum;
            İkiliAramaAgacDugumu successor = silDugum;
            İkiliAramaAgacDugumu current = silDugum.sag;
            while (current != null)
            {
                successorParent = successor;
                successor = current;
                current = current.sol;
            }
            if (successor != silDugum.sag)
            {
                successorParent.sol = successor.sag;
                successor.sag = silDugum.sag;
            }
            return successor;
        }
        public bool Sil(string silAd)
        {
            İkiliAramaAgacDugumu current = kok;
            İkiliAramaAgacDugumu parent = kok;
            bool issol = true;
            //DÜĞÜMÜ BUL       // BURAYA DİKKAT ET HATA BURDAN CIKMIS OLABLİİR
            while (string.Compare(current.otel.OtelAd,silAd)!=0)   
            {
                parent = current;
                if (string.Compare(current.otel.OtelAd, silAd)==-1)
                {
                    issol = true;
                    current = current.sol;
                }
                else if(string.Compare(current.otel.OtelAd, silAd) == 1)
                {
                    issol = false;
                    current = current.sag;
                }


                if (current == null)
                    return false;
            }
            //DURUM 1: YAPRAK DÜĞÜM
            if (current.sol == null && current.sag == null)
            {
                if (current == kok)
                    kok = null;
                else if (issol)
                    parent.sol = null;
                else
                    parent.sag = null;
            }
            //DURUM 2: TEK ÇOCUKLU DÜĞÜM
            else if (current.sag == null)
            {
                if (current == kok)
                    kok = current.sol;
                else if (issol)
                    parent.sol = current.sol;
                else
                    parent.sag = current.sol;
            }
            else if (current.sol == null)
            {
                if (current == kok)
                    kok = current.sag;
                else if (issol)
                    parent.sol = current.sag;
                else
                    parent.sag = current.sag;
            }
            //DURUM 3: İKİ ÇOCUKLU DÜĞÜM
            else
            {
                İkiliAramaAgacDugumu successor = Successor(current);
                if (current == kok)
                    kok = successor;
                else if (issol)
                    parent.sol = successor;
                else
                    parent.sag = successor;
                successor.sol = current.sol;
            }
            return true;
        }
    }
}
