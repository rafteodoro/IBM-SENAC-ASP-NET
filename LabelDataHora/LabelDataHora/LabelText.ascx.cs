using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabelDataHora
{
    public partial class WebUserControlLabelText : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidaCondicao();
        }

        public void ValidaCondicao() 
        {
            if (IsPostBack)
            {
                double x;
                if (Double.TryParse(textBoxNumeroLetras.Text, out x))
                {
                    labelMensagem.Text = "É um número!";
                }
                else
                {
                    labelMensagem.Text = "É um texto!";
                }
            } 
        }
    }
}