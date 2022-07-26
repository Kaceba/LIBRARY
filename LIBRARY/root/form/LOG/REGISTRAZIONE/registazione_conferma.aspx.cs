using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class registazione_conferma : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnInvia_Click(object sender, EventArgs e)
    {
        //mi salvo in una variabile il codice random preso dalla pagina "registrazione" e istanzio un bool
        string passwordTemp = Request.QueryString["rndCodice"].ToString();

        UTENTI u = new UTENTI();
        u.email = txtEmail.Text.Trim();
        u.password = passwordTemp;
        u.Insert();

        if (txtCodice.Text == passwordTemp)
        {
            if (u.REGISTRATO() == true)
            {
                string nuovaPassword = CRYPTA.Crypta(txtPassword.Text.Trim());
                u.password = nuovaPassword;

                u.UpdatePWD();
            }
        }

        Response.Redirect("/root/form/LOG/LOGIN/Login.aspx");
    }
}