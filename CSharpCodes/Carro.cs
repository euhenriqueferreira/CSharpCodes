// See https://aka.ms/new-console-template for more information
using System;

namespace MyApplication
{
    class Carro
    {
        public string cor;
        public int numPortas;
        public string potencia;
        private string numSerie;

        public string NumSerie
        {
            get { return numSerie;  }
            set { numSerie = value; }
        }

        public Carro(string corCarro, int numeroPortas, string potenciaCarro)
        {
            cor = corCarro;
            potencia = potenciaCarro;
            numPortas = numeroPortas;
        }


        public void acelerar()
        {
            Console.WriteLine("O carro está ganhando velocidade");
        }

        public void frear()
        {
            Console.WriteLine("O carro está diminuindo a velocidade");
        }
    }

}