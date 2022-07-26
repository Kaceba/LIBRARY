using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

public class LIBRI
{
    public LIBRI()
    {

    }

    public class AGGIORNADB
    {
        public int CodiceLibro;
        public int CodiceGenere;
        public string Titolo;
        public string Autore;
        public string Sinossi;
        public byte[] Copertina;
        // variabile copertina (immagine) public System.Drawing image;
        public string DataPrestito;
        public int Available;

        //insert
        public void Insert()
        {
            CONNESSIONE C = new CONNESSIONE();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "LIBRI_INSERT";
            cmd.Parameters.AddWithValue("@CodiceGenere", CodiceGenere);
            cmd.Parameters.AddWithValue("@Titolo", Titolo);
            cmd.Parameters.AddWithValue("@Autore", Autore);
            cmd.Parameters.AddWithValue("@Sinossi", Sinossi);
            cmd.Parameters.AddWithValue("@Copertina", Copertina);
            //cmd.Parameters.AddWithValue("@Copertina", Copertina);
            cmd.Parameters.AddWithValue("@DataPrestito", DataPrestito);
            cmd.Parameters.AddWithValue("@Available", Available);

            C.EseguiSPcmdparam(cmd);
        }

        //update
        public void Update()
        {
            CONNESSIONE C = new CONNESSIONE();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "LIBRI_UPDATE";
            cmd.Parameters.AddWithValue("@CodiceLibro", CodiceLibro);
            cmd.Parameters.AddWithValue("@CodiceGenere", CodiceGenere);
            cmd.Parameters.AddWithValue("@Titolo", Titolo);
            cmd.Parameters.AddWithValue("@Autore", Autore);
            cmd.Parameters.AddWithValue("@Sinossi", Sinossi);
            cmd.Parameters.AddWithValue("@Copertina", Copertina);
            //cmd.Parameters.AddWithValue("@Copertina", Copertina);
            cmd.Parameters.AddWithValue("@DataPrestito", DataPrestito);
            cmd.Parameters.AddWithValue("@Available", Available);

            C.EseguiSPcmdparam(cmd);
        }

    }

    //selectall
    public DataTable Select()
    {
        CONNESSIONE C = new CONNESSIONE();

        return C.EseguiSp("LIBRI_SELECTALL");
    }

    //selectone
    public DataTable Select(int CodiceLibro)
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "LIBRI_SELECTONE";
        cmd.Parameters.AddWithValue("@CodiceGenere", CodiceLibro);

        return c.EseguiSPselectparam(cmd);
    }

    //DELETE
    public void Delete(int CodiceLibro)
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "LIBRI_DELETE";
        cmd.Parameters.AddWithValue("@CodiceGenere", CodiceLibro);

        c.EseguiSPcmdparam(cmd);
    }
}
