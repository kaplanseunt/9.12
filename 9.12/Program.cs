using System;
using System.Collections.Generic;

namespace _9._12
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string,int> myDictionary = new Dictionary<string, int>();
            myDictionary.Add("Taha", 23);
            myDictionary.Add("Jack", 27);

            foreach (var item in myDictionary)
            {
                Console.WriteLine(item);
            }


            var eleman = myDictionary.Count;
            Console.WriteLine();
            Console.WriteLine("eleman sayisi:" +eleman);
            Console.WriteLine(" ");

            myDictionary.Remove("Jack");
            foreach (var item in myDictionary)
            {
                Console.WriteLine(item);
            }
        }
    }
}
