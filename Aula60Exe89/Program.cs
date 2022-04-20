using System;

namespace Aula60Exe89
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] vetorA = { 98, 15, 42, 7, 86, 12, 4, 11, 2, 32, 32, 8, 71, 26, 44, };
            double[] vetorB = { 98, 23, 3, 7, 34, 2, 34, 31, 2, 5, 3, 5, 6, 43, 44, }; ;
            int contador = 0;

            for (int i = 0; i < vetorA.Length; i++)
            {
                if (vetorA[i] == vetorB[i])
                {
                    contador++;
                }
            }

            Console.WriteLine("Número de vezes que o Vetor A e o Vetor B tem o mesmo número na mesma posição: " + contador);
        }
    }
}
