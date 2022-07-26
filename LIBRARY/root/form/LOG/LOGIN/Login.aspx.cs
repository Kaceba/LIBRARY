using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        if (txtEmail.Text == "" || txtPswd.Text == "")
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('Errore dati non validi')", true);
            return;
        }

        UTENTI u = new UTENTI();
        u.email = txtEmail.Text.Trim();
        u.password = CRYPTA.Crypta(txtPswd.Text);

        try
        {
            Session["TipologiaUtente"] = u.RECUPERATIPOUTENTE();
        }

        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ERRORE", "alert('Riprovare')", true);

        }

        if (u.LOGIN() == true)
        {
            Response.Redirect("/root/Default.aspx");
        }

        else
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ATTENZIONE", "alert('Password o email errati')", true);
            return;
        }

    }
}