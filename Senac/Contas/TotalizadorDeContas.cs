using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBM.Treinamento.Senac.Contas
{
    internal class TotalizadorDeContas
    {
        public static double ValorTotal { get; private set; }

        public void Soma(Conta conta)
        {
            ValorTotal += conta.Saldo;
        }
    }
}
