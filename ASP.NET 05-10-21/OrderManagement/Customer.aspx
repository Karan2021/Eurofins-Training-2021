<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="OrderManagement.Customer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width: 40%;">

                <h2>Enter Customer details</h2>
                <tr>
                    <td>
                        <asp:Label ID="id" runat="server">Customer Id :</asp:Label></td>
                    <td>
                        <asp:TextBox ID="Customer_id" runat="server"> </asp:TextBox>
                    </td>
                </tr>


                <tr>
                    <td>
                        <asp:Label ID="Name" runat="server">Customer Name :</asp:Label></td>
                    <td>
                        <asp:TextBox ID="Customer_Name" runat="server"> </asp:TextBox>
                    </td>
                </tr>


                <tr>
                    <td>
                        <asp:Label ID="C_city" runat="server">City :</asp:Label></td>
                    <td>
                        <asp:TextBox ID="City" runat="server"> </asp:TextBox>
                    </td>
                </tr>


                <tr>
                    <td>
                        <asp:Label ID="C_grade" runat="server">Grade :</asp:Label></td>
                    <td>
                        <asp:TextBox ID="Grade" runat="server"> </asp:TextBox>
                    </td>
                </tr>


                <tr>
                    <td>
                        <asp:Label ID="salesmanid" runat="server">Salesman Id :</asp:Label></td>
                    <td>
                        <asp:TextBox ID="Salesman_id" runat="server"> </asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Button ID="Submit" runat="server" Text="Submit" BorderStyle="Solid" ToolTip="Submit" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
