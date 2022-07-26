using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class root_popup_inserisci_InserisciTipoSpesa : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CaricaGeneri();
        }
    }

    protected void btnInvia_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtTitolo.Text) || string.IsNullOrEmpty(txtAutore.Text) || string.IsNullOrEmpty(txtSinossi.Text) 
            || string.IsNullOrEmpty(txtDataPrestito.Text) || (fileCopertina == null))
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ERRORE", "alert('Campi vuoti')", true);
            return;
        }

        LIBRI.AGGIORNADB LA = new LIBRI.AGGIORNADB();
        LA.Titolo = txtTitolo.Text.Trim();
        LA.Autore = txtAutore.Text.Trim();
        LA.CodiceGenere = int.Parse(ddlGenere.SelectedValue);
        LA.Sinossi = txtSinossi.Text.Trim();

        byte[] image = File.ReadAllBytes(fileCopertina);

        LA.Copertina = image;
        LA.DataPrestito = txtDataPrestito.Text.Trim();
        LA.Available = 1;

        if (rdb1.Checked == true)
        {
            LA.Available = 0;
        }
        
        LA.Insert();

        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "SUCCESSO", "alert('Libro inserito')", true);

        txtTitolo.Text = "";
        txtAutore.Text = "";
        txtSinossi.Text = "";
        txtDataPrestito.Text = "";

    }

    protected void CaricaGeneri()
    {
        GENERI G = new GENERI();
        ddlGenere.DataSource = G.SelectForDDL();
        ddlGenere.DataValueField = "CodiceGenere";
        ddlGenere.DataTextField = "DescrizioneGenere";
        ddlGenere.DataBind();
    }
}