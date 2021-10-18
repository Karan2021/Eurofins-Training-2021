<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="EventManagementApp.SignUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-8 mx-auto">
                <div class="card" >
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img width="100px" src="images/loginImage.png" />
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h4>User Sign Up</h4>
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
                    <center>
                    <div class="row">
                     
                            <div class="col-md-6">
                             <label>First Name</label>
                            <asp:TextBox CssClass="form-control" ID="txtFirstName" runat="server" placeholder="First Name"></asp:TextBox>
                            </div>
                        
                    
                            <div class="col-md-6">
                                <label>Last Name</label>
                            <asp:TextBox CssClass="form-control" ID="txtLastName" runat="server" placeholder="Last Name"></asp:TextBox>
                            </div>
               
                      </div>
                    </center>
                    <br />
                    <center>
                    <div class="row">
                     
                            <div class="col-md-6">
                             <label>Email ID</label>
                            <asp:TextBox CssClass="form-control" ID="txtEmailID" runat="server" placeholder="Email"></asp:TextBox>
                            </div>
                        
                    
                            <div class="col-md-6">
                                <label>Password</label>
                            <asp:TextBox CssClass="form-control" ID="txtPassword" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
                            </div>
               
                      </div>
                    </center>
                    <br />
                    <center>
                    <div class="row">
                     
                            <div class="col-md-6">
                             <label>Phone Number</label>
                            <asp:TextBox CssClass="form-control" ID="txtPhone" runat="server" placeholder="Phone Number"></asp:TextBox>
                            </div>
                        
                    
                            <div class="col-md-6">
                                <label>Address</label>
                            <asp:TextBox CssClass="form-control" ID="txtAddress" runat="server" placeholder="Address"></asp:TextBox>
                            </div>
               
                      </div>
                    </center>
                    <br />
                    
                            <div class="form-group">
                                <center>
                                <asp:Button CssClass="btn btn-primary btn-block" ID="btnSignUp" runat="server" Text="Sign Up" OnClick="btnSignUp_Click" />
                          
                            </center>
                             </div>
                            <br />
                            <br />
                        </div>
                  



                </div>
            </div>
        </div>

</asp:Content>
