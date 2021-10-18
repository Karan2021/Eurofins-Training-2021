using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;
using System.Data;
using EventDataClass;
using EventBusiness;

namespace EventManagementApp
{
    public partial class UserLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //Response.Write("<script>alert('Login Successful');</script>");
            dbEventEntities MydbEventEntities = new dbEventEntities();

            var result = MydbEventEntities.Logins.ToList().Find(obj => obj.Email == txtUserId.Text);
            if (result.Password == txtPassword.Text && result.UserRole == "User")
            {
                Response.Write("<script>alert('Login Successful');</script>");
                Session["username"] = result.FirstName;
                Session["userid"] = result.UserId.ToString();
                Session["role"] = result.UserRole.ToString();
                
                Response.Redirect("HomePage.aspx");
                
            }
            else
            {
                Response.Write("<script>alert('Invalid Credentials');</script>");
            }
        }
    }
}