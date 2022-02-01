Kogu está buscando as esferas do dragão para invocar Xenlongão e pedir para ele reviver seu amigo Kuriri, que infelizmente morreu de novo na última batalha dos guerreiros Zê.
Porém Kogu está tendo muita dificuldade para encontrar as esferas, por isso Xenlongão que é seu conhecido há muito tempo, 
decidiu abrir uma exceção e aceitou ser invocado caso Kogu encontre todas as esferas cujo o número de divisores da quantidade de estrelas da esfera sejam par.
Por exemplo se existem sete esferas, Kogu não precisaria encontrar as esferas de uma e quatro estrelas, 
pois elas tem uma quantidade ímpar de divisores, então ele só precisa pegar 5 esferas para invocar Xenlongão.




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
