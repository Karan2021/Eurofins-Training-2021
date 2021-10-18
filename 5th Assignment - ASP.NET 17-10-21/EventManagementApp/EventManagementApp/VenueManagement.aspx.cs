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
    public partial class VenueManagement : System.Web.UI.Page
    {
        MyEvent MyEventObj = new MyEvent();
        protected void Page_Load(object sender, EventArgs e)
        {
            gvVenueDetails.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            EventDataClass.VenueTable VenueObj = new EventDataClass.VenueTable();
            VenueObj.Location = txtLocation.Text;
            VenueObj.Type = txtVenueType.Text;
            VenueObj.VenueName = txtVenueName.Text;
            VenueObj.Capacity = Convert.ToInt32(txtCapacity.Text);
            VenueObj.Cost = Convert.ToInt32(txtCost.Text);
            MyEventObj.InsertVenue(VenueObj);
            //DataTable dtMovies = MyEventObj.SelectVenue();
            //gvVenueDetails.DataSource = dtMovies;
            gvVenueDetails.DataBind();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            dbEventEntities MydbEventEntities = new dbEventEntities();
            var result = MydbEventEntities.VenueTables.ToList().Find(obj => obj.VenueId == Convert.ToInt32(txtVenueId.Text));

            VenueTable VenueObj = new VenueTable();
            result.VenueName = txtVenueName.Text;
            result.Location = txtLocation.Text;
            result.Type = txtVenueType.Text;
            result.Description = txtDescription.Text;
            result.Capacity = Convert.ToInt32(txtCapacity.Text);
            result.Cost = Convert.ToInt32(txtCost.Text);

            MydbEventEntities.Entry(result).State = EntityState.Modified;
            MydbEventEntities.SaveChanges();
            gvVenueDetails.DataBind();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            dbEventEntities MydbEventEntities = new dbEventEntities();
            var result = MydbEventEntities.VenueTables.ToList().Find(obj => obj.VenueId == Convert.ToInt32(txtVenueId.Text));

            MydbEventEntities.Entry(result).State = EntityState.Deleted;
            MydbEventEntities.SaveChanges();
            gvVenueDetails.DataBind();
        }

        protected void btnGo_Click(object sender, EventArgs e)
        {
            dbEventEntities MydbEventEntities = new dbEventEntities();
            var result = MydbEventEntities.VenueTables.ToList().Find(obj => obj.VenueId == Convert.ToInt32(txtVenueId.Text));
            txtVenueName.Text = result.VenueName;
            txtVenueType.Text = result.Type;
            txtLocation.Text = result.Location;
            txtDescription.Text = result.Description;
            txtCapacity.Text = Convert.ToString(result.Capacity);
            txtCost.Text = Convert.ToString(result.Cost);
        }
    }
}