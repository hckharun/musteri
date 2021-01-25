using System;

namespace YazilimTemel
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.Adi = "Masa";
            product1.Fiyati =250 ;
            product1.Aciklama = "Çalışma Masası";
            
            Product product2 = new Product();
            product2.Id = 2;
            product2.Adi = "araba";
            product2.Fiyati = 25550;
            product2.Aciklama = "Ford";

            Product[] products = new Product[] {product1,product2 };

            foreach (var product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("-------------");
            }

            Console.WriteLine("--------METOTLAR----------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add2("karpuz","asdasddsa",6,4);
            
        }
    }
}
