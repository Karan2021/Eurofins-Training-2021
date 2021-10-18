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
    public partial class BookingDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            gvBookingDetails.DataBind();
        }

        protected void btnGo_Click(object sender, EventArgs e)
        {
            dbEventEntities MydbEventEntities = new dbEventEntities();
            var result = MydbEventEntities.BookingTables.ToList().Find(obj => obj.BookingId == Convert.ToInt32(txtBookingId.Text));
            txtBookingStatus.Text = result.BookingApproval;
        }

        protected void btnPrint_Click(object sender, EventArgs e)
        {
            if (txtBookingStatus.Text == "Pending" || txtBookingStatus.Text == "Rejected")
            {
                Response.Write("<script>alert('Cannot print receipt as application is not approved');</script>");
            }
            else
                Response.Write("<script>alert('Redirecting to print receipt page');</script>");
        }

        protected void btnOrder_Click(object sender, EventArgs e)
        {
            if (txtBookingStatus.Text == "Pending" || txtBookingStatus.Text == "Rejected")
            {
                Response.Write("<script>alert('Cannot show order as application is not approved');</script>");
            }
            else
                Response.Write("<script>alert('Redirecting to show order page');</script>");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            dbEventEntities MydbEventEntities = new dbEventEntities();
            var result = MydbEventEntities.BookingTables.ToList().Find(obj => obj.BookingId == Convert.ToInt32(txtBookingId.Text));

            MydbEventEntities.Entry(result).State = EntityState.Deleted;
            MydbEventEntities.SaveChanges();
            gvBookingDetails.DataBind();
        }
    }
}