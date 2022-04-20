using System;

namespace Aula60Exe13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] nota = new double[3];
            for (int i = 0; i < nota.Length; i++)
            {
                Console.WriteLine("Digite a nota #{0}", i+1);
                nota[i] = double.Parse(Console.ReadLine());

            }

            double mediaFinal = ((nota[0] * 2) + (nota[1] * 3) + (nota[2] * 5)) / 10;

            Console.WriteLine("Media Final Ponderada Foi: " + mediaFinal.ToString("F2"));



        }
    }
}
