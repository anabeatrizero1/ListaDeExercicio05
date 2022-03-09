using System;

namespace Exercicio10.ConsoleApp
{
    public class TesteAluno
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            aluno.nota1 = 9;
            aluno.pesoNota1 = 10;
            aluno.nota2 = 10;
            aluno.pesoNota2 = 20;

            Console.WriteLine("A média ponderada das notas é: {0}", aluno.ObterMediaPonderada());
            Console.ReadKey();
        }
    }
}
