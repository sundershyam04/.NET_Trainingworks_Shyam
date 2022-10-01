<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProductsWebApp.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: auto; margin-right: auto; text-align: center;">
                <h1>Login</h1>
        </div>
        <asp:Panel ID="Panel1" runat="server" Height="610px">
            &nbsp;&nbsp;<br />
             <div style="margin-left: auto; margin-right: auto; text-align: center;">
            <asp:Label ID="lblusername" runat="server" BackColor="White" Text="Username" ToolTip="Enter UserName"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtusername" runat="server" BorderColor="#00CC00" BorderStyle="Solid" Width="203px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="validusername" runat="server" ControlToValidate="txtusername" ErrorMessage="Username is required" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            <br />
                 &nbsp;&nbsp;<asp:Label ID="lblpassword" runat="server" Text="Password"></asp:Label>
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtpassword" runat="server" BorderColor="#00CC00" BorderStyle="Solid"  ToolTip="Enter Password" Width="203px" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="validpassword" runat="server" ControlToValidate="txtpassword" ErrorMessage="Password is required" ForeColor="Red"></asp:RequiredFieldValidator>
            &nbsp;&nbsp;
                  
                 <br />
                 
            <br />
                <asp:Button ID="btnsubmit" runat="server" BorderColor="Aqua" Height="34px" OnClick="btnsubmit_Click" Text="Submit" Width="80px" />
                
            <br />
             
            <asp:Label ID="lblloginstatus" runat="server" ForeColor ="Red"></asp:Label>
            <br />
            <br />
                  </div>
            &nbsp;</asp:Panel>
    </form>
</body>
</html>
