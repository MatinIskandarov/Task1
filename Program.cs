using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            //int temp = 0;
            //if (temp > 15)
            //{
            //    console.writeline("hava istidir");
            //}
            //else if(temp < 15)
            // {
            //    console.writeline("hava soyuqdur");
            //}
            //int num = 2;
            //if (num % 2 == 0)
            //{
            //    Console.WriteLine("Eded cutdur");
            //}
            //else if (num % 2 == 1)
            //{
            //    Console.WriteLine("Eded tekdir");
            //}
            int num1 = 2;
            int num2 = 3;
            int num3 = 4;
            if (num1 > num3 && num2 > num3)
            {
                Console.WriteLine("Num3 kicikdir");
            }
            else if (num1 > num2 && num3 > num2)
            {
                Console.WriteLine("Num2 kicikdir");
            }
            else if (num3 > num1 && num2 > num1)
            {
                Console.WriteLine("Num1 kicikdir");
            }


        }
    }
}
