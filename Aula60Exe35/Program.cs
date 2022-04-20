using System;

namespace Aula60Exe35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem Vindo ao Posto Cast");
            Console.Write("Digite A para abaster com Alcool " +
                "\nOu Digite G para abastecer com Gasolina: ");
            char combust = char.Parse(Console.ReadLine().ToLower());
            Console.Write("Agora Digite a quantidade de litros: ");
            double litros = double.Parse(Console.ReadLine());

            if ( litros > 20.0)
            {
                if(combust == 'a')
                {
                    Console.WriteLine("Desconto de 5% ao litro");
                    Console.WriteLine("Alcool: {0} Litros - Valor total de: R$ {1:F2}", litros, (2.9 * 0.95 * litros));
                }
                else if(combust == 'g')
                {
                    Console.WriteLine("Desconto de 6% ao litro");
                    Console.WriteLine("Gasolina: {0} Litros - Valor total de: R$ {1:F2}", litros, (3.3 * 0.94 * litros));
                }
                 
            }
            else
            {
                if (combust == 'a')
                {
                    Console.WriteLine("Desconto de 3% ao litro");
                    Console.WriteLine("Alcool: {0} Litros - Valor total de: R$ {1:F2}", litros, (2.9 * 0.97 * litros));
                }
                else if (combust == 'g')
                {
                    Console.WriteLine("Desconto de 4% ao litro");
                    Console.WriteLine("Gasolina: {0} Litros - Valor total de: R$ {1:F2}", litros, (3.3 * 0.96 * litros));
                }

            }
        }
    }
}
