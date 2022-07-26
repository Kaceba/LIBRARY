using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CaricaGriglia();
    }
    protected void btnAggiorna_Click1(object sender, EventArgs e)
    {
        CaricaGriglia();
    }

    protected void griglia_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["CodiceUtente"] = griglia.SelectedDataKey[0];
    }

    public void CaricaGriglia()
    {
        UTENTI U = new UTENTI();
        griglia.DataSource = U.SELECT();
        griglia.DataBind();
    }

}
