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
    public partial class department : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DbConnection dbconnection = new DbConnection();
            DataTable dt = dbconnection.GetDepartment();
            gvDepartmentDetails.DataSource = dt;
            gvDepartmentDetails.DataBind();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            DbConnection dbconnection = new DbConnection();
            dbconnection.InsertDepartment(txtDepartmentName.Text);

            DataTable dt = dbconnection.GetDepartment();
            gvDepartmentDetails.DataSource = dt;
            gvDepartmentDetails.DataBind();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            DbConnection dbconnection = new DbConnection();
            dbconnection.UpdateDepartment(Convert.ToInt32(lblDepartmentId.Text), txtDepartmentName.Text);

            DataTable dt = dbconnection.GetDepartment();
            gvDepartmentDetails.DataSource = dt;
            gvDepartmentDetails.DataBind();
        }

        protected void gvDepartmentDetails_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int departmentid = Convert.ToInt32(e.CommandArgument);
            DbConnection dbconnection = new DbConnection();
            if (e.CommandName == "Edit")
            {
                DataTable dt = dbconnection.GetDepartmentById(departmentid);
                txtDepartmentName.Text = dt.Rows[0][1].ToString();
                lblDepartmentId.Text = dt.Rows[0][0].ToString();
            }
            else
            {
                dbconnection.DeleteByDepartmentId(departmentid);

                DataTable dt = dbconnection.GetDepartment();
                gvDepartmentDetails.DataSource = dt;
                gvDepartmentDetails.DataBind();
            }
        }

        protected void gvDepartmentDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void gvDepartmentDetails_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        

        

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtDepartmentName.Text = string.Empty;
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            DbConnection dbconnection = new DbConnection();
            if (rbDepartmentId.Checked)
            {
                int DepartmentNumber = Convert.ToInt32(txtSearch.Text);
                DataTable dt = dbconnection.GetDepartmentById(DepartmentNumber);
                gvDepartmentDetails.DataSource = dt;
                gvDepartmentDetails.DataBind();
            }
            else
            {
                string Name = txtSearch.Text;
                DataTable dt = dbconnection.GetDepartmentByName(Name);
                gvDepartmentDetails.DataSource = dt;
                gvDepartmentDetails.DataBind();
            }
        }
    }
}