<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="employee.aspx.cs" Inherits="Office.employee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>
                Search By:
                <asp:RadioButton ID="rbEmployeeNumber" runat="server" GroupName="Employee" Text="Employee Number" Checked="True" />
                <asp:RadioButton ID="rbLastName" runat="server" GroupName="Employee" Text="Last Name" />
                <asp:RadioButton ID="rbFirstName" runat="server" GroupName="Employee" Text="First Name" />
               
                <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
                <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="Search" />
               
            </p>
            <table>
               <tr>
                    <td>Job Title</td>
                    <td><asp:TextBox ID="txtJobTitle" runat="server"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td>Last Name</td>
                    <td><asp:TextBox ID="txtLastName" runat="server"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td>First Name</td>
                    <td><asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td>Gender</td>
                    <td><asp:TextBox ID="txtGender" runat="server"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td>Birth Date</td>
                    <td><asp:TextBox ID="txtBirthDate" runat="server"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td>Hire Date</td>
                    <td><asp:TextBox ID="txtHireDate" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Department Number</td>
                    <td>
                        <asp:DropDownList ID="ddlDepartmentNumber" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>Project Number</td>
                    <td>
                        <asp:DropDownList ID="ddlProjectNumber" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
            </table>
        </div>
        <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
        <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
        <asp:Button ID="btnReset" runat="server" Text="Reset" OnClick="btnReset_Click" />
        <asp:Label ID="lblEmployeeNumber" runat="server" Text="EmployeeNumber"></asp:Label>
        <asp:GridView ID="gvEmployeeDetails" runat="server" AutoGenerateColumns="False" OnRowCommand="gvEmployeeDetails_RowCommand" OnRowDeleting="gvEmployeeDetails_RowDeleting" OnRowEditing="gvEmployeeDetails_RowEditing">
            <Columns>
                <asp:BoundField DataField="employeeNumber" HeaderText="Employee Number" />
                <asp:BoundField DataField="job_Title" HeaderText="Job Title" />
                <asp:BoundField DataField="lastName" HeaderText="Last Name" />
                <asp:BoundField DataField="firstName" HeaderText="First Name" />
                <asp:BoundField DataField="gender" HeaderText="Gender" />
                <asp:BoundField DataField="birthday" HeaderText="Birth Date" />
                <asp:BoundField DataField="hiredate" HeaderText="Hire Date" />
                <asp:BoundField DataField="departmentNumber" HeaderText="Department Number" />
                <asp:BoundField DataField="projectNumber" HeaderText="Project Number" />
                <asp:TemplateField HeaderText="Edit">
                    <ItemTemplate>
                        <asp:LinkButton ID="lbtnEdit" runat="server" CommandName="Edit" CommandArgument='<%# Eval("employeeNumber") %>'>Edit</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Delete">
                    <ItemTemplate>
                        <asp:LinkButton ID="lbtnDelete" runat="server" CommandName="Delete" CommandArgument='<%# Eval("employeeNumber") %>'>Delete</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
