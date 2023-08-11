// See https://aka.ms/new-console-template for more information
using System;
using System.Security.Cryptography.X509Certificates;
using System.IO;

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

            AlunoEscola Aluno1= new AlunoEscola("Joãozinho");

            Console.WriteLine(Aluno1.nome);
            Aluno1.estudar();

            string textoArquivo = "Esse é o texto que será escrito dentro de meu arquivo.";
            File.WriteAllText("texto.txt", textoArquivo);

            string lerTexto = File.ReadAllText("texto.txt");
            Console.WriteLine(lerTexto);
        }

    }

}