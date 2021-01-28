using System;
using System.Collections.Generic;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            Console.WriteLine(sehirler.Count);
            //sehirler.Add("ankara");
            MyList<string> myList = new MyList<string>();
            //myList.Add("Denizli");
         
        }
        class MyList<T>
        {
            T[] _array;
            public MyList()
            {
                
                _array = new T[0];
            }

            public void Add(T item)
            {

            }
        }
    }
}
