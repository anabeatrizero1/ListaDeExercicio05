using System;

namespace Exercicio03.ConsoleApp
{
    public class Cilindro
    {
        public double altura;
        public double raio;

        public double ObterVolume()
        {
            double volume = Math.PI * Math.Pow(raio, 2) * altura;
            return volume;
        }
                
    }
}
