using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class Task_Method
    {


        //public int Methodopertions(int a, int b, int c)
        // {
        //     if (c == 1)
        //     {
        //         int add = a + b;
        //         return add;
        //     }
        //     else if (c == 2)
        //     {
        //         int sub = a - b;
        //         return sub;
        //     }
        //     else if (c == 3)
        //     {
        //         int multiplication = a * b;
        //         return multiplication;
        //     }
        //     else if (c==4)
        //     {
        //         int div = a / b;
        //         return div;
        //     }
        //     return 0;

        // }
        public int Methodopertions2(int a, int b, int c)
        {
            int result = 0;


            result = (c == 1) ? (a + b) : ((c == 2) ? (a - b) : ((c == 3) ? (a * b) : (c == 4) ? (a / b) : 0));


            //switch (c)
            //{
            //    case 1:
            //        result = a + b;
            //        break;
            //    case 2:
            //        result = a - b;
            //        break;
            //    case 3:
            //        result = a * b;
            //        break;
            //    case 4:
            //        result = a / b;
            //        break;

            //}
            return result;

        }
        public void Consoleinput()
        {
            Console.WriteLine("Enter the operator");
            Console.WriteLine("1 for add");
            Console.WriteLine("2 for sub");
            Console.WriteLine("3 for multi");
            Console.WriteLine("4 for div");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a value");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b value");
            int b = Convert.ToInt32(Console.ReadLine());
            int result = 0;

            result = (c == 1) ? (a + b) : ((c == 2) ? (a - b) : ((c == 3) ? (a * b) : (c == 4) ? (a / b) : 0));

            Console.WriteLine(result);

            //Console.WriteLine("Do you want to continue");
            //Console.WriteLine("y or N");
            //string option = Convert.ToString(Console.ReadLine());

            



            //if (option == "y")
            //{
            //    Consoleinput();
            //}
            //else return;







            // switch (c)
            // {
            //     case 1:
            //         result = a + b;
            //           break;
            //     case 2:
            //         result = a - b;
            //          break;
            //     case 3:
            //         result = a * b;
            //         break;
            //     case 4:
            //         result = a / b;
            // break;

            //}


        }

        public void Even()
        {
            int i = 0;
          for (i = 0; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i+",");
                }
                else
                {
                    //Console.WriteLine(i+"is not odd number");
                }

                if (i % 2 == 0)
                {
                    Console.WriteLine(i + ",");
                }
                else
                {
                    //Console.WriteLine(i+"is not Even number");
                }

            }
        }


    }
}