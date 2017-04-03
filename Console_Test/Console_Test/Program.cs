using System;

namespace Console_Test
{
    class Program
    {
        enum ortine : byte
        {
            north = 1,
            south = 2,
            east = 3,
            west = 4
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ortine myort = ortine.south;

            Console.WriteLine("this is :" + myort);

            Console.ReadKey();

            byte ortbyte;

            string ortstring;

            ortine myort1 = ortine.east;

            ortbyte = (byte)myort1;

            ortstring = Convert.ToString(myort1);

            Console.WriteLine("this is byte :" + ortbyte);


            Console.WriteLine("this is string :" + ortstring);


            Console.ReadKey();
        }
    }
}