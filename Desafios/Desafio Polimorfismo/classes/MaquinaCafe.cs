using System;

namespace Desafio_Polimorfismo.classes
{
    public class MaquinaCafe
    {
        // Atributos
        public int acucarDisponivel = 11;

        // Metodos

        public void fazerCafe(int gramas){
            if (gramas <= this.acucarDisponivel)
            {
                Console.WriteLine($"Fazendo café personalizado com {gramas} gramas de açucar"); 
            }else{
                Console.WriteLine("Quantidade de açucar indisponivel comprar mais açucar!");
            }

        }

        public void fazerCafe(){
            if (10 <= this.acucarDisponivel)
            {
                Console.WriteLine("Fazendo café padrão com 10 gramas de açucar");
            }else{
                Console.WriteLine("Quantidade de açucar indisponivel para fazer o café padrão comprar mais açucar!");
            }
        }
    }
}