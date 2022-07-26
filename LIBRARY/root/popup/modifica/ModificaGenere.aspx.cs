using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ModificaTipiSpesePopUp : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Se non vi è nessun elemento selezionato impedisco il proseguimento
            if (Session["CodiceGenere"] == null)
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "ATTENZIONE", "alert('Seleziona una riga per poterla modificare')", true);
                return;
            }

            GENERI G = new GENERI();
            DataTable dt = G.Select(int.Parse(Session["CodiceGenere"].ToString()));

            txtGenere.Text = dt.Rows[0]["DescrizioneGenere"].ToString();
        }
    }

    protected void btnModifica_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtGenere.Text))
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "ERRORE", "alert('Campo inserito vuoto')", true);
            return;
        }

        GENERI.AGGIORNADB GA = new GENERI.AGGIORNADB();
        GENERI G = new GENERI();

        GA.CodiceGenere = int.Parse(Session["CodiceGenere"].ToString());
        GA.DescrizioneGenere = txtGenere.Text.Trim().ToString();

        if (G.CheckOne(GA.DescrizioneGenere.ToString()) == true)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "ERRORE", "alert('Nessuna modifica effettuata')", true);
            return;
        }

        GA.Update();

        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "SUCCESSO", "alert('Genere cambiato')", true);

        txtGenere.Text = "";

        Session["CodiceGenere"] = null;
    }
}