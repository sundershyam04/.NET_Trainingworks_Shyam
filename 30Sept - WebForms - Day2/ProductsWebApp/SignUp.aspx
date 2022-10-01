<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="ProductsWebApp.SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>SignUp</title>
</head>
<body>
     <div style="margin-left: auto; margin-right: auto; text-align: center;"><h1>Customer SignUp</h1>
         </div>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblfirstname" runat="server" Text="Firstname"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;
        <asp:TextBox ID="txtfirstname" runat="server" MaxLength="10"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="requiredfirstname" runat="server" ErrorMessage="Firstname is required" ForeColor="#CC0000" ControlToValidate="txtfirstname"></asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:Label ID="lbllastname" runat="server" Text="Lastname"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;
        <asp:TextBox ID="txtlastname" runat="server" MaxLength="10"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="requiredlastname" runat="server" ErrorMessage="Lastname is required" ForeColor="#CC0000" ControlToValidate="txtlastname"></asp:RequiredFieldValidator>
&nbsp;<br />
        <br />
        <br />
        <asp:Label ID="lbldob" runat="server" Text="Date of Birth"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;
        <asp:Calendar ID="caldob" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" OnSelectionChanged="caldob_SelectionChanged" ShowGridLines="True" Width="220px">
            <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
            <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
            <OtherMonthDayStyle ForeColor="#CC9966" />
            <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
            <SelectorStyle BackColor="#FFCC66" />
            <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
            <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
        </asp:Calendar>
        <br />
        <asp:Label ID="lbldobsesc" runat="server" Text="you have selected :"></asp:Label>
&nbsp;<asp:Label ID="lbldobfinal" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:Label ID="lblcity" runat="server" Text="City"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;
        <asp:TextBox ID="txtcity" runat="server" MaxLength="10"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="requiredcity" runat="server" ErrorMessage="City is required" ForeColor="#CC0000" ControlToValidate="txtcity"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label ID="lblstate" runat="server" Text="State"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;
        <asp:TextBox ID="txtstate" runat="server" MaxLength="10"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="requiredstate" runat="server" ErrorMessage="State is required" ForeColor="#CC0000" ControlToValidate="txtstate"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Button ID="btnsigup" runat="server" OnClick="btnsigup_Click" Text="SignUp" />
&nbsp;
        <br />
    </form>
</body>
</html>
