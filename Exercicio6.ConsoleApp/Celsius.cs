using System;

namespace Exercicio06.ConsoleApp
{
    public class Celsius
    {
        public double grausCelsius;

        public double ConverterParaFahrenheit()
        {
            double grausFahrenheit = grausCelsius * (9/8) + 32;
            return grausFahrenheit;
        }
    }
}
