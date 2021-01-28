using System;
using System.Collections.Generic;
using System.Text;

namespace GenericIntro
{
    
    //Beynim errror verdi anlayana kadar.
    class MyList<T>
    {
        //Yazılan bilgileri tutmak için array lazım.
        //Arraylar newlenmezse hata verir newlememiz lazım.
        T[] items;
        //Constructor liste newlendiğinde çalışır bu yüzden items ı burada newledik
        public MyList()
        {
            //Sıfır elemanlı item arrayı yaptık.
            items = new T[0];
        }
        public void Add(T item)
        {
            //items newlendiğinde referans numarası kaybolur. eski kayıtlarda o numrada kalır. eski numarayı kaybetmemek için yazılır
            T[] tempArray = items;
            //Yeni bir item eklendiğinde yer açmak için kendinden 1 fazla elemanı olan  array oluştur.
            items = new T[items.Length+1];
            //Eski kayıtları geri getirmek için tempArrayın elemanlarını itemsın elemanlarına geçiririz.
            //Elimizde eski itemsden farklı olarak bir tane fazladan boşluklu array oluşur
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            //İtemsdaki boşluğa add ile eklenen eleman yerleşir.
            items[items.Length - 1] = item;
        }
        

    }
}
