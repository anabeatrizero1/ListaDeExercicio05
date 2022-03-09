using System;

namespace Exercicio08.ConsoleApp
{
    internal class TesteLataOleo
    {
        static void Main(string[] args)
        {
            LataOleo lataOleo = new LataOleo();
            lataOleo.raio = 3;

            Console.WriteLine("O volume da lata de óleo é: {0}", lataOleo.ObterVolume());
            Console.ReadLine();
        }
    }
}
