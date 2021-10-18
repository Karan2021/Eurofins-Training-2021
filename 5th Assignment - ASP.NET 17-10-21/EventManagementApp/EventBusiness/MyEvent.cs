using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventDataClass;
using System.Data;

namespace EventBusiness
{
    public class MyEvent
    {
        MyDataOperation MyDataOperationObj = new MyDataOperation();

        public void InsertEvent(Login logindata)
        {
            MyDataOperationObj.InsertEvent(logindata);
        }
        public void InsertVenue(VenueTable venuedata)
        {
            MyDataOperationObj.InsertVenue(venuedata);
        }

        public void BookEvent(BookingTable bookingTable)
        {
            MyDataOperationObj.BookEvent(bookingTable);
        }

        
    }
}
