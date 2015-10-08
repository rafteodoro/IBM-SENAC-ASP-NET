using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabelDataHora
{
    public partial class AjaxTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DateTime session = (DateTime)Session["StartDateTime"];
            LabelTexto.Text = DateTime.Now.Subtract(session).Ticks.ToString();
            LabelTexto2.Text = DateTime.Now.Subtract(session).Ticks.ToString();
        }
    }
}