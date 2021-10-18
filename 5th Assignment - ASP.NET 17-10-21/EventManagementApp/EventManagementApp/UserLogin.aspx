<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="UserLogin.aspx.cs" Inherits="EventManagementApp.UserLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-4 mx-auto">

                <div class="card" >
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img width="150px" src="images/loginImage.png" />
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h3>User Login</h3>
                                </center>
                            </div>
                        </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <center>
                                    <hr />
                                </center>
                            </div>
                        </div>
                    <div class="row">
                            <div class="col">
                             
                                <div class="form-group">
                                    <center>
                                    <asp:TextBox CssClass="form-control" ID="txtUserId" runat="server" placeholder="User ID" Width="80%"></asp:TextBox>
                                    </center>
                            </div>
                           <br />
                            <div class="form-group">
                                <center>
                                <asp:TextBox CssClass="form-control" ID="txtPassword" runat="server" placeholder="Password" TextMode="Password" Width="80%" ></asp:TextBox>
                                </center>
                            </div>
                                <br />
                            <div class="form-group">
                                <center>
                                <asp:Button CssClass="btn btn-primary btn-block" ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
                            
                                
                            
                                <a href="SignUp.aspx">
                                    <input class="btn btn-info" id="btnSignUp" type="button" value="Sign Up" /></a>
                            </center>
                             </div>
                            <br />
                            <br />
                        </div>
                    </div>



                </div>
            </div>
        </div>
    </div>
</asp:Content>
