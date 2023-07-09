<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Author.aspx.cs" Inherits="OnlineBookShop.Views.Admin.Author" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyContent" runat="server">
     <div class="container-fluid">
        <div class="row">
            <div class="col">
                <h3 class="text-center">Manage Authors</h3>
            </div>
        </div>
        <div class="row">
            <div class="col-md-4">
                <div class="mb-3">
                    <label for="" class="form-label text-success">Author Name</label>
                    <input type="text" placeholder="@Name" autocomplete="off" class="form-control" />
                </div>
                <div class="mb-3">
                    <label for="" class="form-label text-success">Author Gender</label>
                    <asp:DropDownList ID="DropDownList2" runat="server"  class="form-control">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="mb-3">
                    <label for="" class="form-label text-success">Country</label>
                    
                    <asp:DropDownList ID="DropDownList1" runat="server"  class="form-control">
                    <asp:ListItem>USA</asp:ListItem>
                    <asp:ListItem>INDIA</asp:ListItem>
                    <asp:ListItem>FRANCE</asp:ListItem>
                    <asp:ListItem>UK</asp:ListItem>
                    <asp:ListItem>SPAIN</asp:ListItem>
                    <asp:ListItem>Other</asp:ListItem>
                    </asp:DropDownList>
                    

                </div>
                <div class="row">
                    <div class="col d-grid"><asp:Button Text="Update" runat="server" CssClass="btn-warning btn-block btn"/></div>
                    <div class="col d-grid"><asp:Button Text="Save" runat="server" CssClass="btn-success btn-block btn"/></div>
                    <div class="col d-grid"><asp:Button Text="Delete" runat="server" CssClass="btn-danger btn-block btn"/></div>
                </div>
            </div>
            <div class="col-md-8">
                <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
