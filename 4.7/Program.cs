//capitulo 4
using System;
namespace ejercicio4_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int val1, val2;
            Console.WriteLine("ingresa numero");
            val1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingresa numero");
            val2 = Convert.ToInt32(Console.ReadLine());
            if (val1 % val2 == 0)
            {
                Console.WriteLine(val2 + " es divisor de " + val1);
            }
            else
            {
                if (val2 % val1 == 0)
                {
                    Console.WriteLine(val1 + " es divisor de " + val2);
                }
                else
                {
                    Console.WriteLine("ninguno es divisor del otro");
                }
            }
        }
    }
}
