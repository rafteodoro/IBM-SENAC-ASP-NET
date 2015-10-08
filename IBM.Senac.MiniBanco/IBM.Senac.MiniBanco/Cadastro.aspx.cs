using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IBM.Treinamento.Senac.Contas;

namespace IBM.Senac.MiniBanco
{
    public partial class Cadastro : System.Web.UI.Page
    {
        List<Conta> listaContas = new List<Conta>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) 
            {
                CadastraCliente();
                VisualizaClientes();
            }
        }
        public void CadastraCliente() 
        {
            if (CheckBoxListTipoConta.SelectedValue == "C")
            {
                ContaCorrente novaContaCorrente = new ContaCorrente(Convert.ToInt32(TextBoxNumero.Text));
                novaContaCorrente.Titular.Nome = TextBoxNome.Text;
                novaContaCorrente.Saldo = Convert.ToDouble(TextBoxSaldoInicial.Text);
                listaContas.Add(novaContaCorrente);
            }
            else
            {
                ContaCorrente novaContaPoupanca = new ContaCorrente(Convert.ToInt32(TextBoxNumero.Text));
                novaContaPoupanca.Titular.Nome = TextBoxNome.Text;
                novaContaPoupanca.Saldo = Convert.ToDouble(TextBoxSaldoInicial.Text);
                listaContas.Add(novaContaPoupanca);
            }
        }
        public void VisualizaClientes() 
        {
            foreach (var item in listaContas)
            {   
                ListBoxClientes.Items.Add(item.Numero.ToString());
                ListBoxClientes.Items.Add(item.Titular.Nome.ToString());
                ListBoxClientes.Items.Add(item.Saldo.ToString());
            }
        }
    }
}