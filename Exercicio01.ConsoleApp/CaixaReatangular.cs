using System;

namespace Exercicio01.ConsoleApp
{
    public class CaixaReatangular
    {
        
        public int altura;
        public int comprimento;
        public int largura;
      
        public double ObtemVolume()
        {
            double volume = altura * comprimento * largura;
            
            return volume;

        }
    }
}