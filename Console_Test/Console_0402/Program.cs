using System;

namespace Console_0402
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] int_array = {1,3,9,4,66,22,55,77,68,68,15,466,26,89,24 };
            Console.WriteLine("this is max value :" + MaxValue(int_array));
            Console.ReadKey();



        }


        static int MaxValue(int[] intArray)
        {
            int max_value = intArray[0];
            for(int i =1;i<intArray.Length;i++)
            {
                if(intArray[i]> max_value)
                {
                    max_value = intArray[i];
                }
            }
            return max_value;
        }


    }
}