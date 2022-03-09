using System;

namespace Exercicio08.ConsoleApp
{
    public class LataOleo
    {
        public double raio;
        public double altura;

        public double ObterVolume()
        {
            double volume =  Math.PI * Math.Pow(raio, 2) * altura;
            return volume;
        }
    }
}
