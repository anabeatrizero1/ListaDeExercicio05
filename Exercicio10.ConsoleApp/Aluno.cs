using System;

namespace Exercicio10.ConsoleApp
{
    public class Aluno
    {
        public int nota1;
        public int pesoNota1;
        public int nota2;
        public int pesoNota2;


        public double ObterMediaPonderada()
        {
            double mediaPonderada = ((nota1 * pesoNota1) + (nota2 * pesoNota2)) / (pesoNota1 * pesoNota2);
            return mediaPonderada;
        }
    }
}
