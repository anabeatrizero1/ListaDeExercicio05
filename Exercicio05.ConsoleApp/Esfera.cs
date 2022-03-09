using System;

namespace Exercicio05.ConsoleApp
{
    public class Esfera
    {
        public double raio;

        public double ObterVolume()
        {
            double volume = (4 / 3) * Math.PI * Math.Pow(raio, 3);
            return volume;
        }
    }
}
