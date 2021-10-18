using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Reflection;

namespace EventDataClass
{
    public class MyDataOperation
    {
        dbEventEntities MydbEventEntities = new dbEventEntities();

        public void InsertEvent(Login LoginObj)
        {
            MydbEventEntities.Logins.Add(LoginObj);
            MydbEventEntities.SaveChanges();
        }

        public void InsertVenue(VenueTable VenueObj)
        {
            MydbEventEntities.VenueTables.Add(VenueObj);
            MydbEventEntities.SaveChanges();
        }
        public void BookEvent(BookingTable bookingTable)
        {
            MydbEventEntities.BookingTables.Add(bookingTable);
            MydbEventEntities.SaveChanges();
        }
       

       
    }
}
