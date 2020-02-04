using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace OtelBilgiSistemi
{
    
        public class SQLVeriGetirme
        {
            SqlConnection _baglanti = new SqlConnection(@"Data Source=DESKTOP-H28HIJ5\SQLEXPRESS;Initial Catalog=OtelBilgiSistemi;Integrated Security=True");
            List<Otel> Oteller = new List<Otel>();
            List<Personel> Personeller = new List<Personel>();
            List<OtelYorum> OtelYorumlar = new List<OtelYorum>();

            public List<Otel> OtelBilgiGetir()
            {

                if (_baglanti.State == ConnectionState.Closed)
                {
                    _baglanti.Open();
                }
                SqlCommand command = new SqlCommand("SELECT * FROM OtelBilgi", _baglanti);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                Otel otel = new Otel
                {
                    OtelAd = reader["OtelAd"].ToString(),
                    Il = reader["il"].ToString(),
                    Ilce = reader["ilce"].ToString(),
                    Adres = reader["Adres"].ToString(),
                    Telefon = reader["Telefon"].ToString(),
                    Eposta = reader["Eposta"].ToString(),
                    YildizSayisi = Convert.ToInt32(reader["YildizSayisi"]),
                    OdaSayisi = Convert.ToInt32(reader["OdaSayisi"]),
                    OtelPuani = reader["OtelPuani"].ToString(),
                    };
                    Oteller.Add(otel);
                }
                reader.Close();
                _baglanti.Close();
                return Oteller;
            }
            public List<Personel> PersonelBilgiGetir()
            {


                if (_baglanti.State == ConnectionState.Closed)
                {
                    _baglanti.Open();
                }
                SqlCommand command = new SqlCommand("SELECT * FROM PersonelBilgi", _baglanti);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Personel personel = new Personel
                    {
                        TC = reader["TcNo"].ToString(),
                        PerAd = reader["Ad"].ToString(),
                        PerSoyad = reader["Soyad"].ToString(),
                        PerAdres = reader["Adres"].ToString(),
                        PerTelefon = reader["Telefon"].ToString(),
                        PerEposta = reader["Eposta"].ToString(),
                        Departman = reader["Departman"].ToString(),
                        Pozisyon = reader["Pozisyon"].ToString(),
                        PersonelPuani = reader["PersonelPuani"].ToString(),
                        CalistigiOtel = reader["CalistigiOtel"].ToString(),
                    };
                    Personeller.Add(personel);
                }
                reader.Close();
                _baglanti.Close();
                return Personeller;
            }
            public List<OtelYorum> OtelYorumGetir()
            {
                if (_baglanti.State == ConnectionState.Closed)
                {
                    _baglanti.Open();
                }
                SqlCommand command = new SqlCommand("SELECT* From OtelDegerlendirme", _baglanti);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    OtelYorum otelyorum = new OtelYorum
                    {
                        YorumcuEposta = reader["YorumYapan"].ToString(),
                        YorumMetni = reader["Yorumu"].ToString(),
                        YorumcuPuan = reader["OtelPuanı"].ToString(),
                        YorumlananOtel= reader["OtelAdı"].ToString(),
                    };
                    OtelYorumlar.Add(otelyorum);
                }
                reader.Close();
                _baglanti.Close();
                return OtelYorumlar;
            }
        }
}

