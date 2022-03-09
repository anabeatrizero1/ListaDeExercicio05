using System;

namespace Exercicio07.ConsoleApp
{
    public class Vendedor
    {
        public double salarioBase;
        public int totalVendas;
        public double percentualGanho;

        public double CalcularSalario()
        {
            double comissao = totalVendas * (percentualGanho / 100);
            double salarioTotal = salarioBase + comissao;
            return salarioTotal;
        }
    }
}
