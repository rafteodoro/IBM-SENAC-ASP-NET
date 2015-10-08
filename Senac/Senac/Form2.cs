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
    public partial class Form2 : Form
    {
        Form1 form1 = new Form1();

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 form)
        {
            form1 = form;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lvwListaContas.Columns.Add("Titular", Convert.ToInt16(lvwListaContas.Width * 0.60));
            lvwListaContas.Columns.Add("Numero", Convert.ToInt16(lvwListaContas.Width * 0.15));
            lvwListaContas.Columns.Add("Saldo", Convert.ToInt16(lvwListaContas.Width * 0.15));
            lvwListaContas.View = View.Details;

            ListaContas();
        }

        private void ListaContas()
        {
       
            foreach (var item in form1.contasList)
            {
                ListViewItem listViewItem = new ListViewItem();

                listViewItem.Text = item.Titular.Nome;
                listViewItem.SubItems.Add(item.Numero.ToString());
                listViewItem.SubItems.Add(item.Saldo.ToString());

                lvwListaContas.Items.Add(listViewItem);
            }     
        }

        private void button1_Click(object sender, EventArgs e)
        {        
            form1.teste();
            this.Close();
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            ContaPoupanca conta = new ContaPoupanca(0);

            string numero = lvwListaContas.SelectedItems[0].SubItems[1].Text;

            foreach (var item in form1.contasList)
	        {
                if (item.Numero == Convert.ToInt16(numero))
                {
                    conta = (ContaPoupanca)item;
                }
	        }

            frmDeposito deposito = new frmDeposito(conta);
            deposito.ShowDialog();
        }
    }
}
