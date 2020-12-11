using System;
using AulaPOO_PolimosrfismoSobrecarga.classes;

namespace AulaPOO_PolimosrfismoSobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instaciamos nossa classe Funcionario

            Funcionario Fun = new Funcionario();
            Fun.Mostrar();
            Fun.Mostrar(5);
            Fun.Mostrar("Pedro");

            
        }
    }
}
