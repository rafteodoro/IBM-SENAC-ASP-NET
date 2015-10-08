using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabelDataHora
{
    public partial class CookieTeste : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["MYCOOKIE"] != null)
                labelResposta.Text = Request.Cookies["MYCOOKIE"].Value;
            else
                labelResposta.Text = "";

            HttpCookie cookie = new HttpCookie("MYCOOKIE");
            cookie.Value = "TESTE COOKIE";
            cookie.HttpOnly = true;
            cookie.Expires = DateTime.Now.AddSeconds(15); ;
            Response.Cookies.Add(cookie);

            DateTime horaIniSessao = (DateTime)Session["StartDateTime"];
            TimeSpan tempoEmAberto = DateTime.Now.Subtract(horaIniSessao);

            labelHoraSessao.Text = "Tempo de Sessão: " + tempoEmAberto.TotalSeconds;

        }
    }
}