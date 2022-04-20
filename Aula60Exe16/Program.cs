using System;

namespace Aula60Exe16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de maçãs compradas: ");
            int qtdMaca = int.Parse(Console.ReadLine());

            if (qtdMaca < 12)
            {
                Console.WriteLine("Custo total da compra de {0} maças foi de {1:F2}", qtdMaca, (qtdMaca * 1.3) );
            }
            else
            {
                Console.WriteLine("Custo total da compra de {0} maças foi de {1:F2}", qtdMaca, (qtdMaca * 1));
            }
        }
    }
}
