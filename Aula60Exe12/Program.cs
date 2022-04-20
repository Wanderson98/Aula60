using System;

namespace Aula60Exe12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a temperatura em Fahrenheite: ");
            double fahren = double.Parse(Console.ReadLine());
            double celsius = (fahren - 32) / 1.8;
            Console.Write("Tempertatura em Graus Celsius: {0} C ", celsius);


        }
    }
}
