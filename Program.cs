using System;

namespace ConsoleApp
{
    class Program
    {
        Program()
        {
            Console.WriteLine("con");
        }
        static void Main(string[] args)
        {
            A2 c = new A2();
            c.Test1(6, 5, 1, 2,6);


            A3 c1 = new A3();
            c1.a = 5;
            c1.b = 10;
            c1.c = 6;
            c1.e = 6;
            c1.f = 6;

            c.Test3(c1);
        }
    }
}
