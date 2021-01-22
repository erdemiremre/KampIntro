using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Ali");
            myDictionary.Add(2, "Veli");
            myDictionary.Add(3, "Kerem");

            foreach (var item in myDictionary.Values)
            {
                Console.WriteLine(item);
            }

        }
    }
}
