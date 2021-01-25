using System;
using System.Collections.Generic;
using System.Text;

namespace YazilimTemel
{
    class SepetManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Sepete Eklendi :"+ product.Adi);
        }
        public void Add2(string productName,string explanation, double price, int stokadedi)
        {
            Console.WriteLine("Sepete Eklendi :" + productName);

        }

    }
}
