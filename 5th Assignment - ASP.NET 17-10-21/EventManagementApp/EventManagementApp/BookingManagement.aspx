<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="BookingManagement.aspx.cs" Inherits="EventManagementApp.BookingManagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-4">
                <div class="card" >
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img width="100px" src="images/AdminLoginImg.png" />
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h4>Booking Status</h4>
                                    
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
                     
                            <div class="col-md-4">
                             <label>Booking ID</label>
                            <div class="form-group">
                            <div class="input-group">
                            <asp:TextBox CssClass="form-control" ID="txtBookingId" runat="server" placeholder="Booking ID"></asp:TextBox>
                             <asp:Button CssClass="btn btn-primary  " ID="btnGo" runat="server" Text="Go" OnClick="btnGo_Click" />
                            </div>
                            </div>
                            </div>
                        
                    
                            <div class="col-md-8">
                                <label>Booking Status</label>
                                <div class="form-group">
                                <div class="input-group">
                            <asp:TextBox CssClass="form-control" ID="txtBookingStatus" runat="server" placeholder="Booking Status" ReadOnly="True"></asp:TextBox>
                            <asp:Button CssClass="btn btn-success mr-1 " ID="Button1" runat="server" Text="S" OnClick="Button1_Click" />
                            <asp:Button CssClass="btn btn-warning mr-1 " ID="Button2" runat="server" Text="P" OnClick="Button2_Click" />
                            <asp:Button CssClass="btn btn-danger mr-1 " ID="Button3" runat="server" Text="D" OnClick="Button3_Click" />
                            </div>
                            </div>
                            </div>
               
                      </div>
                    </center>
                    <br />
                    
            
                            <div class="row">
                            <div class="col">
                           <center>
                                <asp:Button CssClass="btn btn-primary btn-block " ID="btnUpdate" runat="server" Text="Submit" OnClick="btnUpdate_Click" />
                               </center>
                            </div>
                            </div>
                            <br />
                            <br />
                        </div>
            </div>
            <div class="col-md-8">
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
                                    <h4>Booking List</h4>
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
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dbEventConnectionString %>" SelectCommand="SELECT [BookingId], [UserId], [BookingDate], [BookingApproval], [ApprovalDate], [VenueType], [Guests], [EventType] FROM [BookingTable]"></asp:SqlDataSource>
                            <div class="col">
                                <asp:GridView CssClass="table table-stripped table-bordered" ID="gvBookingDetails" runat="server" AutoGenerateColumns="False" DataKeyNames="BookingId" DataSourceID="SqlDataSource1">
                                    <Columns>
                                        <asp:BoundField DataField="BookingId" HeaderText="BookingId" InsertVisible="False" ReadOnly="True" SortExpression="BookingId" />
                                        <asp:BoundField DataField="UserId" HeaderText="UserId" SortExpression="UserId" />
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
