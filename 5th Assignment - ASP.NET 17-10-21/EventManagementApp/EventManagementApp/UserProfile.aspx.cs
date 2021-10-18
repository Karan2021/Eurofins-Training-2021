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
    public partial class UserProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            dbEventEntities MydbEventEntities = new dbEventEntities();
            var result = MydbEventEntities.Logins.ToList().Find(obj => obj.UserId == Convert.ToInt32(Session["userid"]));
            txtFirstName.Text = result.FirstName;
            txtLastName.Text = result.LastName;
            txtAddress.Text = result.Address;
            txtEmailID.Text = result.Email;
            txtPhone.Text = result.PhoneNumber;
            txtOldPassword.Text = result.Password;

            gvBookingDetails.DataBind();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            dbEventEntities MydbEventEntities = new dbEventEntities();
            var result = MydbEventEntities.Logins.ToList().Find(obj => obj.UserId == Convert.ToInt32(Session["userid"]));
            result.Password = txtNewPassword.Text;

            MydbEventEntities.Entry(result).State = EntityState.Modified;
            MydbEventEntities.SaveChanges();
        }
    }
}