using System;

namespace Exercicio02.ConsoleApp
{
    public class TesteFahrenheit
    {
        static void Main(string[] args)
        {
            Fahrenheit fahrenheit = new Fahrenheit();
            fahrenheit.grausFahrenheit = 1;

            Console.WriteLine("A temperatura convertida para Celsius: {0}", fahrenheit.ConverterParaCelsius());
            Console.ReadKey();
          
        }
    }
}
