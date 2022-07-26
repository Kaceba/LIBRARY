using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class root_popup_modifica_ModificaUtenti : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Se non vi è nessun elemento selezionato impedisco il proseguimento
            if (Session["CodiceUtente"] == null)
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "ATTENZIONE", "alert('Seleziona una riga per poterla modificare')", true);
                return;
            }

            UTENTI U = new UTENTI();
            DataTable dt = U.SELECT(int.Parse(Session["CodiceUtente"].ToString()));

            ddlPermessi.SelectedValue = dt.Rows[0]["TipologiaUtente"].ToString();
        }
    }

    protected void btnModifica_Click(object sender, EventArgs e)
    {
        UTENTI U = new UTENTI();

        U.codUtente = int.Parse(Session["CodiceUtente"].ToString());
        U.tipologiaUtente = char.Parse(ddlPermessi.SelectedValue);
        U.abilitato = false;

        if(rdb1.Checked == true)
        {
            U.abilitato = true;
        }

        U.UPDATE();

        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione!", "alert('Dati modificati correttamente')", true);

        Session["CodiceUtente"] = null;
    }
}
