<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="project.aspx.cs" Inherits="Office.project" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>
                <b>Search By:</b><asp:RadioButton ID="rbProjectNumber" runat="server" Text="Project Number" Checked="True" GroupName="ProjectGroup" />
                <asp:RadioButton ID="rbName" runat="server" Text="Name" GroupName="ProjectGroup" />
                <asp:RadioButton ID="rbDate" runat="server" Text="Start Date" GroupName="ProjectGroup" />
&nbsp;</p>
            <table>
                <tr>
                    <td><asp:TextBox ID="txtSearch" runat="server"></asp:TextBox></td>
                        <td><asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
                    </td>
                </tr>
                <tr>
                    <td>Name</td>
                    <td><asp:TextBox ID="txtProjectName" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Start Date</td>
                    <td><asp:TextBox ID="txtProjectStartDate" runat="server"></asp:TextBox></td>
                </tr>
            <tr><td></td>
            <td><asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
                <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update" />
                <asp:Button ID="btnReset" runat="server" Text="Reset" OnClick="btnReset_Click" /></td>
            </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblProjectId" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
        <asp:GridView ID="gvProjectDetails" runat="server" AutoGenerateColumns="False" Width="638px" OnRowCommand="gvProjectDetails_RowCommand" OnRowDeleting="gvProjectDetails_RowDeleting" OnRowEditing="gvProjectDetails_RowEditing">
            <Columns>
                <asp:BoundField DataField="projectNumber" HeaderText="Project Number" />
                <asp:BoundField DataField="name" HeaderText="Name" />
                <asp:BoundField DataField="startDate" HeaderText="Start Date" />
                <asp:TemplateField HeaderText="Edit">
                    <ItemTemplate>
                        <asp:LinkButton ID="lbtnEdit" runat="server" CommandArgument='<%# Eval("projectNumber") %>' CommandName="Edit">Edit</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Delete">
                    <ItemTemplate>
                        <asp:LinkButton ID="lbtnDelete" runat="server" CommandArgument='<%# Eval("projectNumber") %>' CommandName="Delete">Delete</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
