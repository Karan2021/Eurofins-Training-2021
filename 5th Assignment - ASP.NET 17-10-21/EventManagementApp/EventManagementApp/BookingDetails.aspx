<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="BookingDetails.aspx.cs" Inherits="EventManagementApp.BookingDetails" %>
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
                                    <img width="100px" src="images/EventImage1.jpg" />
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
                            
                            </div>
                            </div>
                            </div>
               
                      </div>
                    </center>
                    <br />
                    
            
                            <div class="row">
                            <div class="col">
                           <center>
                                <asp:Button CssClass="btn btn-primary btn-block " ID="btnPrint" runat="server" Text="Print Receipt" OnClick="btnPrint_Click" />
                               <asp:Button CssClass="btn btn-success btn-block " ID="btnOrder" runat="server" Text="Show Order" OnClick="btnOrder_Click" />
                               <asp:Button CssClass="btn btn-danger btn-block " ID="btnCancel" runat="server" Text="Cancel Booking" OnClick="btnCancel_Click" />
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
                            <div class="col">
                                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dbEventConnectionString %>" SelectCommand="SELECT [BookingId], [BookingDate], [BookingApproval], [ApprovalDate], [VenueType], [Guests], [EventType] FROM [BookingTable]"></asp:SqlDataSource>
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
