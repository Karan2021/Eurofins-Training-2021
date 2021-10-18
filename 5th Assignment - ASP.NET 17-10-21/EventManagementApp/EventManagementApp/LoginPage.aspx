<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="EventManagementApp.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <!-- CSS only -->
<!-- CSS only -->
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet">
<link rel="stylesheet" href="Shadow.css" />
</head>
<body>
    
    <form id="form1" runat="server">
        <br />
        <br />
        <div align="center" class="container jumbotron bg-light boxshadow" style="width:30%">
            <form>
                <br />
                <div class="card-header-pills bg-dark text-white" style="width:80%">
                    <h2>Login Page</h2>
                </div>
                <br />
                <div class="form-group" style="width:80%">
                    <label class="text-dark" for="emailLabel">Email Address</label>
                    <div class="input-group mb-2">
                        <div class="input-group-prepend">
                            <div class="input-group-text">@</div>
                        </div>
                        <asp:TextBox ID="tbEmailId" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="form-group">
                    <label class="text-dark" for="passLabel">Password</label>
                     <asp:TextBox ID="tbPassword" runat="server" CssClass="form-control" TextMode="Password" Width="80%"></asp:TextBox>
                </div>
                <div>

                </div>
                <br />
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="btn btn-primary" />
                <div>
                    <asp:LinkButton ID="lbtnForgotPassword" runat="server" CssClass="btn btn-link">Forgot Password?</asp:LinkButton><br />
                    <asp:LinkButton ID="lbtnRegister" runat="server" CssClass="btn btn-link">New User!</asp:LinkButton>
                </div>
            </form>
        </div>
    </form>
</body>
</html>
