using System;
namespace Exercicio02.ConsoleApp
{
    public class Fahrenheit
    {
        public double grausFahrenheit;

        public double ConverterParaCelsius()
        {
            double grausCelsius = (grausFahrenheit - 32) / (5/9);
            return grausCelsius;
            
        }
    }
}
