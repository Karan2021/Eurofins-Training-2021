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
    public partial class BookingManagement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGo_Click(object sender, EventArgs e)
        {
            dbEventEntities MydbEventEntities = new dbEventEntities();
            var result = MydbEventEntities.BookingTables.ToList().Find(obj => obj.BookingId == Convert.ToInt32(txtBookingId.Text));
            txtBookingStatus.Text = result.BookingApproval;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            txtBookingStatus.Text = "Approved";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            txtBookingStatus.Text = "Pending";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            txtBookingStatus.Text = "Rejected";
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            dbEventEntities MydbEventEntities = new dbEventEntities();
            var result = MydbEventEntities.BookingTables.ToList().Find(obj => obj.BookingId == Convert.ToInt32(txtBookingId.Text));
            result.BookingApproval = txtBookingStatus.Text;
            

            MydbEventEntities.Entry(result).State = EntityState.Modified;
            MydbEventEntities.SaveChanges();
            gvBookingDetails.DataBind();
        }
    }
}