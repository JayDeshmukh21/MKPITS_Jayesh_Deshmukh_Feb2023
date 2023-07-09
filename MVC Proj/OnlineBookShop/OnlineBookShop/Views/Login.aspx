<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="OnlineBookShop.Views.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet"  href="../Assets/Lib/css/bootstrap.min.css" />
</head>
<body>
    <div class="container-fluid">
        <div class="row mt-5 mb-5">

        </div>
        <div class="row">
            <div class ="col-md-4">

            </div>
            <div class ="col-md-4">
                <form id="form1" runat="server">
                    <div>
                        <div class="row">
                            <div class="col-md-4"></div>
                            <div class="col-md-4">
                                <img src="../Assets/Images/books2.jpg.png" class="align-content-center" />

                            </div>
                        </div>
                        
                    </div>
                    <div class="mt-3">
                        <label for="" class="form-label">User Name</label>
                    <input type="text" placeholder="User Name" autocomplete="off" class="form-control" id="UnameTo" />
                    </div>
                    <div class="mt-3">
                        <label for="" class="form-label">Password</label>
                    <input type="password" placeholder="Password" autocomplete="off" class="form-control" id="PasswordTo" />
                    </div>
                    <div class="mt-3 d-grid">
                       <asp:Button Text="Login" runat="server" CssClass="btn-success btn" ID="LoginBtn" OnClick="LoginBtn_Click"/>
                    </div>
                </form>
            </div>
             <div class ="col-md-4">

            </div>
        </div>
    </div>
    
</body>
</html>
