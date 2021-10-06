using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OrderManagement
{
    public partial class SalesPerson : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string salesmanname = "";
            string salesmancity = "";
            string commission = "";
            salesmanname = TextBox2.Text;
            salesmancity = TextBox3.Text;
            commission = TextBox4.Text;

            DbConnection dbObj = new DbConnection();
            dbObj.InsertSalesPerson(salesmanname, salesmancity, commission);
        }
    }
}