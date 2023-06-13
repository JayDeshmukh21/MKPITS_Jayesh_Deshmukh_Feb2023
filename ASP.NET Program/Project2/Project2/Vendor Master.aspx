<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Vendor Master.aspx.cs" Inherits="Project2.Vendor_Master" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel1" runat="server" Height="327px" Width="500px">
                Date :<br />
                <br />
                <br />
                <br />
                <br />
                Vendor name :
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </asp:Panel>
        </div>
        <asp:Button ID="Button1" runat="server" Text="Insert" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Update" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Text="Delete" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button4" runat="server" Text="Search" />
    </form>
</body>
</html>
