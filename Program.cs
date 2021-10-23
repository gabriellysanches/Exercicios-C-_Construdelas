using System;
using System.Collections.Generic;
using System.Threading;

namespace jogos
{
    class Program
    {
       static void Main(string[] args)
        {
            List<Pessoa> pessoas = new List<Pessoa>();
            List<Pessoa> enderecos = new List<Pessoa>();


            Console.WriteLine("Digite o 1º Nome:");
            Pessoa nome1 = new Pessoa();
            nome1.Nome = Console.ReadLine();
            pessoas.Add(nome1);

            
            Console.WriteLine("Digite o Endereço do 1º Nome:");
            Pessoa endereco1 = new Pessoa();
            endereco1.Endereco = Console.ReadLine();
            pessoas.Add(endereco1);

            Console.WriteLine("Digite o 2º Nome:");
            Pessoa nome2 = new Pessoa();
            nome2.Nome = Console.ReadLine();
            pessoas.Add(nome2);

            
            Console.WriteLine("Digite o Endereço do 2º Nome:");
            Pessoa endereco2 = new Pessoa();
            endereco2.Endereco = Console.ReadLine();
            pessoas.Add(endereco2);

            Console.Clear();
            Thread.Sleep(2000); // 2 segundos

            foreach(var p in pessoas)
            {
                Console.WriteLine($"{p.Nome} - {p.Endereco}");
            }
           
            //coloque os nomes em uma lista de pessoas, onde estas pessoas terão em sua lista as propriedades, nome e endereço

            
        }
    }
}
