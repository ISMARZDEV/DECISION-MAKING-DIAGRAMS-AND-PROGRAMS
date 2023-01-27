//Que capture un número del 0 a 100 y determine la nota literal (A, B+, B-, C+, C-, D, F) utilizando if anidados.

using System;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double nota;

            Console.WriteLine("Favor de digitar nota del 0 al 100: ");
            nota = Convert.ToDouble(Console.ReadLine());

            if (nota >= 90 && nota <= 100) {
                Console.WriteLine($"Su nota {nota} es A");
            }
            else
            {
                if (nota >= 85 && nota <= 89)
                {
                    Console.WriteLine($"Su nota {nota} es B+");
                }
                else
                {
                    if (nota >= 0 && nota <= 59)
                    {
                        Console.WriteLine($"Su nota {nota} es B-");
                    }
                    else
                    {
                        if (nota >= 0 && nota <= 59)
                        {
                            Console.WriteLine($"Su nota {nota} es C+");
                        }
                        else
                        {
                            if (nota >= 0 && nota <= 59)
                            {
                                Console.WriteLine($"Su nota {nota} es C-");
                            }
                            else
                            {
                                if (nota >= 0 && nota <= 59)
                                {
                                    Console.WriteLine($"Su nota {nota} es D");
                                }
                                else
                                {
                                    if (nota >= 0 && nota <= 59)
                                    {
                                        Console.WriteLine($"Su nota {nota} es f");
                                    }
                                    else
                                    {
                                        if (nota >= 0 && nota <= 59)
                                        {
                                            Console.WriteLine($"Su nota {nota} es D");
                                        }
                                        else
                                        {

                                        }
                                    }
                                }
                            }
                        }
                    }   
                }
            }
                
        }
    }
}
