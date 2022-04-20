using System;

namespace Aula60Exe18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu ano de nascimento: ");
            int anoNasc = int.Parse(Console.ReadLine());
            if((DateTime.Today.Year - anoNasc) < 16)
            {
                Console.WriteLine("Você não poderá votar esse ano");
            }
            else
            {
                Console.WriteLine("Você poderá votar esse ano");
            }
        }
    }
}
