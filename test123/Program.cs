using System;
using System.Net;

namespace test123
{
    class Program
    {
        static void Main(string[] args)
        {
            long i = 5;
            object o = i;
            long l = (long)o;
            Console.Write(l);
            Console.ReadKey();
        }
    }
}
