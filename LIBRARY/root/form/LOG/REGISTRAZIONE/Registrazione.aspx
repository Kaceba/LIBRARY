<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registrazione.aspx.cs" Inherits="root_REGISTRAZIONE_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <table>
                <tr> <%--login--%>
                    <td colspan="2">
                        <asp:Label ID="lblRegistrazione" runat="server" Text="REGISTRAZIONE"></asp:Label>
                    </td>
                </tr>
                <tr><%--inserimento mail--%>
                    <td> 
                        <asp:Label ID="lblEmail" runat="server" Text="Email: "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    </td>
                </tr>                           
                <tr>                   
                    <td colspan="2">
                        <asp:Button ID="btnRegistrazione" runat="server" Text="REGISTRATI" OnClick="btnRegistrazione_Click" />
                    </td>
                </tr>             
            </table>
    </form>
</body>
</html>
