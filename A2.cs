using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class A2
    {
        public void Test1(int a, int b, int c,int e,int f)
        {

            //A4 z = new A4();
            //z.Apple();

            A5.Testfor();

            string d= (a != b) ? ((a > b) ? "a is gre" : " LESSE") : "a is eequls";
            Console.WriteLine(d);
        }

        public void Test2(A3 cl)
        {
            string d = (cl.a != cl.b) ? ((cl.a > cl.b) ? "a is gre" : " LESSE") : "a is eequls";
            Console.WriteLine(d);
        }

        public int Test3()
        {
            Console.WriteLine("IN Test2");
            return 6;
        }


    }
}
