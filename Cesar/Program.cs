using System;

namespace Cesar
{
    class Program
    {
        static void Main(string[] args)
        {
            string forCod;
            CodesProccesor proc = new CodesProccesor();
            Console.WriteLine("Enter to encode");
            forCod = Console.ReadLine();
            forCod = proc.Encode(forCod);
            Console.WriteLine(forCod);
            Console.WriteLine("and back");
            forCod = proc.Decode(forCod);
            Console.WriteLine(forCod);
        }
    }
}
