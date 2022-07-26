<%@ Page Language="C#" AutoEventWireup="true" CodeFile="registazione_conferma.aspx.cs" Inherits="registazione_conferma" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Inserisci nuovamente l'email: <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <br />
            Inserisci il codice di conferma: <asp:TextBox ID="txtCodice" runat="server"></asp:TextBox>
            <br />
            Inserisci la nuova password: <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <asp:Button ID="btnInvia" runat="server" Text="Invia" OnClick="btnInvia_Click" />
        </div>
    </form>
</body>
</html>
