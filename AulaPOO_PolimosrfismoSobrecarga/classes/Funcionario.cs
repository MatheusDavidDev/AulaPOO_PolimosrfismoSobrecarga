using System;
namespace AulaPOO_PolimosrfismoSobrecarga.classes
{
    public class Funcionario
    {
        //Ctrl + G vai para a linha
        //Atributos 
        public string[] lista = {"Paulo", "Tsuka", "Priscila", "Fernanda"};


        //Metodos
        public void Mostrar(){
            // Imprimimos todos os dados que estão no array
            foreach (var item in lista)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(item);
                Console.ResetColor();
            }
        }

        public void Mostrar(int indice){
            // Mostramos apenas o dado que está na índice do array
            Console.ForegroundColor = ConsoleColor.Blue;
            if (indice < lista.Length)
            {
                Console.WriteLine(lista[indice]);    
            }
        }

        public void Mostrar(string busca){
            // Fazemos uma busca no array para verificar se os textos concidem
            foreach (var item in lista)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                ;
                
                if(item == busca){
                    Console.WriteLine("Resultados da busca: "+item);
                }

                Console.ResetColor();
            }
        }
    }
}