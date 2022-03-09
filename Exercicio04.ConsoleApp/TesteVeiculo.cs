using System;

namespace Exercicio04.ConsoleApp
{
    public class TestarVeiculo

    {
        static void Main(string[] args)
        {
            Veiculo viagemParaAcademia = new Veiculo();

            viagemParaAcademia.kmInicial = 10;
            viagemParaAcademia.kmFinal = 35;
            viagemParaAcademia.consumoCombustivel = 10;

            viagemParaAcademia.ConsumoCombustivelPorKm();
            Console.ReadKey();
        }
    }
}
