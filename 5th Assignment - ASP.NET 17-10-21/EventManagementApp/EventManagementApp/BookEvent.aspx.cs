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
    public partial class BookEvent : System.Web.UI.Page
    {
        MyEvent MyEventObj = new MyEvent();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBook_Click(object sender, EventArgs e)
        {
            EventDataClass.BookingTable BookObj = new EventDataClass.BookingTable();
            BookObj.BookingDate = Convert.ToDateTime(txtDate.Text);
            BookObj.BookingApproval = "Pending";
            BookObj.Guests = Convert.ToInt32(txtGuests.Text);
            BookObj.EventType = ddlEventType.SelectedValue.ToString();
            BookObj.VenueType = ddlVenueType.SelectedValue.ToString();
            BookObj.UserId = Convert.ToInt32(Session["userid"]);
            MyEventObj.BookEvent(BookObj);
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }
    }
}