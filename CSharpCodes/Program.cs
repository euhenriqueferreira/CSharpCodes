// See https://aka.ms/new-console-template for more information
using System;

namespace OddOrEven
{
    class ProgramOOE //Programa que identifica se o número é par ou ímpar.
    {
        static void Main(String[] args)
        {
        
            Console.Write("Escreva um número: ");
        
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);
        
            Console.WriteLine((number % 2 == 0 ? "O número é par": "O número é ímpar"));
        }

    }

    class Calculator
    { 
        static void Calc(string[] args)
        {
            Console.WriteLine("Escreva o primeiro número:");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escreva o segundo número:");
            double number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escolha a operação: ");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.Write("Operação escolhida: ");
            Double operacao = Convert.ToDouble(Console.ReadLine());

            switch (operacao)
            {
                case 1:
                    Console.WriteLine(number1 + number2);
                    break;
                case 2:
                    Console.WriteLine(number1 - number2);
                    break;
                case 3:
                    Console.WriteLine(number1 * number2);
                    break;
                case 4:
                    Console.WriteLine(number1 / number2);
                    break;
                default:
                    Console.WriteLine("A operação não existe");
                    break;
            }
        }

    }


}