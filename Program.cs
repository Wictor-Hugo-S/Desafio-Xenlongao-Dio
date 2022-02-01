using System;

namespace Desafio_Dio
{
    class Program
    {
        static void Main(string[] args)
        {
      
                int n = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());

                Console.WriteLine(c - Math.Floor(Math.Sqrt(c)));

            }
        }
    }
