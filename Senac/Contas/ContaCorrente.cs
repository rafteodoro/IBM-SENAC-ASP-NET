using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBM.Treinamento.Senac.Contas
{
    public class ContaCorrente:Conta
    {
        public ContaCorrente(int numero) : base(numero) 
        {

        }

        public ContaCorrente(double saldoInicial)
            : base(saldoInicial)
        {
 
        }

        public override void Deposita(double valor)
        {
            Saldo += valor;
        }

        public override bool Saca(double valor)
        {
            this.Saldo -= (valor + 0.10);
            return true;
        }
    }
}
