using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        UTENTI u = new UTENTI();
        string tipologiaUtente = Session["TipologiaUtente"].ToString();

        if (tipologiaUtente != "S")
        {
            GestioneUtenti.Visible = false;
        }
    }

    protected void GestioneUtenti_Click(object sender, EventArgs e)
    {
        Response.Redirect("/root/form/GestisciUtenti.aspx");
    }
}
