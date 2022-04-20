using System;
using System.Collections.Generic;

namespace Aula60
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> pessoas = new List<Pessoa>();
            pessoas.Add(new Pessoa("Joao", 34));
            pessoas.Add(new Pessoa("Maria", 23));
            pessoas.Add(new Pessoa("Wanderson", 22));
            pessoas.Add(new Pessoa("Priscila", 27));

            foreach (Pessoa p in pessoas)
            {
                Console.WriteLine(p.Nome + " " + p.Idade);
            }

            ListaOrdenada(pessoas);
            ListaVerificarSeExiste(pessoas);

        }

        static void ListaOrdenada(List<Pessoa> pessoas)
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Minha lista ordenada!");
            pessoas.Sort(delegate(Pessoa p1, Pessoa p2)
            {
                return p1.Nome .CompareTo(p2.Nome);
            });
            pessoas.ForEach(delegate (Pessoa p)
            {
                Console.WriteLine(p.Nome + " " + p.Idade);
            });
        }

        static void ListaVerificarSeExiste(List<Pessoa> pessoas)
        {
            Console.Write("Digite a idade: ");
            int idade = int.Parse(Console.ReadLine());
            string resposta;
            if(pessoas.Exists(p => p.Idade == idade))
            {
                resposta = "sim";
            }
            else
            {
                resposta = "não";
            }
              
            Console.WriteLine("Existe a pessoa com 34 anos: {0}",resposta);
        }
    }


    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public Pessoa()
        {

        }
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
    }
}
