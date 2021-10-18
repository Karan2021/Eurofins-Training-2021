<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="VenueManagement.aspx.cs" Inherits="EventManagementApp.VenueManagement" %>
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
                                    <img width="100px" src="images/EventImage1.jpg" />
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h4>Venue Details</h4>
                                    
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
                                <center>
                                    <asp:FileUpload CssClass="form-control" ID="FileUpload1" runat="server" />
                                </center>
                            </div>
                        </div>
                    <br />
                    <center>
                    <div class="row">
                     
                            <div class="col-md-6">
                             <label>Venue ID</label>
                            <div class="form-group">
                            <div class="input-group">
                            <asp:TextBox CssClass="form-control" ID="txtVenueId" runat="server" placeholder="Venue ID"></asp:TextBox>
                            <asp:Button CssClass="btn btn-primary  " ID="btnGo" runat="server" Text="Go" OnClick="btnGo_Click" />
                            </div>
                            </div>
                            </div>
                        
                    
                            <div class="col-md-6">
                                <label>Venue Name</label>
                                <div class="form-group">
                                <div class="input-group">
                            <asp:TextBox CssClass="form-control" ID="txtVenueName" runat="server" placeholder="Venue Name"></asp:TextBox>
                            
                            </div>
                            </div>
                            </div>
               
                      </div>
                    </center>
                    <br />

                    <center>
                    <div class="row">
                     
                            <div class="col-md-6">
                             <label>Location</label>
                            <div class="form-group">
                            <div class="input-group">
                            <asp:TextBox CssClass="form-control" ID="txtLocation" runat="server" placeholder="Location"></asp:TextBox>
                         
                            </div>
                            </div>
                            </div>
                        
                    
                            <div class="col-md-6">
                                <label>Type</label>
                                <div class="form-group">
                                <div class="input-group">
                            <asp:TextBox CssClass="form-control" ID="txtVenueType" runat="server" placeholder="Type"></asp:TextBox>
                            
                            </div>
                            </div>
                            </div>
               
                      </div>
                    </center>
                    <br />

                    <center>
                    <div class="row">
                     
                            <div class="col-md-6">
                             <label>Capacity</label>
                            <div class="form-group">
                            <div class="input-group">
                            <asp:TextBox CssClass="form-control" ID="txtCapacity" runat="server" placeholder="Capacity"></asp:TextBox>
                         
                            </div>
                            </div>
                            </div>
                        
                    
                            <div class="col-md-6">
                                <label>Cost</label>
                                <div class="form-group">
                                <div class="input-group">
                            <asp:TextBox CssClass="form-control" ID="txtCost" runat="server" placeholder="Cost"></asp:TextBox>
                            
                            </div>
                            </div>
                            </div>
               
                      </div>
                    </center>
                    <br />

                    <div class="col-12">
                        <label>Venue Description</label>
                        <div class="form-group">
                            <asp:TextBox CssClass="form-control" ID="txtDescription" runat="server" placeholder="Venue Description" TextMode="MultiLine" Rows="2"></asp:TextBox>
                        </div>
                    </div>
                    <br />
            
                            <div class="row">
                            <div class="col">
                           <center>
                                <asp:Button CssClass="btn btn-success btn-block " ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
                               <asp:Button CssClass="btn btn-primary btn-block " ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
                               <asp:Button CssClass="btn btn-danger btn-block " ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
                               </center>
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
                                    <h4>Venue List</h4>
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
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dbEventConnectionString %>" SelectCommand="SELECT * FROM [VenueTable]"></asp:SqlDataSource>
                            <div class="col">
                                <asp:GridView CssClass="table table-stripped table-bordered" ID="gvVenueDetails" runat="server" AutoGenerateColumns="False" DataKeyNames="VenueId" DataSourceID="SqlDataSource1">
                                    <Columns>
                                        <asp:BoundField DataField="VenueId" HeaderText="VenueId" InsertVisible="False" ReadOnly="True" SortExpression="VenueId" />
                                        <asp:BoundField DataField="VenueName" HeaderText="VenueName" SortExpression="VenueName" />
                                        <asp:BoundField DataField="Location" HeaderText="Location" SortExpression="Location" />
                                        <asp:BoundField DataField="Type" HeaderText="Type" SortExpression="Type" />
                                        <asp:BoundField DataField="Capacity" HeaderText="Capacity" SortExpression="Capacity" />
                                        <asp:BoundField DataField="Cost" HeaderText="Cost" SortExpression="Cost" />
                                        <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
                                    </Columns>
                                </asp:GridView>
                            </div>
                        </div>
                   
                        </div>
            </div>
                  



                
            </div>
        </div>
</asp:Content>
