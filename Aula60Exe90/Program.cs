using System;

namespace Aula60Exe90
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] vetorA = new double[30];
            int contador = 0;

            for (int i = 0; i < vetorA.Length; i++)
            {
                Console.Write($"Digite o Numero #{i + 1}: ");
                vetorA[i] = double.Parse(Console.ReadLine());
            }

            Console.Write("Digite um número: ");
            double num = double.Parse(Console.ReadLine());

            for (int i = 0; i < vetorA.Length; i++)
            {
                if (vetorA[i] == num)
                {
                    contador++;
                }
            }

            Console.WriteLine($"O número digitado {num} aparece {contador} no vetor A");
        }
    }
}
