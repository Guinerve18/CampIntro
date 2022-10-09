using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] agrs)
        {
            //string[] names = new string[] { "Boran", "Çın", "Ozan", "Aslan" };
            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);
            //Console.WriteLine(names[3]);

            //names = new string[5];
            //names[4] = "Mehmet";
            //Console.WriteLine(names[4]);
            //Console.WriteLine(names[0]);

            List<string> names2 = new List<string> { "Boran", "Çın", "Ozan", "Aslan" };
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            Console.WriteLine(names2[3]);
            names2.Add("Mehmet");
            Console.WriteLine(names2[4]);
            Console.WriteLine(names2[0]);


        }
    }
}