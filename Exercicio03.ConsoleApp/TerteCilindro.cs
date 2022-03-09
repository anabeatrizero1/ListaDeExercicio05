using System;

namespace Exercicio03.ConsoleApp
{
    public class TesteCilindro
    {
        static void Main(string[] args)
        {
            Cilindro cilindo = new Cilindro();

            cilindo.raio = 3;
            cilindo.altura = 4;

            Console.WriteLine("O volume do Cilindro é: {0}", cilindo.ObterVolume());
            Console.ReadKey();

        }
    }
}
