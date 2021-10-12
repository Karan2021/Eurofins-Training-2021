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
    public partial class project : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DbConnection dbconnection = new DbConnection();
            DataTable dt = dbconnection.GetProject();
            gvProjectDetails.DataSource = dt;
            gvProjectDetails.DataBind();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            DbConnection dbconnection = new DbConnection();
            dbconnection.InsertProject(txtProjectName.Text, txtProjectStartDate.Text);

            DataTable dt = dbconnection.GetProject();
            gvProjectDetails.DataSource = dt;
            gvProjectDetails.DataBind();
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
 
            txtProjectName.Text = string.Empty;
            txtProjectStartDate.Text = string.Empty;
        }

        protected void gvProjectDetails_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int ProjectNumber = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Edit")
            {
                DbConnection dbconnection = new DbConnection();
                DataTable dt = dbconnection.GetProjectByNum(ProjectNumber);
                txtProjectName.Text = dt.Rows[0][1].ToString();
                txtProjectStartDate.Text = dt.Rows[0][2].ToString();
                lblProjectId.Text = dt.Rows[0][0].ToString();
            }
            else
            {
                DbConnection dbconnection = new DbConnection();
                dbconnection.DeleteByProjectNum(ProjectNumber);

                DataTable dt = dbconnection.GetProject();
                gvProjectDetails.DataSource = dt;
                gvProjectDetails.DataBind();
            }
        }

        protected void gvProjectDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void gvProjectDetails_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            DbConnection dbconnection = new DbConnection();
            dbconnection.UpdateProject(Convert.ToInt32(lblProjectId.Text),txtProjectName.Text, txtProjectStartDate.Text);

            DataTable dt = dbconnection.GetProject();
            gvProjectDetails.DataSource = dt;
            gvProjectDetails.DataBind();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            DbConnection dbconnection = new DbConnection();
            if (rbProjectNumber.Checked)
            {
                int ProjectNumber = Convert.ToInt32(txtSearch.Text);
                DataTable dt = dbconnection.GetProjectByNum(ProjectNumber);
                gvProjectDetails.DataSource = dt;
                gvProjectDetails.DataBind();
            }
            else if (rbName.Checked)
            {
                string Name = txtSearch.Text;
                DataTable dt=dbconnection.GetProjectByName(Name);
                gvProjectDetails.DataSource = dt;
                gvProjectDetails.DataBind();
            }
            else
            {
                string Date = txtSearch.Text;
                DataTable dt = dbconnection.GetProjectByDate(Date);
                gvProjectDetails.DataSource = dt;
                gvProjectDetails.DataBind();
            }
        }
    }
}