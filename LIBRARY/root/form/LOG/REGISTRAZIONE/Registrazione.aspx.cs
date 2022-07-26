using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class root_REGISTRAZIONE_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnRegistrazione_Click(object sender, EventArgs e)
    {
        if(string.IsNullOrEmpty(txtEmail.Text))
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('Errore dati non validi')", true);
            return;
        }

        //passo la mail al database e creo la pwd temporanea 
        string email = txtEmail.Text;
        string password = GenerazionePassword();

        MAIL m = new MAIL();
        m.mailUtente = email;
        m.rndCodice = password;
        m.mailInvia();

        // reindirizzo l'utente alla pagina di login passandogli il codice generato randomicamente
        Response.Redirect("registazione_conferma.aspx?rndCodice=" + password);

        UTENTI u = new UTENTI();
        u.email = email;
        u.password = password;
        u.Insert();
    }

    protected string GenerazionePassword()
    {
        string pwd;

        Random rnd = new Random();
        int num = rnd.Next(100000, 1000000);

        pwd = num.ToString();
        return pwd;
    }
}