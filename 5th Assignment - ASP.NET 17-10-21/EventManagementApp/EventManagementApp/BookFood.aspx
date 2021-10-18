<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="BookFood.aspx.cs" Inherits="EventManagementApp.BookFood" %>
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
                                    <img width="100px" src="images/Food.png" />
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h4>Book Food</h4>
                                    
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
                     
                      
                           
                            <div class="form-group">
                            
                             <label>Food Type : </label>
                                <asp:RadioButton ID="rbVeg" runat="server" GroupName="Food" Text="Veg" Checked="True" />
                                <asp:RadioButton ID="rbNonVeg" runat="server" GroupName="Food" Text="Non Veg" />

                              
                            </div>
                            </div>
                          
                        
                    
                            
               
                      
                    
                    <br />

                    <div class="row">
                     
                      
                           
                            <div class="form-group">
                            
                             <label>Meal Type : </label>
                                <asp:RadioButton ID="rbLunch" runat="server" GroupName="Meal" Text="Lunch" Checked="True" />
                                <asp:RadioButton ID="rbDinner" runat="server" GroupName="Meal" Text="Dinner" />

                              
                            </div>
                            </div>
                          
                        
                    
                            
               
                      
                    
                    <br />

                     <div class="row">
                     
                      
                            <label>Dish Type</label>
                            <div class="form-group">
                                <asp:DropDownList CssClass="form-control" ID="ddlDishType" runat="server" Width="80%">
                                <asp:ListItem Text="----Select----" Value=""></asp:ListItem>
                                <asp:ListItem Text="Deluxe" Value="Deluxe"></asp:ListItem>
                                <asp:ListItem Text="Maharaja" Value="Maharaja"></asp:ListItem>
                            </asp:DropDownList>
                            </div>
                            </div>
                    <br />

                    <div class="row">
                     
                      
                            <label>Thali</label>
                            <div class="form-group">
                                <asp:CheckBox ID="cbSouthThali" runat="server" Text="South Indian Thali" /><br />
                                <asp:CheckBox ID="cbNorthThali" runat="server" Text="North Indian Thali" /><br />
                                <asp:CheckBox ID="cbPunjabiThali" runat="server" Text="Punjabi Thali" /><br />
                                <asp:CheckBox ID="cbMaharajaThali" runat="server" Text="Maharaja Thali" /><br />
                            </div>
                            </div>
                    
                    
                    

                   
                    <br />
            
                            <div class="row">
                            <div class="col">
                           <center>
                                <asp:Button CssClass="btn btn-success btn-block " ID="btnBook" runat="server" Text="Book"  />
                               <asp:Button CssClass="btn btn-danger btn-block " ID="btnCancel" runat="server" Text="Cancel"  />
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
                         <img src="images/Food.png" class="auto-style1" width="100%" />
                        </center>
                        </div>
                       
                   
                        </div>
            </div>
                  



                
            
        
        </div>
    </div>
</asp:Content>
