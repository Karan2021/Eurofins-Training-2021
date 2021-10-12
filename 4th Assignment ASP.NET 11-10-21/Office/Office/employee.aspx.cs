using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Office
{
    public partial class employee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DbConnection dbconnection = new DbConnection();
                DataTable dt = dbconnection.GetDepartmentIds();
                ddlDepartmentNumber.Items.Add("------Select-------");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ddlDepartmentNumber.Items.Add(new ListItem(dt.Rows[i][0].ToString() + " - " + dt.Rows[i][1].ToString(), dt.Rows[i][0].ToString()));
                }
                dt = dbconnection.GetProjectNumbers();
                ddlProjectNumber.Items.Add("------select------");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ddlProjectNumber.Items.Add(new ListItem(dt.Rows[i][0].ToString() + " - " + dt.Rows[i][1].ToString(), dt.Rows[i][0].ToString()));
                }
            }
            DbConnection dbobj = new DbConnection();
            DataTable datatable = dbobj.GetEmployee();
            gvEmployeeDetails.DataSource = datatable;
            gvEmployeeDetails.DataBind();
        }

        protected void gvEmployeeDetails_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int employeeId = Convert.ToInt32(e.CommandArgument);
            DbConnection dbconnection = new DbConnection();
            if (e.CommandName == "Edit")
            {
                DataTable dt = dbconnection.GetEmployeeById(employeeId);
                txtJobTitle.Text = dt.Rows[0][1].ToString();
                txtLastName.Text = dt.Rows[0][2].ToString();
                txtFirstName.Text = dt.Rows[0][3].ToString();
                txtGender.Text = dt.Rows[0][4].ToString();
                txtBirthDate.Text = dt.Rows[0][5].ToString();
                txtHireDate.Text = dt.Rows[0][6].ToString();
                lblEmployeeNumber.Text = dt.Rows[0][0].ToString();
            }
            else
            {
                dbconnection.DeleteByEmployeeId(employeeId);

                DataTable dt = dbconnection.GetEmployee();
                gvEmployeeDetails.DataSource = dt;
                gvEmployeeDetails.DataBind();
            }
        }

        protected void gvEmployeeDetails_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void gvEmployeeDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            int DepartmentNumber = Convert.ToInt32(ddlDepartmentNumber.SelectedValue.ToString());
            int ProjectNumber = Convert.ToInt32(ddlProjectNumber.SelectedValue.ToString());

            DbConnection dbconnection = new DbConnection();
            dbconnection.InsertEmployee(txtJobTitle.Text, txtLastName.Text, txtFirstName.Text, txtGender.Text, txtBirthDate.Text, txtHireDate.Text, DepartmentNumber, ProjectNumber);
            DataTable dt = dbconnection.GetEmployee();
            gvEmployeeDetails.DataSource = dt;
            gvEmployeeDetails.DataBind();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            DbConnection dbconnection = new DbConnection();
            int DepartmentNumber = Convert.ToInt32(ddlDepartmentNumber.SelectedValue.ToString());
            int ProjectNumber = Convert.ToInt32(ddlProjectNumber.SelectedValue.ToString());
            dbconnection.UpdateEmployee(Convert.ToInt32(lblEmployeeNumber.Text), txtJobTitle.Text, txtLastName.Text, txtFirstName.Text, txtGender.Text, txtBirthDate.Text, txtHireDate.Text, DepartmentNumber, ProjectNumber);

            DataTable dt = dbconnection.GetEmployee();
            gvEmployeeDetails.DataSource = dt;
            gvEmployeeDetails.DataBind();
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtJobTitle.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtGender.Text = string.Empty;
            txtBirthDate.Text = string.Empty;
            txtHireDate.Text = string.Empty;
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            DbConnection dbconnection = new DbConnection();
            if (rbEmployeeNumber.Checked)
            {
                int EmployeeNumber = Convert.ToInt32(txtSearch.Text);
                DataTable dt = dbconnection.GetEmployeeById(EmployeeNumber);
                gvEmployeeDetails.DataSource = dt;
                gvEmployeeDetails.DataBind();
            }
            else if (rbLastName.Checked)
            {
                string LastName = txtSearch.Text;
                DataTable dt = dbconnection.GetEmployeeByLastName(LastName);
                gvEmployeeDetails.DataSource = dt;
                gvEmployeeDetails.DataBind();
            }
            else
            {
                string FirstName = txtSearch.Text;
                DataTable dt = dbconnection.GetEmployeeByFirstName(FirstName);
                gvEmployeeDetails.DataSource = dt;
                gvEmployeeDetails.DataBind();
            }
        }
    }
}