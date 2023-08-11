// See https://aka.ms/new-console-template for more information
using System;
using System.Security.Cryptography.X509Certificates;

namespace MyApplication
{
    class Pessoa
    {
        public string nome;
        public int anoNascimento;
        
        public int idade()
        {
            return 2023 - anoNascimento;
        }
    }

    class Adulto : Pessoa
    {
        public bool empregado = true;
    }



    class Program
    {       
        static void Main(String[] args)
        {
            Carro Civic = new Carro("Roxo", 2, "800cv");

            Console.WriteLine(Civic.cor);
            Console.WriteLine(Civic.numPortas);
            Console.WriteLine(Civic.potencia);

            Civic.acelerar();

            Carro Porsche = new Carro("Bronze", 2, "700cv");
            //Porsche.NumSerie = "BNEMNR11";
            Console.WriteLine(Porsche.NumSerie);


            Adulto Henrique = new Adulto();

            Henrique.anoNascimento = 2003;
            Console.WriteLine("Idade: " + Henrique.idade());
            Console.WriteLine("Empregado: " + Henrique.empregado);
        }

    }

}