<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="ProductsWebApp.Products" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Products</title>
</head>
<body>
 <div style="margin-left: auto; margin-right: auto; text-align: center;">
    <h1>Products</h1>
     </div>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblprodid" runat="server" Text="Product ID "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;
       
        <asp:TextBox ID="txtprodid" runat="server" BorderColor="#FF6600" ForeColor="#FF6666" MaxLength="4" TextMode="Number" ></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="requiredid" runat="server" ControlToValidate="txtprodid" ErrorMessage="Product Id is required" ForeColor="#CC0000"></asp:RequiredFieldValidator>
        <br />
        <br />
        <br />
        <asp:Label ID="lblprodname" runat="server" Text="Product Name"></asp:Label>
       
    &nbsp; :&nbsp;&nbsp;
        <asp:TextBox ID="txtprodname" runat="server" BorderColor="#FF6666" MaxLength="10"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="requiredname" runat="server" ControlToValidate="txtprodname" ErrorMessage="Product Name is required" ForeColor="#CC0000"></asp:RequiredFieldValidator>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnprodsubmit" runat="server" BorderColor="#009933" OnClick="btnprodsubmit_Click" Text="Insert to database" />
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lbldbstatus" runat="server" BorderColor="#6699FF" BorderStyle="Solid" ForeColor="#FF6600"></asp:Label>
       
    </form>
</body>
</html>
