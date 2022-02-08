using System;
/**
 • Escrever um algoritmo que leia um valor para uma variável N de 1 a 10 e
calcule a tabuada de N.
• Mostre a tabuada na forma: 0 x N = 0, 1 x N = 1N, 2 x N = 2N, ..., 10 x N = 10N.

 */
namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite qual a tabuada que desejava ver: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i} X {n} = {i*n}");
            }
            Console.ReadLine();
        }
    }
}
