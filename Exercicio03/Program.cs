using System;
/**
 • Desenvolver um algoritmo que efetue a soma de todos os números
ímpares que são múltiplos de três e que se encontram no conjunto dos
números de 1 até 500.
 */
namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int num = 1;
            int sum = 0;
            while (num < 500) 
            {
                if (num%2 != 0 && num%3 == 0)
                {
                    
                    sum = sum + num;
                    Console.WriteLine($"-O numero: {num} vai pra soma.\n-A SOMA ATÉ O MOMENTO: {sum}\n");
                    num++;
                }
                else
                {
                    num++;
                }
            }
            Console.WriteLine($"SOMA TOTAL : {sum}");

            Console.ReadLine();
        }
    }
}
