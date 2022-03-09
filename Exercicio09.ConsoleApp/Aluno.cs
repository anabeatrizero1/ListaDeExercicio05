using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio09.ConsoleApp
{
    internal class Aluno
    {
        public int nota1;
        public int nota2;
        public int nota3;
        public int nota4;

        public double ObterMediaHarmonica()
        {
            double mediaH = (4 / ((1 / nota1) + (1 / nota2) + (1 / nota3) + (1 / nota4)));
            return mediaH;
        }
    }
}
