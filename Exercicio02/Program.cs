using System;
/**
• Escrever um algoritmo que gera e escreve os números ímpares entre 100 e 200.
 */
namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variavel pra começar contagem apartir de 100.
            int i = 100;
            //Variavel pra amazernar a qtd de numeros ímpares.
            int contador = 0;

            do
            {
                i++;
                if (i % 2 != 0)
                {
                    contador++;
                    Console.WriteLine($"-O {contador}º numero ímpar é: {i}");
                }
            } while (i != 200);
            Console.ReadLine();
        }
    }
}
