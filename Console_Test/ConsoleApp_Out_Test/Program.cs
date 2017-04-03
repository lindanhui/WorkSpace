using System;

namespace ConsoleApp_Out_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello This Is Out Test !");

            int Max_Value = 0;

            MaxValue(out Max_Value, 1, 2, 6, 8, 7, 4, 5, 6, 9, 44, 55, 66, 8, 78, 95, 13, 259, 56, 699, 665, 569, 48, 698, 256, 24);

            Console.WriteLine("I Was Max Value : {0}", Max_Value);

            Console.ReadKey();

            string mystring = "this is my string !";

            Console.WriteLine($"this string is {mystring}");

            Console.ReadKey();
        }

        static void MaxValue(out int maxindex,params int[] intarray)
        {
            int maxvalue = intarray[0];
            for(int i=1;i<intarray.Length;i++)
            {
                if (intarray[i] > maxvalue)
                    maxvalue = intarray[i];
            }
            maxindex = maxvalue;
        }
    }
}