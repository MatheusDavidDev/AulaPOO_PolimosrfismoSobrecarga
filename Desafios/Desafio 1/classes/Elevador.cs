using System;

namespace Desafio_1.classes
{
    public class Elevador
    {
        // Atributos
        public string[] andar = {"0º Terrio", "1º andar", "2º andar", "3º andar", "4º andar", "5º andar"};

        public int[] pessoas;

        // Metodos

        public void Inicializa(){

            Console.WriteLine("Seja bem vindo ao elevador");
            Console.WriteLine("Andares: ");
            foreach (var item in andar)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(item);
                Console.ResetColor();
            }
            Console.WriteLine("O elevador comporta até 5 pessoas");

            
        }

        public void Entrar(int pessoas){ 
            Console.WriteLine("Quantas pessoas entraram no")

        }

        public void Sair(){

            
        }

        public void Subir(){

            
        }

        public void Descer(){

            
        }
    }
}