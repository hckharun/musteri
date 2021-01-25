using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri = new Musteri
            {
                Id = 5,
                adıSoyadı = "ali veli",
                doğumYeri="mars",
                telNo= "0555555555",

                
            };



            MusteriManager ekle = new MusteriManager ();
            ekle.MusteriListele(musteri);
            ekle.MusteriEkle(musteri);
            ekle.MusteriSil(musteri);
           
        }
        


    }
}
