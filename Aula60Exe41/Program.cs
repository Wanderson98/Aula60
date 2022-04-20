using System;

namespace Aula60Exe41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] notas = new double[3];
            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write("Digite a Nota #{0}: ", i+1);
                notas[i] = double.Parse(Console.ReadLine());
            }
            Console.Write("Digite a Média dos Exercicios: ");
            double mediaExe = double.Parse(Console.ReadLine());

            Aluno aluno = new Aluno(notas, mediaExe);

            aluno.MostrarConceito();
        }
    }

    public class Aluno
    {

        public double[] Notas = new double[3];
        public double MediaExercicios { get; set; }

        public Aluno(double[] notas, double mediaExercicios)
        {
            Notas = notas;
            MediaExercicios = mediaExercicios;
        }

        private double CalcularNota()
        {
            return (Notas[0] + (Notas[1] * 2) + (Notas[2] * 3) + MediaExercicios) / 7;
        }

        public void MostrarConceito()
        {
            double media = CalcularNota();
            if (media < 6.0)
            {
                Console.WriteLine("Conceito D - Média: {0:F2}", media);
            }
            else if (media < 7.5)
            {
                Console.WriteLine("Conceito C - Média: {0:F2}", media);
            }
            else if (media < 9.0)
            {
                Console.WriteLine("Conceito B - Média: {0:F2}", media);
            }
            else
            {
                Console.WriteLine("Conceito A - Média: {0:F2}", media);
            }
        }
    }

}
