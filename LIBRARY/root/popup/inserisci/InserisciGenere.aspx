<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InserisciGenere.aspx.cs" Inherits="root_popup_inserisci_InserisciTipoSpesa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Genere:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtGenere" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnInvia" runat="server" Text="Invia" OnClick="btnInvia_Click"  />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
