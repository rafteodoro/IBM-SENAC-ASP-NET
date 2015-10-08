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
    public partial class Form1 : Form
    {
        public List<Conta> contasList = new List<Conta>();

        public Form1()
        {

            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            double saldoInicial = Convert.ToDouble(txtSaldoInicial.Text);

            ContaPoupanca conta = new ContaPoupanca(saldoInicial);
            Cliente cliente = new Cliente() { 
                Nome = txtTitular.Text                 
            };

            conta.Titular = cliente;
            conta.Numero = int.Parse(txtNumero.Text);

            contasList.Add(conta);            

            LimpaForm();
        }

        private void LimpaForm()
        {
            txtNumero.Text = "";
            txtSaldoInicial.Text = "";
            txtTitular.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.ShowDialog();
        }

        public void teste(){
            MessageBox.Show("Hello World!");
            MessageBox.Show(txtNumero.Text);
        }
    }
}
