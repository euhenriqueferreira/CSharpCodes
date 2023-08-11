using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyApplication
{
    abstract class Aluno
    {
        public abstract void estudar();
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    class AlunoEscola : Aluno
    {
        public string nome;

        public AlunoEscola(string nomeAluno)
        {
            nome = nomeAluno;
        }
        public override void estudar()
        {
            Console.WriteLine("Estudando...");
        }

    }
}
