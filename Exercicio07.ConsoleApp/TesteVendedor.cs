using System;

namespace Exercicio07.ConsoleApp
{
    public class TesteVendedor
    {
        static void Main(string[] args)
        {
            Vendedor vendedor = new Vendedor();

            vendedor.salarioBase = 2000;
            vendedor.totalVendas = 30000;
            vendedor.percentualGanho = 20;

            Console.WriteLine("O salário do vendedor é: {0} ", vendedor.CalcularSalario());

        }
    }
}
