//Pida dos números y determine el mayor de ellos

using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Digite su 1er numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite su 2do numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine($"El numero {num1} es mayor que {num2}");

            }

            else
            {
                Console.WriteLine($"El numero {num2} es mayor que {num1}");
            }
        }
    }
}
