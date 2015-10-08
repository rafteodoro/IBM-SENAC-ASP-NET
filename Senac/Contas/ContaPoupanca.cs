using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBM.Treinamento.Senac.Contas
{
    public class ContaPoupanca: Conta, ITributavel
    {
        public ContaPoupanca(int numero) : base(numero) 
        {
        }

        public ContaPoupanca(double saldoInicial)
            : base(saldoInicial)
        { }


        public override void Deposita(double valor)
        {
            Saldo += valor;
        }

        public override bool Saca(double valor)
        {
            this.Saldo -= (valor + 0.10);
            return true;
        }

        public double CalculaTributo()
        {
            throw new NotImplementedException();
        }
    }
}
