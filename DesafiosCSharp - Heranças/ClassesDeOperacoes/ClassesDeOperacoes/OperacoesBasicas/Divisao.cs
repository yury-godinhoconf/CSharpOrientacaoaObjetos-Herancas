using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDeOperacoes.OperacoesBasicas
{
    public class Divisao
    {
        public double CalcularDivisao (double divisor, double dividendo)
        {
            if (divisor == 0)
            {
                return 0;
            }
            return dividendo / divisor;
        }
    }

}
