<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="UserProfile.aspx.cs" Inherits="EventManagementApp.UserProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-5">
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
                                    <h4>Your Profile</h4>
                                    <span>Account Status - </span>
                                    <asp:Label class="badge rounded-pill bg-info text-dark" ID="Label1" runat="server" Text="Active"></asp:Label>
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
                    <center>
                    <asp:Label class="badge rounded-pill bg-info text-dark" ID="Label2" runat="server" Text="Login Credentials"></asp:Label>
         
                    <div class="row">
                            
                            <div class="col-md-4">
                            <br />
                             <label>Email ID</label>
                            <asp:TextBox CssClass="form-control" ID="txtEmailID" runat="server" placeholder="Email" ReadOnly="True"></asp:TextBox>
                            </div>
                        
                    
                            <div class="col-md-4">
                                <br />
                                <label>Old Password</label>
                            <asp:TextBox CssClass="form-control" ID="txtOldPassword" runat="server" placeholder="Password" TextMode="Password" ReadOnly="True"></asp:TextBox>
                            </div>

                            <div class="col-md-4">
                                <br />
                                <label>New Password</label>
                            <asp:TextBox CssClass="form-control" ID="txtNewPassword" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
                            </div>
               
                      </div>
                    </center>
                    <br />
                            <div class="row">
                            <div class="col-8 mx-auto">
                            <div class="form-group">
                                <center>
                                <asp:Button CssClass="btn btn-primary btn-block " ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
                          
                            </center>
                             </div>
                            </div>
                            </div>
                            <br />
                            <br />
                        </div>
            </div>
            <div class="col-md-7">
                 <div class="card" >
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img width="100px" src="images/EventImage.jpg" />
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h4>Your Bookings</h4>
                                    <asp:Label class="badge rounded-pill bg-info text-dark" ID="Label3" runat="server" Text="Your booking status"></asp:Label>
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
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dbEventConnectionString %>" SelectCommand="SELECT [BookingId], [BookingDate], [BookingApproval], [ApprovalDate], [VenueType], [Guests], [EventType] FROM [BookingTable]"></asp:SqlDataSource>
                            <div class="col">
                                <asp:GridView CssClass="table table-stripped table-bordered" ID="gvBookingDetails" runat="server" AutoGenerateColumns="False" DataKeyNames="BookingId" DataSourceID="SqlDataSource1">
                                    <Columns>
                                        <asp:BoundField DataField="BookingId" HeaderText="BookingId" InsertVisible="False" ReadOnly="True" SortExpression="BookingId" />
                                        <asp:BoundField DataField="BookingDate" HeaderText="BookingDate" SortExpression="BookingDate" />
                                        <asp:BoundField DataField="BookingApproval" HeaderText="BookingApproval" SortExpression="BookingApproval" />
                                        <asp:BoundField DataField="ApprovalDate" HeaderText="ApprovalDate" SortExpression="ApprovalDate" />
                                        <asp:BoundField DataField="VenueType" HeaderText="VenueType" SortExpression="VenueType" />
                                        <asp:BoundField DataField="Guests" HeaderText="Guests" SortExpression="Guests" />
                                        <asp:BoundField DataField="EventType" HeaderText="EventType" SortExpression="EventType" />
                                    </Columns>
                                </asp:GridView>
                            </div>
                        </div>
                   
                        </div>
            </div>
                  



                
            </div>
        </div>
</asp:Content>
