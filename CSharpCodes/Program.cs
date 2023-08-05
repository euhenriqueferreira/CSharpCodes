// See https://aka.ms/new-console-template for more information
using System;
namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string teste;
            /*
             É possível declarar uma variável
             sem valor, e atribuir o valor depois.
            */
            teste = "testando";

            string name = "Henrique"; //string
            char letra = 'h'; //char
            int number = 10; //int
            double number2 = 8.5; //double
            bool condition = true; //bool

            Console.WriteLine(name);
            Console.WriteLine(letra);
            Console.WriteLine(number);
            Console.WriteLine(number2);
            Console.WriteLine(condition);

            if(name == "Henrique")
            {
                Console.WriteLine("Meu nome é Henrique");
            }
            else
            {
                Console.WriteLine("Meu nome não é Henrique!");
            }
        }
    }
}