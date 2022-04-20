using System;

namespace Aula60Exe91
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] vet = new double[5];

            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write("Digite o número #{0}", i + 1);
                vet[i] = double.Parse(Console.ReadLine()); 
            }
           
            for (int i = 0; i <= vet.Length; i++)
            {
                for (int j = i + 1; j < vet.Length; j++)
                {
                    if (vet[j] == vet[i])
                    {
                        Console.WriteLine("Número repetido na casa {0} e na casa {1}", i, j );
                    }
                }


            }


        }
    }
}
