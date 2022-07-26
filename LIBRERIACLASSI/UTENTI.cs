using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Descrizione di riepilogo per UTENTI
/// </summary>
public class UTENTI
{
    public int codUtente;
    public char tipologiaUtente;
    public int codicePersonale;
    public bool abilitato;
    public string email;
    public string password;

    public UTENTI()
    {

    }
    public UTENTI(string email, string password)
    {
        this.email = email;
        this.password = password;
    }

    #region CONTROLLI

    public bool REGISTRATO()
    {
        SqlCommand cmd = new SqlCommand();
        CONNESSIONE conn = new CONNESSIONE();

        cmd.CommandText = "UTENTI_REGISTRATO";
        cmd.Parameters.AddWithValue("@email", email);

        DataTable dt = conn.EseguiSPselectparam(cmd);

        return dt.Rows.Count > 0;
    }

    public bool ABILITATO()
    {
        SqlCommand cmd = new SqlCommand();
        CONNESSIONE conn = new CONNESSIONE();

        cmd.CommandText = "UTENTI_ABILITATO";
        cmd.Parameters.AddWithValue("@email", email);

        DataTable dt = conn.EseguiSPselectparam(cmd);

        return dt.Rows.Count > 0;
    }

    public bool LOGIN()
    {
        SqlCommand cmd = new SqlCommand();
        CONNESSIONE conn = new CONNESSIONE();

        cmd.CommandText = "UTENTI_LOGIN";
        cmd.Parameters.AddWithValue("@email", email);
        cmd.Parameters.AddWithValue("@password", password);

        DataTable dt = conn.EseguiSPselectparam(cmd);

        return dt.Rows.Count > 0;
    }

    #endregion

    #region SELETTORI

    public DataTable SELECT() //SelectAll
    {
        SqlCommand cmd = new SqlCommand();
        CONNESSIONE C = new CONNESSIONE();

        cmd.CommandText = "UTENTI_SELECTALL";

        return C.EseguiSPselectparam(cmd);
    }
    public DataTable SELECT(int CodiceUtente) //SelectOne
    {
        SqlCommand cmd = new SqlCommand();
        CONNESSIONE C = new CONNESSIONE();

        cmd.CommandText = "UTENTI_SELECTONE";
        cmd.Parameters.AddWithValue("@CodiceUtente", CodiceUtente);

        return C.EseguiSPselectparam(cmd);
    }

    public string RECUPERATIPOUTENTE()
    {
        SqlCommand cmd = new SqlCommand();
        CONNESSIONE conn = new CONNESSIONE();

        cmd.CommandText = "UTENTI_GETUSERTYPE";
        cmd.Parameters.AddWithValue("@email", email);

        DataTable dt = conn.EseguiSPselectparam(cmd);

        return dt.Rows[0]["TipologiaUtente"].ToString();
    }


    #endregion

    #region OPERAZIONI

    public void Insert()
    {
        SqlCommand cmd = new SqlCommand();
        CONNESSIONE conn = new CONNESSIONE();

        cmd.CommandText = "UTENTI_INSERT";
        cmd.Parameters.AddWithValue("@email", email);
        cmd.Parameters.AddWithValue("@password", password);

        conn.EseguiSPcmdparam(cmd);
    }

    public void UpdatePWD()
    {
        SqlCommand cmd = new SqlCommand();
        CONNESSIONE conn = new CONNESSIONE();

        cmd.CommandText = "UTENTI_UPDATE_PASSWORD";
        cmd.Parameters.AddWithValue("@email", email);
        cmd.Parameters.AddWithValue("@password", password);

        conn.EseguiSPselectparam(cmd);
    }

    public void UPDATE()
    {
        SqlCommand cmd = new SqlCommand();
        CONNESSIONE conn = new CONNESSIONE();

        cmd.CommandText = "UTENTI_UPDATE";
        cmd.Parameters.AddWithValue("@CodiceUtente", codUtente);
        cmd.Parameters.AddWithValue("@TipologiaUtente", tipologiaUtente);
        cmd.Parameters.AddWithValue("@Abilitato", abilitato);

        conn.EseguiSPcmdparam(cmd);
    }

    public void UpdateAbiltato()
    {
        SqlCommand cmd = new SqlCommand();
        CONNESSIONE conn = new CONNESSIONE();

        cmd.CommandText = "UTENTI_UPDATE_ABILITATO";
        cmd.Parameters.AddWithValue("@abilitato", abilitato);
        cmd.Parameters.AddWithValue("@codicepersonale", codicePersonale);
        cmd.Parameters.AddWithValue("@codiceutente", codUtente);

        conn.EseguiSPselectparam(cmd);
    }

    #endregion

}
