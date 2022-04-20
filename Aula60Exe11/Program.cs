using System;

namespace Aula60Exe11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número de carros vendidos: ");
            int carrosVendidos = int.Parse(Console.ReadLine());

            double[] valorCarros = new double[carrosVendidos];

            for (int i = 0; i < carrosVendidos; i++)
            {
                Console.Write("Digite o valor do Carro #{0}: ", i+1);
                valorCarros[i] = int.Parse(Console.ReadLine());
            }
            
            Funcionario func = new Funcionario();
            func.CalcularSalarioFinal(valorCarros, carrosVendidos);

        }
    }

    public class Funcionario
    {
        public double Salario = 1000;
        public double ComissaoFixa = 100;
        public double ComissaoValorTotal = 0.05;

        public  void CalcularSalarioFinal(double[] valorCarros, int numeroCarrosVendidos)
        {
            double valorVendas = 0;
            double salarioFinal = 0;
            for (int i = 0; i < numeroCarrosVendidos; i++)
            {
                valorVendas += valorCarros[i];
            }

            salarioFinal = Salario + (ComissaoFixa * numeroCarrosVendidos) + (valorVendas * ComissaoValorTotal);

            Console.WriteLine("O Salario final do Funcionário é de: R$ {0:F2}",salarioFinal);
            
        }
    }
}
