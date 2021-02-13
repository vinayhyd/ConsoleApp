﻿using System;

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
            //A2 c = new A2();
            //c.Test1(6, 5, 1, 2, 6);
            //A3 c1 = new A3();
            //c1.a = 5;
            //c1.b = 10;
            //c1.c = 6;
            //c1.e = 6;
            //c1.f = 6;

            //c.Test2(c1);
        }

        private static void LoopsArrays()
        {
            int[] c = new int[4] { 6, 4, 1, 2 };
            Console.WriteLine(c.Length);
            Array.Sort(c);
            for (int i = 0; i < c.Length; ++i)
            {
                Console.WriteLine(c[i]);
            }

            for (int i = c.Length; i > 0; i--)
            {
                Console.WriteLine(c[i]);
            }

            foreach (var item in c)
            {
                Console.WriteLine(item);
            }

            int[] a = new int[4];
            a[0] = 0;
            a[1] = 1;
            a[2] = 2;
            a[3] = 3;
            //a[4] = 3; Run time exception
            //a[5] = 3;

            int[] b = { 10, 20, 30, 40 };
            Console.WriteLine(b[4]);
        }

        private static void SwitchOperation()
        {
            string a = "2";
            switch (a)
            {
                case "1":
                    Console.WriteLine("1");
                    break;
                case "2":
                    Console.WriteLine("2");
                    break;
                default:
                    Console.WriteLine("default");
                    break;
            }
        }

        public void IfConditions(int a, int b)
        {

            // 5
            string c = (a != b) ? ((a > b) ? "a is gre" : " LESSE") : "a is eequls";
            Console.WriteLine(c);

            //((a == b) ? (Console.WriteLine("a is equal to b ")) : (a > b ? Console.WriteLine("a is greater than b") : Console.WriteLine("a is lesser than b")));

            // 4
            if (a == b)
            {
                Console.WriteLine("a is equal is b");
            }
            else
            {
                if (a > b)
                {
                    Console.WriteLine("a is greater then b");
                }
                else
                {
                    Console.WriteLine("b is graear than a ");
                }
            }
            // Third
            if (a != b)
            {
                if (a > b)
                {
                    Console.WriteLine("a is greater then b");
                }
                else
                {
                    Console.WriteLine("a is less then b");
                }
            }
            else
            {
                Console.WriteLine("a is equal is b");
            }

            //second
            if (a == b)
            {
                Console.WriteLine("a is equal is b");
            }
            if (a > b)
            {
                Console.WriteLine("a is greater then b");
            }
            if (a < b)
            {
                Console.WriteLine("a is less then b");
            }

            // First
            if (a == b)
            {
                Console.WriteLine("a is equal is b");
            }
            else if (a > b)
            {
                Console.WriteLine("a is greater then b");
            }
            else
            {
                Console.WriteLine("b is graear than a ");
            }
        }
    }
}
