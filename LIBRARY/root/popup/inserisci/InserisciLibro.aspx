<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InserisciLibro.aspx.cs" Inherits="root_popup_inserisci_InserisciTipoSpesa" %>

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
                        <asp:Label ID="Label2" runat="server" Text="Titolo:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtTitolo" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Autore:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtAutore" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Genere:"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlGenere" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="Sinossi:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtSinossi" runat="server" TextMode="MultiLine"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label6" runat="server" Text="Copertina:"></asp:Label>
                    </td>
                    <td>
                        <asp:FileUpload ID="fileCopertina" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label7" runat="server" Text="DataPrestito:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtDataPrestito" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Disponibile:"></asp:Label>
                    </td>
                    <td>
                        <asp:RadioButton ID="rdb2" runat="server" GroupName="Commessa" Checked="True" Text="Si" />
                        <asp:RadioButton ID="rdb1" runat="server" GroupName="Commessa" Text="No" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnInvia" runat="server" Text="Invia" OnClick="btnInvia_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
