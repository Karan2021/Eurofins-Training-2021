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
    public partial class SignUp : System.Web.UI.Page
    {
        MyEvent MyEventObj = new MyEvent();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            EventDataClass.Login LoginObj = new EventDataClass.Login();
            LoginObj.Address = txtAddress.Text;
            LoginObj.Email = txtEmailID.Text;
            LoginObj.FirstName = txtFirstName.Text;
            LoginObj.LastName = txtLastName.Text;
            LoginObj.Password = txtPassword.Text;
            LoginObj.PhoneNumber = txtPhone.Text;
            LoginObj.UserRole = "User";
            MyEventObj.InsertEvent(LoginObj);
        }
    }
}