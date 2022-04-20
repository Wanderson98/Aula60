using System;

namespace Aula60Exe84
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o tamanho dos vetores: ");
            int tamVetor = int.Parse(Console.ReadLine());
            double[] vetorA = new double[tamVetor];
            double[] vetorB = new double[tamVetor];
            double[] vetorSoma = new double[tamVetor];

            for (int i = 0; i < tamVetor; i++)
            {
                Console.Write($"Digite o Valor do Vetor A na Posição #{i}: ");
                vetorA[i] = double.Parse(Console.ReadLine());
                Console.Write($"Digite o Valor do Vetor B na Posição #{i}: ");
                vetorB[i] = double.Parse(Console.ReadLine());

                vetorSoma[i] = vetorA[i] + vetorB[i];
            }

            for (int i = 0; i < tamVetor; i++)
            {
                Console.WriteLine($"Resultado Da Soma do VetorA na casa[{i}] e do Vetor B na casa[{i}] é : {vetorSoma[i]}");
            }
        }
    }
}
