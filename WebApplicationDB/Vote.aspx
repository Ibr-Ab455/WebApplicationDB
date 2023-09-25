<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Vote.aspx.cs" Inherits="WebApplicationDB.Vote" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownListParti" runat="server">
                <asp:ListItem Value="0">Velg Parti</asp:ListItem>
                <asp:ListItem Value="1">Høyre</asp:ListItem>
                <asp:ListItem Value="2">Ap</asp:ListItem>
                <asp:ListItem Value="3">Venstre</asp:ListItem>
                <asp:ListItem Value="4">Pp</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="ButtonVote" runat="server" Text="Stem" OnClick="ButtonVote_Click" />
        </div>
    </form>
</body>
</html>
