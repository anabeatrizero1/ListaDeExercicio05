using System;

namespace Exercicio09.ConsoleApp
{
    public class TesteAluno
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            aluno.nota1 = 10;
            aluno.nota2 = 9;
            aluno.nota3 = 10;
            aluno.nota4 = 8;

            Console.WriteLine("A média harmonica das notas é: {0}", aluno.ObterMediaHarmonica());
        }
    }
}
