using System;

namespace Exercicio05.ConsoleApp
{
    public class TesteEsfera
    {
        static void Main(string[] args)
        {
            Esfera esfera = new Esfera();
            esfera.raio = 4;

            Console.WriteLine("O volume da esfera é: ", esfera.ObterVolume());
            Console.ReadKey();
        }
    }
}
