using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.Instance();
            Singleton s2 = Singleton.Instance();

            if(s1 == s2)
            {
                Console.WriteLine("Both objects are same");
            }
            Console.ReadKey();
        }
    }
}
