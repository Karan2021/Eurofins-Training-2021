<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="department.aspx.cs" Inherits="Office.department" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 31px;
        }
        .auto-style6 {
            height: 15px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>Search By:<asp:RadioButton ID="rbDepartmentId" runat="server" GroupName="Department" Text="Department Number" Checked="True" />
                <asp:RadioButton ID="rbName" runat="server" GroupName="Department" Text="Department Name" />
                
            </p>
            <table>
                <tr>
                  <td class="auto-style6"><asp:TextBox ID="txtSearch" runat="server"></asp:TextBox></td> 
                    <td class="auto-style6">
                        <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="Search" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Name</td>
                    <td><asp:TextBox ID="txtDepartmentName" runat="server" Width="234px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style1"></td>
                </tr>
            </table>
        </div>
        <p>
            <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
            <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
            <asp:Button ID="btnReset" runat="server" Text="Reset" OnClick="btnReset_Click" />
        </p>
        <asp:Label ID="lblDepartmentId" runat="server" Text="DepartmentId"></asp:Label>
        <asp:GridView ID="gvDepartmentDetails" runat="server" AutoGenerateColumns="False" OnRowCommand="gvDepartmentDetails_RowCommand" OnRowDeleting="gvDepartmentDetails_RowDeleting" OnRowEditing="gvDepartmentDetails_RowEditing">
            <Columns>
                <asp:BoundField DataField="departmentNumber" HeaderText="Department ID" />
                <asp:BoundField DataField="name" HeaderText="Department Name" />
                <asp:TemplateField HeaderText="Edit">
                    <ItemTemplate>
                        <asp:LinkButton ID="lbtnEdit" runat="server" CommandName="Edit" CommandArgument='<%# Eval("departmentNumber") %>'>Edit</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Delete">
                    <ItemTemplate>
                        <asp:LinkButton ID="lbtnDelete" runat="server" CommandName="Delete" CommandArgument='<%# Eval("departmentNumber") %>'>Delete</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
