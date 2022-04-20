using System;

namespace Aula60Exe22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número de Horas trabalhadas no mês: ");
            int horas = int.Parse(Console.ReadLine());

            Console.Write("Digite o salário por hora: ");
            double salarioPorHora = double.Parse(Console.ReadLine());

            if (horas <= 160)
            {
                Console.WriteLine("Salário do Funcionário foi de: R$ {0:F2}", (horas * salarioPorHora));
            }
            else
            {
                double horaExtra = (horas - 160) * (salarioPorHora * 0.5);
                Console.WriteLine("Salário do Funcionário foi de: R$ {0:F2}", (horas * salarioPorHora + horaExtra));
            }
        }
    }
}