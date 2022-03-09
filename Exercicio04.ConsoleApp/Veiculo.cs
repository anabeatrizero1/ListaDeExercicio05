using System;

namespace Exercicio04.ConsoleApp
{
    public class Veiculo
    {
        public int kmInicial;
        public int kmFinal; 
        public int consumoCombustivel;

        public double ConsumoCombustivelPorKm()
        {
            double quilometrosRodados = kmFinal - kmInicial;
            double consumoPorKm = consumoCombustivel / quilometrosRodados;

            return consumoPorKm;
        }

    }
}
