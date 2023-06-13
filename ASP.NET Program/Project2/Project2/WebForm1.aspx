<%@ Page Title="" Language="C#" MasterPageFile="~/Store management system.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Project2.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" Width="500px">
    Item Entry page<br /> Date :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox5" runat="server" TextMode="Date"></asp:TextBox>
    <br />
    <br />
    <br />
        Item Name :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <br />
    <br />
        Category :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" Width="163px">
            <asp:ListItem>Electronics</asp:ListItem>
            <asp:ListItem>Consumable</asp:ListItem>
            <asp:ListItem>Furniture</asp:ListItem>
            <asp:ListItem>Stationary</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        Rate :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <br />
        Balance quantity :<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Insert" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Update" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button3" runat="server" Text="Delete" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button4" runat="server" Text="Search" />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
</asp:Panel>
</asp:Content>
