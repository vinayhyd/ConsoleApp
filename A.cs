using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    static class A
    {
        static int a;

        // constructor 
        static A() 
        { 
        
        }   
        static void A1()
        {
            A2();
        }

        static void A2()
        {

        }
        public static void Test0()
        {
            Console.WriteLine("Test0");
        }

    }
}
