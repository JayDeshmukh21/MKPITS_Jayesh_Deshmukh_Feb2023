<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Name and password.aspx.cs" Inherits="Validation.Properties.Name_and_password" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 130px;
        }
        .auto-style3 {
            width: 265px;
        }
        .auto-style4 {
            width: 130px;
            height: 26px;
        }
        .auto-style5 {
            width: 265px;
            height: 26px;
        }
        .auto-style6 {
            height: 26px;
        }
        .auto-style7 {
            width: 265px;
            text-align: center;
        }
        .auto-style8 {
            width: 265px;
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            form validation</div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">first name</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox1" runat="server" Width="246px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Enter Proper name">fill the first name</asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">password</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox2" runat="server" BorderStyle="Solid" TextMode="Password" Width="243px"></asp:TextBox>
                </td>
                <td>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox2" ControlToValidate="TextBox3" ErrorMessage="Password dosen't match"></asp:CompareValidator>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">re-enter pass</td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox3" runat="server" BorderStyle="Dashed" TextMode="Password" Width="241px"></asp:TextBox>
                </td>
                <td class="auto-style6"></td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">age</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox4" runat="server" BorderStyle="Solid" TextMode="Number" Width="123px"></asp:TextBox>
                </td>
                <td>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox4" Display="Dynamic" ErrorMessage="enter proper age" MaximumValue="100" MinimumValue="18" Type="Integer">fill age section</asp:RangeValidator>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">email</td>
                <td class="auto-style8">
                    <asp:TextBox ID="TextBox5" runat="server" TextMode="Email" Width="251px"></asp:TextBox>
                </td>
                <td>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox5" Display="Dynamic" ErrorMessage="please enter proper email">Enter your email</asp:RegularExpressionValidator>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Date</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox6" runat="server" TextMode="Date"></asp:TextBox>
                </td>
                <td>
                    <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="TextBox6" ErrorMessage="Please Enter proper date">Enter date</asp:CustomValidator>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style7">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="OK" Width="66px" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Details</td>
                <td class="auto-style3">
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    </form>
</body>
</html>
