using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    internal class Class1
    {
        //h iam vrushali joshi muley

        //lkdklbndfb;flk;llftthkdlglkh;ddtjdgjgdddgjgjer;gggssgrgf

        public static void Display<T>(T[] test)
        {


            for (int i = 0; i < test.Length; i++)
            {
                Console.Write(test[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
