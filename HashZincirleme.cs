using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelBilgiSistemi
{
    public class HashZincirleme
    {
        int TABLE_SIZE = 81;

        LinkedHashEntry[] table;

        public HashZincirleme()
        {
            table = new LinkedHashEntry[TABLE_SIZE];
            for (int i = 0; i < TABLE_SIZE; i++)
                table[i] = null;
        }

        public void OtelEkle(int plakaKodu, Otel otel)
        {
            int hash = plakaKodu - 1;
            if (table[hash] == null)
                table[hash] = new LinkedHashEntry(plakaKodu, otel);
            else
            {
                LinkedHashEntry entry = table[hash];
                while (entry.Next != null && entry.Anahtar != plakaKodu)
                    entry = entry.Next;
                if (entry.Anahtar == plakaKodu)
                    entry.Deger = otel;
                else
                    entry.Next = new LinkedHashEntry(plakaKodu, otel);


            }
        }
        public List<Otel> IlOtelleri(int plakaKodu)
        {
            List<Otel> hotels = new List<Otel>();
            int hash = plakaKodu -1;
            if (table[hash] == null)
                return null;
            else
            {
                LinkedHashEntry entry = table[hash];
                while (entry != null && entry.Anahtar != plakaKodu)
                {
                    hotels.Add(entry.Deger);
                    entry = entry.Next;
                }


            }

            return hotels;
        }

        public List<Otel> IlIlceOtelleri(int plakaKodu, string ilceAdi)
        {
            List<Otel> hotels = new List<Otel>();
            int hash = plakaKodu - 1;
            if (table[hash] == null)
                return null;
            else
            {
                LinkedHashEntry entry = table[hash];
                while (entry != null && entry.Anahtar != plakaKodu)
                {
                    if (entry.Deger.Ilce == ilceAdi)
                    {
                        hotels.Add(entry.Deger);
                        entry = entry.Next;
                    }
                }
            }
            return hotels;
        }

        public List<Otel> IlOtelleriPuanli(int plakaKodu)
        {
            List<Otel> hotels = new List<Otel>();
            int hash = plakaKodu - 1;
            if (table[hash] == null)
                return null;
            else
            {
                LinkedHashEntry entry = table[hash];
                while (entry != null && entry.Anahtar != plakaKodu)
                {
                    hotels.Add(entry.Deger);
                    entry = entry.Next;
                }


            }

            HeapPuan heapPuan = new HeapPuan(hotels.Count);

            for (int i = 0; i < hotels.Count; i++)
            {
                heapPuan.Insert(hotels[i]);
            }


            return heapPuan.siralanmisGetir();

        }

        public List<Otel> IlIlceOtelleriPuanli(int plakaKodu, string ilceAdi)
        {
            List<Otel> hotels = new List<Otel>();
            int hash = plakaKodu - 1;
            if (table[hash] == null)
                return null;
            else
            {
                LinkedHashEntry entry = table[hash];
                while (entry != null && entry.Anahtar != plakaKodu)
                {
                    if (entry.Deger.Ilce == ilceAdi)
                    {
                        hotels.Add(entry.Deger);
                        entry = entry.Next;
                    }
                }
            }

            HeapPuan heapPuan = new HeapPuan(hotels.Count);

            for (int i = 0; i < hotels.Count; i++)
            {
                heapPuan.Insert(hotels[i]);
            }


            return heapPuan.siralanmisGetir();

        }

        public List<Otel> IlOtelleriYildizli(int plakaKodu)
        {
            List<Otel> hotels = new List<Otel>();
            int hash = plakaKodu - 1;
            if (table[hash] == null)
                return null;
            else
            {
                LinkedHashEntry entry = table[hash];
                while (entry != null && entry.Anahtar != plakaKodu)
                {
                    hotels.Add(entry.Deger);
                    entry = entry.Next;
                }


            }

            HeapYildiz heapYildiz = new HeapYildiz(hotels.Count);

            for (int i = 0; i < hotels.Count; i++)
            {
                heapYildiz.Insert(hotels[i]);
            }


            return heapYildiz.siralanmisGetir();


        }

        public List<Otel> IlIlceOtelleriYildizli(int plakaKodu, string ilceAdi)
        {
            List<Otel> hotels = new List<Otel>();
            int hash = plakaKodu - 1;
            if (table[hash] == null)
                return null;
            else
            {
                LinkedHashEntry entry = table[hash];
                while (entry != null && entry.Anahtar != plakaKodu)
                {
                    if (entry.Deger.Ilce == ilceAdi)
                    {
                        hotels.Add(entry.Deger);
                        entry = entry.Next;
                    }
                }
            }

            HeapYildiz heapYildiz = new HeapYildiz(hotels.Count);

            for (int i = 0; i < hotels.Count; i++)
            {
                heapYildiz.Insert(hotels[i]);
            }


            return heapYildiz.siralanmisGetir();

        }

    }
}
