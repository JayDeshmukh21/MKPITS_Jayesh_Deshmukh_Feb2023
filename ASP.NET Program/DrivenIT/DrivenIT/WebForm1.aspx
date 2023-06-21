<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DrivenIT.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="text-center">
        <asp:Panel ID="Panel1" runat="server" style="margin-left: 387px" Width="500px">
            <div class="text-start">
                <strong>Transaction Form</strong><br /> &nbsp;Item Id&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;
                <asp:DropDownList ID="DropDownList1" runat="server" Width="167px">
                </asp:DropDownList>
                <br />
                Transaction Type :&nbsp;&nbsp; <strong>
                <asp:RadioButton ID="RadioButton1" runat="server" Text="Issue" />
                &nbsp;&nbsp;&nbsp;
                <asp:RadioButton ID="RadioButton2" runat="server" Text="Recieved" />
                </strong>
                <br />
                Transaction Qty&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;
                <asp:TextBox ID="TextBox1" runat="server" TextMode="Number"></asp:TextBox>
                <br />
                <br />
                Transation Date&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;
                <asp:TextBox ID="TextBox2" runat="server" TextMode="Date"></asp:TextBox>
                <br />
                <asp:Panel ID="Panel2" runat="server">
                    <div class="text-center">
                        <br />
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text=" Add " />
                        &nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button2" runat="server" Text=" Edit " />
                        &nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button3" runat="server" Text="Delete" />
                        <br />
                        <br />
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                        <br />
                        <asp:GridView ID="GridView1" runat="server">
                        </asp:GridView>
                    </div>
                </asp:Panel>
            </div>
        </asp:Panel>
    </div>
</asp:Content>
