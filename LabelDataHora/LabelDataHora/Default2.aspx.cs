using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabelDataHora
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //DateTime date = new DateTime();
            //labelHoraData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            //labelHoraData.Text = DateTime.Now.ToString("///"+"dd/MM/yyyy"+" ----- "+"hh:mm:ss"+"///");
            //if (checkBoxMudaCor.Checked == true) 
            //{
            //    textBoxNome.BorderColor =  
            //}


        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ButtonCalcular_Click(object sender, EventArgs e)
        {
            if (IsPostBack) 
            {
                    ValidaCampos();
                    labelResultado.Text = CalculaContas(textBoxConsumoAferido.Text);
            }
            
        }

        public string CalculaContas(string textConsumo) 
        {
            textConsumo = textBoxConsumoAferido.Text;
            double calcula = 0.0;
            if (radioButtonListTipoConta.SelectedValue == "Agua")
            {
                calcula = Convert.ToDouble(textConsumo) * 0.23;
            }
            else if (radioButtonListTipoConta.SelectedValue == "Luz")
            {
                calcula = Convert.ToDouble(textConsumo) * 0.74;
            }
            else if (radioButtonListTipoConta.SelectedValue == "Gas")
            {
                calcula = Convert.ToDouble(textConsumo) * 0.35;
            }

            if (DropDownListDesconto.SelectedItem.Text == "Sim")
            {
                calcula = calcula - (calcula * 0.20);
            }

            return textConsumo = Convert.ToString(calcula);
        }

        public void ValidaCampos() 
        {
            labelErroConsumoAferido.Visible = false;
            double validaTexto;
                if (Double.TryParse(textBoxConsumoAferido.Text, out validaTexto))
                {
                    labelErroConsumoAferido.Text = "Digite apenas Números!";
                    labelErroConsumoAferido.Visible = true;                    
                    textBoxConsumoAferido.Focus();
                }
        }

        protected void buttonValidar_Click(object sender, EventArgs e)
        {
            LabelText.ValidaCondicao();
        }
    }
}