<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplicationDB.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
</head>
<body>
    <form id="form1" runat="server">

        <asp:Button ID="ButtonSearchLastName" runat="server" Text="søk" OnClick="ButtonSearchLastName_Click" />
          <br />
        <asp:TextBox ID="TextBoxLastName" runat="server"></asp:TextBox>
         
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
         
                
           
       
    </form>
</body>
</html>
