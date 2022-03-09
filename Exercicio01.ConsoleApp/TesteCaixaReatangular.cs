using System;

namespace Exercicio01.ConsoleApp
{
    internal class TesteCaixaReatangular
    {
        static void Main(string[] args)
        {
            CaixaReatangular caixa = new CaixaReatangular();
            caixa.altura = 10;
            caixa.largura = 10;
            caixa.comprimento = 10;

            Console.WriteLine("O volume da caixa é: {0}", caixa.ObtemVolume());
            Console.ReadKey();
        }
    }
}
