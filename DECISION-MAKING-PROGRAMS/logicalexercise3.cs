//Capture cuatro números determine cuál es el mayor, la sumatoria y el promedio

using System;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d;
            double sumatoria;
            double promedio;

            Console.Write("Digite su 1er numero: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite su 2do numero: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite su 3er numero: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite su 4to numero: ");
            d = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            if ((a != b && a != c && a != d)
                || (b != a && b != c && b != d)
                    || (c != a && c != b && c != d)
                        || (d != a && d != c && d != b))
            {
                //if them else Anidados
                if (a >= b && a >= c && a >= d)
                {
                    Console.WriteLine($"El 1er numero {a} es mayor que {b},{c},{d}");
                }

                else
                {
                    if (b >= a && b >= c && b >= d)
                    {
                        Console.WriteLine($"El 2do numero {b} es mayor que {a},{c},{d}");
                    }

                    else
                    {
                        if (c >= a && c >= b && c >= d)
                        {
                            Console.WriteLine($"El 3er numero {c} es mayor que {a},{b},{d}");
                        }

                        else
                        {
                            if (d >= a && d >= c && d >= b)
                            {
                                Console.WriteLine($"El 4to numero {d} es mayor que {a},{b},{c}");
                            }

                        }
                    }
                }

            }

            else
            {
                Console.WriteLine($"Numeros iguales {a}, {b}, {c}, {d}");
            }

            sumatoria = a + b + c + d;
            Console.WriteLine($"La sumatoria es {sumatoria}");

            promedio = sumatoria / 4;
            Console.WriteLine($"El promedio es {promedio:N2}");
        }
    }
  }
}
