using System;

namespace ConsoleApp_Params
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello I Was Params Test !");

            Console.WriteLine(SumVals(1, 2, 3, 4, 5, 6, 7, 8, 9));

            Console.ReadKey();

            int a = 5;

            a = double_int(a);

            Console.WriteLine("My Value Is : {0}", a);

            Console.ReadKey();

            int b = 10;

            double_ref(ref b);

            Console.WriteLine("This is B Vlaue : {0}", b);

            Console.ReadKey();

        }

        static void double_ref(ref int a)
        {
            a *= 2;
        }


        static int double_int(int a)
        {
            return a * 2;
        }


        static int SumVals(params int[] vals)
        {
            int sum = 0;
            foreach(int val in vals)
            {
                sum += val;
            }
            return sum;
        }

    }
}