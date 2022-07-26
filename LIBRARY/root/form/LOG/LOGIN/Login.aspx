<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <%--login--%>
                <td colspan="2">
                    <asp:Label ID="lblLogin" runat="server" Text="LOGIN"></asp:Label>
                </td>
            </tr>
            <tr>
                <%--inserimento mail--%>
                <td>
                    <asp:Label ID="lblMail" runat="server" Text="Email: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <%--inserimento password--%>
                <td>
                    <asp:Label ID="lblPswd" runat="server" Text="Password: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtPswd" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnLogin" runat="server" Text="LOGIN" OnClick="btnLogin_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="2"><%--label registrazione (inserire h ref al posto di clicca qui) e login--%>
                    <asp:Label ID="lblRegistrazione" runat="server" Text="Non sei registrato? "></asp:Label><a href="../REGISTRAZIONE/Registrazione.aspx"><u> CLICCA QUI </u></a>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
