<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplicationDB.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link type="text/css" rel="stylesheet" media="all" href="Style.css" />

    
</head>
<body>
    <form id="form1" runat="server"> 

        <asp:Button ID="ButtonSearchLastName" runat="server" Text="søkLastName" OnClick="ButtonSearchLastName_Click" />
          <br />
        <asp:Button ID="ButtonSearchFirstName" runat="server" Text="søkFirstName" OnClick="ButtonSearchFirstName_Click" />
        <br />
        <asp:TextBox ID="TextBoxSearch" runat="server"></asp:TextBox>
         
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
         
                
           
       
    </form>
</body>
</html>
