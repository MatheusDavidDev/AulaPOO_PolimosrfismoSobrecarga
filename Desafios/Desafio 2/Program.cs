using System;
using Desafio_2.classes;

namespace Desafio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogador jogador = new Jogador();
            Console.WriteLine("Cadastre o jogador");
            Console.WriteLine("Qual o nome do jogador ?");
            jogador.nome = Console.ReadLine();

            Console.WriteLine("Qual a posição do jogador ?");
            jogador.posicao = Console.ReadLine();

            Console.WriteLine("Qual o ano de nascimento do jogador ?");
            jogador.dataDeNascimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a nacionalidade do jogador ?");
            jogador.nacionalidade = Console.ReadLine();

            Console.WriteLine("Qual a altura do jogador ?");
            jogador.altura = float.Parse(Console.ReadLine());

            Console.WriteLine("Qual o peso do jogador ?");
            jogador.peso = float.Parse(Console.ReadLine());

        }
    }
}
