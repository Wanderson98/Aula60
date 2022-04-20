using System;

namespace Aula60Exe10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de custo do carro: R$ ");
            double valorDeCusto = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor Final do Carro: R$ " + (valorDeCusto * 1.45 + valorDeCusto * 0.28).ToString("F2"));
            Console.WriteLine("Valor Percentural: R$ " + (valorDeCusto * 0.28).ToString("F2"));
            Console.WriteLine("Valor Imposto: R$ " + (valorDeCusto * 0.45).ToString("F2"));

        }
    }

}
