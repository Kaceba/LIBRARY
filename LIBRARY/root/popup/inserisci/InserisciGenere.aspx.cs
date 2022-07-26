using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class root_popup_inserisci_InserisciTipoSpesa : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnInvia_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtGenere.Text.Trim()))
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ERRORE", "alert('Campo vuoto')", true);
            return;
        }

        GENERI.AGGIORNADB GA = new GENERI.AGGIORNADB();
        GENERI G = new GENERI();

        GA.DescrizioneGenere = txtGenere.Text.ToString();

        if (G.CheckOne(GA.DescrizioneGenere) == true)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "ERRORE", "alert('Questo genere esiste già')", true);
            return;
        }

        // se non esiste faccio insert
        GA.Insert();

        // Svuoto i campi  e aggiorno la griglia
        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "SUCCESSO", "alert('Genere inserito')", true);

        txtGenere.Text = "";
    }
}