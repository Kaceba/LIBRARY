using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class GENERI
{
    public GENERI()
    {

    }

    public class AGGIORNADB
    {
        public int CodiceGenere;
        public string DescrizioneGenere;

        //insert
        public void Insert() 
        {
            CONNESSIONE C = new CONNESSIONE();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "GENERI_INSERT";
            cmd.Parameters.AddWithValue("@DescrizioneGenere", DescrizioneGenere);

            C.EseguiSPcmdparam(cmd);
        }

        //update
        public void Update()
        {
            CONNESSIONE C = new CONNESSIONE();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "GENERI_UPDATE";
            cmd.Parameters.AddWithValue("CodiceGenere", CodiceGenere);
            cmd.Parameters.AddWithValue("DescrizioneGenere", DescrizioneGenere);

            C.EseguiSPcmdparam(cmd);
        }

    }

    //selectall
    public DataTable Select()
    {
        CONNESSIONE C = new CONNESSIONE();

        return C.EseguiSp("GENERI_SELECTALL");
    }

    //selectone
    public DataTable Select(int CodiceGenere)
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "GENERI_SELECTONE";
        cmd.Parameters.AddWithValue("@CodiceGenere", CodiceGenere);

        return c.EseguiSPselectparam(cmd);
    }

    //checkone
    public bool CheckOne(string DescrizioneGenere)
    {
        CONNESSIONE c = new CONNESSIONE();
        DataTable dt = new DataTable();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "GENERI_CHECKONE";
        cmd.Parameters.AddWithValue("@DescrizioneGenere", DescrizioneGenere);

        dt = c.EseguiSPselectparam(cmd);

        return dt.Rows.Count > 0;
    }
}

