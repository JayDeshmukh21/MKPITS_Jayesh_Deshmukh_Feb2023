<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Project1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 213px;
        }
        .auto-style2 {
            text-align: left;
            height: 167px;
        }
        .auto-style3 {
            margin-left: 215px;
        }
        .auto-style4 {
            margin-left: 217px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel1" runat="server" CssClass="auto-style1" Height="212px" Width="378px">
                <div class="auto-style2">
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
                </div>
            </asp:Panel>
        </div>
        <asp:Panel ID="Panel2" runat="server" CssClass="auto-style3" Height="153px" Width="376px">
            Department<br />
            <br />
            <br />
            Department name :
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </asp:Panel>
        <asp:Panel ID="Panel3" runat="server" CssClass="auto-style4" Height="121px" Width="370px">
            Vendor Master<br />
            <br />
            Vendor Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        </asp:Panel>
    </form>
</body>
</html>
