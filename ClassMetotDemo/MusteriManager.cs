using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri )
        {
            Console.WriteLine(musteri.adıSoyadı+" sisteme eklendi.");
        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.adıSoyadı+" sistemden kaldırıldı.");
        }
        public void MusteriListele(Musteri musteri)
        {
            Console.WriteLine("Adı Soyadı: "+musteri.adıSoyadı+Environment.NewLine+
                "Doğum Yeri: "+musteri.doğumYeri+ Environment.NewLine +
               "Id: "+ musteri.Id+ Environment.NewLine +
                "İletişim: "+musteri.telNo+ Environment.NewLine + "------------------------");
        }


   
    
    }
}   
