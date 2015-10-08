using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IBM.Treinamento.Senac.Contas;

namespace Senac
{
    public partial class frmDeposito : Form
    {
        ContaPoupanca conta;

        public frmDeposito()
        {
            InitializeComponent();
        }

        public frmDeposito(ContaPoupanca conta)
        {
            InitializeComponent();
            this.conta = conta;            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmDeposito_Load(object sender, EventArgs e)
        {
            txtNumero.Text = conta.Numero.ToString();
            txtSaldo.Text = conta.Saldo.ToString();
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            conta.Deposita(Convert.ToDouble(txtValor.Text));
            txtSaldo.Text = conta.Saldo.ToString();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
