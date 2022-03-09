using System;

namespace Exercicio06.ConsoleApp
{
    public class TesteCelsius
    {
        static void Main(string[] args)
        {
            Celsius celsius = new Celsius();

            celsius.grausCelsius = 20;

            Console.WriteLine("A temperatura convertida para Fahrenheit é: {0}: ", celsius.ConverterParaFahrenheit());
            Console.ReadKey();
        }

    }
}
