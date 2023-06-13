<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Project1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Panel ID="Panel1" runat="server" Height="208px" Width="490px">
            Item Entry<br />
            <br />
            Item Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            Category&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :
            <asp:DropDownList ID="DropDownList1" runat="server" Width="165px">
            </asp:DropDownList>
            <br />
            Rate&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            Balance quantity :
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" Height="146px" Width="490px">
            Department<br />
            <br />
            <br />
            Department name :
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </asp:Panel>
        <asp:Panel ID="Panel3" runat="server" Height="135px" Width="490px">
            Vendor Master<br />
            <br />
            <br />
            Vendor Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        </asp:Panel>
    </form>
</body>
</html>
