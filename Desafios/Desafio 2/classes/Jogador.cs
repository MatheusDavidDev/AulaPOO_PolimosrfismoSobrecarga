using System;

namespace Desafio_2.classes
{
    public class Jogador
    {   
        //Atributos
        public string nome;

        public string posicao;

        public int dataDeNascimento;

        public string nacionalidade;

        public float altura;

        public float peso;

        //Metodos

        public void Dados(){
            Console.WriteLine("PERFIL DO JOGADOR");
            Console.WriteLine($"Nome: {this.nome}");
            Console.WriteLine($"Posição: {this.posicao}");
            Console.WriteLine($"Ano de nascimento: {this.dataDeNascimento}");
            Console.WriteLine($"Altura: {this.altura} metros");
            Console.WriteLine($"Peso: {this.peso} KG");
            
        
        }

        public int Idade(){
            
            int idade = this.dataDeNascimento - 2020;
            return idade;
        }

        public void Aposentadoria(int idade){

            if (true)
            {
                
            }
        }
    }
}