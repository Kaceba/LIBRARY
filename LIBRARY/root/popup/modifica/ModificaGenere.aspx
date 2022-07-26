<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ModificaGenere.aspx.cs" Inherits="ModificaTipiSpesePopUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
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
                        <asp:Button ID="btnModifica" runat="server" Text="Modifica" OnClick="btnModifica_Click"  />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
