<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MoviePage.aspx.cs" Inherits="MyMovieApp.WMoviePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="MId" runat="server" Text="Movie Id : "></asp:Label>

                    </td>
                     <td>
                        <asp:Label ID="Id" runat="server" Text=""></asp:Label>

                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Movie_Name" runat="server" Text="Movie Name : "></asp:Label>

                    </td>
                     <td>
                        <asp:TextBox ID="Name" runat="server" Text=""></asp:TextBox>

                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="type" runat="server" Text="Movie Type : "></asp:Label>

                    </td>
                     <td>
                        <asp:TextBox ID="MovieType" runat="server" Text=""></asp:TextBox>

                    </td>
                </tr>
                
                <tr>
                    <td>
                        <asp:Label ID="description" runat="server" Text="Movie Description : "></asp:Label>

                    </td>
                     <td>
                        <asp:TextBox ID="MovieDesc" runat="server" Text=""></asp:TextBox>

                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
                    </td>
                     <td>
                         <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
                    </td>

                     <td>
                         <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
                    </td>
                     <td>
                         &nbsp;</td>
                </tr>

            </table>

        </div>
        
        <div>
                <asp:Label ID="Label1" runat="server" Text="Search Movie by ID : "></asp:Label>

            <asp:TextBox ID="Search" runat="server"></asp:TextBox>
&nbsp;
            <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
            <br />
            <br />
            <br />
            <asp:GridView ID="gvDetails" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Movie Id" />
                    <asp:BoundField DataField="Name" HeaderText="Movie Name" />
                    <asp:BoundField DataField="MovieType" HeaderText="Movie Type" />
                    <asp:BoundField DataField="MovieDesc" HeaderText="Movie Description" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
