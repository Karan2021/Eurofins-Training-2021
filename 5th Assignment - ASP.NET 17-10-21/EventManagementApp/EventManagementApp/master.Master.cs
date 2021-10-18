using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EventManagementApp
{
    public partial class master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["role"]==null || Session["role"].Equals(""))
            {
                lbtnLogin.Visible = true;
                lbtnSignUp.Visible = true;
                lbtnLogOut.Visible = false;
                lbtnHelloUser.Visible = false;
                lbtnAdminLogin.Visible = true;
                lbtnVenueManagement.Visible = false;
                lbtnViewBookings.Visible = false;
                lbtnEventBooking.Visible = false;
                lbtnBookFood.Visible = false;
                lbtnBookingDetails.Visible = false;
            }
            else if (Session["role"].Equals("User"))
            {
                lbtnLogin.Visible = false;
                lbtnSignUp.Visible = false;
                lbtnLogOut.Visible = true;
                lbtnHelloUser.Visible = true;
                lbtnHelloUser.Text = "Hello,"+Session["username"].ToString();
                lbtnEventBooking.Visible = true;
                lbtnBookFood.Visible = true;
                lbtnBookingDetails.Visible = true;

                lbtnAdminLogin.Visible = true;
                lbtnVenueManagement.Visible = false;
                lbtnViewBookings.Visible = false;
            }

            else if (Session["role"].Equals("Admin"))
            {
                lbtnLogin.Visible = false;
                lbtnSignUp.Visible = false;
                lbtnLogOut.Visible = true;
                lbtnHelloUser.Visible = true;
                lbtnHelloUser.Text = "Hello," + Session["username"].ToString();
                lbtnEventBooking.Visible = false;
                lbtnBookFood.Visible = false;
                lbtnBookingDetails.Visible = false;

                lbtnAdminLogin.Visible = false;
                lbtnVenueManagement.Visible = true;
                lbtnViewBookings.Visible = true;
            }
        }

        protected void lbtnAdminLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminLogin.aspx");
        }

        protected void lbtnViewBookings_Click(object sender, EventArgs e)
        {
            Response.Redirect("BookingManagement.aspx");
        }

        protected void lbtnVenueManagement_Click(object sender, EventArgs e)
        {
            Response.Redirect("VenueManagement.aspx");
        }

        protected void lbtnSignUp_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignUp.aspx");
        }

        protected void lbtnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserLogin.aspx");
        }

        protected void lbtnLogOut_Click(object sender, EventArgs e)
        {
            Session["username"] = "";
            Session["userid"] = "";
            Session["role"] = "";

            lbtnBookFood.Visible = false;
            lbtnBookingDetails.Visible = false;
            lbtnEventBooking.Visible = false;
            lbtnLogin.Visible = true;
            lbtnSignUp.Visible = true;
            lbtnLogOut.Visible = false;
            lbtnHelloUser.Visible = false;
            lbtnAdminLogin.Visible = true;
            lbtnVenueManagement.Visible = false;
            lbtnViewBookings.Visible = false;
            
            

            Response.Redirect("HomePage.aspx");
        }

        protected void lbtnHelloUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserProfile.aspx");
        }

        protected void lbtnBookFood_Click(object sender, EventArgs e)
        {
            Response.Redirect("BookFood.aspx");
        }

        protected void lbtnBookingDetails_Click(object sender, EventArgs e)
        {
            Response.Redirect("BookingDetails.aspx");
        }

        protected void lbtnEventBooking_Click(object sender, EventArgs e)
        {
            Response.Redirect("BookEvent.aspx");
        }
    }
}