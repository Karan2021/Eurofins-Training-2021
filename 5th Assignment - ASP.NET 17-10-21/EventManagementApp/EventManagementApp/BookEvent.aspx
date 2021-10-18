<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="BookEvent.aspx.cs" Inherits="EventManagementApp.BookEvent" %>
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
                                    <h4>Book Venue</h4>
                                    
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
                       
                    <br />
                    
                    <div class="row">
                     
                      
                            <label>Event Type</label>
                            <div class="form-group">
                                <asp:DropDownList CssClass="form-control" ID="ddlEventType" runat="server" Width="80%">
                                <asp:ListItem Text="----Select----" Value=""></asp:ListItem>
                                <asp:ListItem Text="Birthday Party" Value="Birthday Party"></asp:ListItem>
                                <asp:ListItem Text="Wedding" Value="Wedding"></asp:ListItem>
                            </asp:DropDownList>
                            </div>
                            </div>
                          
                        
                    
                            
               
                      
                    
                    <br />

                     <div class="row">
                     
                      
                            <label>Venue Type</label>
                            <div class="form-group">
                                <asp:DropDownList CssClass="form-control" ID="ddlVenueType" runat="server" Width="80%">
                                <asp:ListItem Text="----Select----" Value=""></asp:ListItem>
                                <asp:ListItem Text="Beach View" Value="Beach View"></asp:ListItem>
                                <asp:ListItem Text="Mountains" Value="Mountains"></asp:ListItem>
                            </asp:DropDownList>
                            </div>
                            </div>
                    <br />

                    
                    <div class="row">
                     
                            
                             <label>Number Of Guests</label>
                            <div class="form-group">
                            
                            <asp:TextBox CssClass="form-control" ID="txtGuests" runat="server" placeholder="Guests" Width="80%"></asp:TextBox>
                         
                          
                            </div>
                            
                        
                    
                            
               
                      </div>
                    
                    <br />

                    <div class="col-12">
                        <label>Booking Date</label>
                        <div class="form-group">
                            <asp:TextBox CssClass="form-control" ID="txtDate" runat="server"  TextMode="Date" Width="80%"></asp:TextBox>
                        </div>
                    </div>
                    <br />
            
                            <div class="row">
                            <div class="col">
                           <center>
                                <asp:Button CssClass="btn btn-success btn-block " ID="btnBook" runat="server" Text="Book" OnClick="btnBook_Click"  />
                               <asp:Button CssClass="btn btn-danger btn-block " ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click"  />
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
                        <center>
                         <img src="images/EventImage.jpg" class="auto-style1" />
                        </center>
                        </div>
                       
                   
                        </div>
            </div>
                  



                
            
        
        </div>
    </div>
</asp:Content>
