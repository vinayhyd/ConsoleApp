using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class A4
    {
        int z;
        public void test4()
        {
            int b = 100, c = 20;
            int sol = Apple(b, c);

            Console.WriteLine(sol);

            int a = 1, spaces, k = 6,
                i = 0, j = 0;
            spaces = k - 1;
            for (i = 1; i < k * 2; i++)
            {
                for (j = 1; j <= spaces; j++)
                {
                    Console.Write("-");
                }
                for (j = 1; j < a * 2; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("#");
                if (i < k)
                {
                    spaces--;
                    a++;
                }
                else
                {
                    spaces++;
                    a--;
                }
            }
        }


        public int Apple(int a, int b)
        {
            int sol = a / b;
            return sol;
        }

    }
}
