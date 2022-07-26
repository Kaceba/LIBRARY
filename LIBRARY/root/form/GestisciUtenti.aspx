<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="GestisciUtenti.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

    <%--javascript popup--%>
    <link rel="stylesheet" href="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8.10/themes/base/jquery-ui.css" type="text/css" media="all" />
    <link rel="stylesheet" href="http://static.jquery.com/ui/css/demo-docs-theme/ui.theme.css" type="text/css" media="all" />
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.5.1/jquery.min.js"></script>
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8.10/jquery-ui.min.js"></script>
    <script src="../../JS/JS.js"></script>
    <%--css--%>
    <%--<link href="../../../CSS/CSS.css" rel="stylesheet" />--%>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <%--Bottoni per interagire con i dati della griglia, utilizzano gli script di jquery--%>

    <a id="btnModifica" href="../popup/modifica/ModificaUtenti.aspx">bottone per ModUtenti (placeholder) </a>

    <asp:Button ID="btnAggiorna" runat="server" Text="Aggiorna" OnClick="btnAggiorna_Click1" />

    <asp:GridView ID="griglia" runat="server" OnSelectedIndexChanged="griglia_SelectedIndexChanged" DataKeyNames="CodiceUtente">
        <Columns>
            <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Seleziona" ShowHeader="True" Text="Seleziona" />
        </Columns>
    </asp:GridView>


</asp:Content>

