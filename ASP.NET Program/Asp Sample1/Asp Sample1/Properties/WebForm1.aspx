<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Asp_Sample1.Properties.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        Sample 1<p style="text-align: center; font-weight: 700">
            Age
            <asp:TextBox ID="TextBox1" runat="server" BorderStyle="Groove"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" style="font-weight: 700" Text="OK" Width="81px" OnClick="Button1_Click" />
        <br />
        <hr />
        <p>
            <strong>Result :</strong>  
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
