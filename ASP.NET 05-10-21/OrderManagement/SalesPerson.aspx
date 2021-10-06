<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SalesPerson.aspx.cs" Inherits="OrderManagement.SalesPerson" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width: 40%;">

                <h2>Enter Salesman details</h2>
                <!--<tr>
                    <td>
                        <asp:Label ID="SalesPersonID" runat="server">Sales Person Id :</asp:Label></td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"> </asp:TextBox>
                    </td>
                </tr>-->


                <tr>
                    <td>
                        <asp:Label ID="SalesPersonName" runat="server">Sales Person Name :</asp:Label></td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"> </asp:TextBox>
                    </td>
                </tr>


                <tr>
                    <td>
                        <asp:Label ID="SCity" runat="server">City :</asp:Label></td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server"> </asp:TextBox>
                    </td>
                </tr>


                <tr>
                    <td>
                        <asp:Label ID="SCommission" runat="server">Commission :</asp:Label></td>
                    <td>
                        <asp:TextBox ID="TextBox4" runat="server"> </asp:TextBox>
                    </td>
                </tr>


                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Submit" BorderStyle="Solid" ToolTip="Submit" OnClick="Button1_Click" /></td>
                </tr>

            </table>
        </div>
    </form>
</body>
</html>
