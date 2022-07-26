using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

public class MAIL
{
    public string mailUtente;
    public string rndCodice;

    public MAIL()
    {

    }
    public void mailInvia()
    {
        // invio una mail

        MailMessage mail = new MailMessage();

        SmtpClient client = new SmtpClient();
        string miouser = "doita05@setsistemi.it";
        string miapdw = "corsodoita";
        int porta = 25;
        string host = "setsistemi.it";

        // imposto il server smtp
        client.Credentials = new NetworkCredential(miouser, miapdw);
        client.Port = porta;
        client.Host = host;
        client.EnableSsl = false;

        //imposto la mail
        mail.Subject = "Conferma registrazione";
        mail.Body = "Benvenuto! Ecco il tuo codice di conferma: "+rndCodice; // si può mettere html qui dentro
        mail.IsBodyHtml = true;
        mail.To.Add(new MailAddress(mailUtente));
        mail.From = new MailAddress("doita05@setsistemi.it");

        client.Send(mail);
    }
}
