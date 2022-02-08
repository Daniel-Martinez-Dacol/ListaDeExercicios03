using System;
/**
• Escreva um algoritmo que leia um valor inicial A e imprima a sequência de
valores do cálculo de A! e o seu resultado.
Ex: 5! = 5 X 4 X 3 X 2 X 1 = 120
 */
namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o numero (A!): ");
            int a = int.Parse(Console.ReadLine());
            string resolucao = "";
            int fatoracao = 1;
            for (int i = a; i > 0; i--)
            {
                if (i != 1)
                {
                    resolucao = resolucao + $" {i} X";
                    fatoracao = fatoracao * i;
                }
                

            }
            resolucao = resolucao + $" 1 = {fatoracao}";
            Console.Write($"{a}! ={resolucao}");
            Console.ReadLine();
        }
    }
}
