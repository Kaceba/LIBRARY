<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ModificaUtenti.aspx.cs" Inherits="root_popup_modifica_ModificaUtenti" %>

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
                        <asp:DropDownList ID="ddlPermessi" runat="server">
                            <asp:ListItem Value="U">Utente</asp:ListItem>
                            <asp:ListItem Value="O">Operatore</asp:ListItem>
                            <asp:ListItem Value="A">Amministratore</asp:ListItem>
                            <asp:ListItem Value="S">Super Admin</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        Utente Abilitato:
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnModifica" runat="server" Text="Modifica" OnClick="btnModifica_Click" />
                    </td>
                    <td>
                        <asp:RadioButton ID="rdb2" runat="server" GroupName="Commessa" Checked="True" Text="No" />
                        <asp:RadioButton ID="rdb1" runat="server" GroupName="Commessa" Text="Si" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
