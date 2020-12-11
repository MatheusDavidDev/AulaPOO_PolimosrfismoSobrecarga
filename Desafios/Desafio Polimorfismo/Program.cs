using System;
using Desafio_Polimorfismo.classes;

namespace Desafio_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            MaquinaCafe cafe = new MaquinaCafe();
            Console.WriteLine("MAQUINA DE CAFÉ");
            Console.WriteLine($"Quantidade de açucar na maquina {cafe.acucarDisponivel} gramas");
            Console.WriteLine("Qual a quantidade de açucar desejada no seu café? Caso queira a padrao é so digitar 0");
            int gramas = int.Parse(Console.ReadLine());
            if(gramas != 0){

                cafe.fazerCafe(gramas);
            }else{

                cafe.fazerCafe();
            }


        }
    }
}
