﻿using System;
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


            result = (c == 1) ? (a + b) : ((c==2)?(a-b):((c==3)?(a*b):(c==4)?(a/b):0));


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
    }
}