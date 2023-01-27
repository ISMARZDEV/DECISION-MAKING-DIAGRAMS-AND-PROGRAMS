//Pida dos sueldos y determine el mayor y el menor de ellos;

using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 0;

            while(num1 == num2) 
            { 
            Console.Write("Digite su 1er numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite su 2do numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            }

            if (num1 > num2)
            {
                Console.WriteLine($"El 1er numero = {num1} es mayor que el 2do numero = {num2}");

            }

            else
            {
                Console.WriteLine($"El 2do numero = {num2} es mayor que el 1er numero = {num1}");
            }
        }
    }
}
