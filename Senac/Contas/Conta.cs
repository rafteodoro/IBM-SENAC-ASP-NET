using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBM.Treinamento.Senac.Contas
{
    public abstract class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; set; }

        //Composição de classes
        public Cliente Titular { get; set; }

        public Conta(double saldoInicial)
        {
            this.Saldo = saldoInicial;
        }

        public Conta() { }
        
        public virtual bool Saca(double valor)
        {
            if (this.Saldo >= valor)
            {
                this.Saldo -= valor;
                return true;
            }
            return false;
        }

        public abstract void Deposita(double valor);

        public void Transfere(double valor, Conta destino)
        {
            if (this.Saca(valor))
            {
                destino.Deposita(valor);
            }
        }
    }
}
