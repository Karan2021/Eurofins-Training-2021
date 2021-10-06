using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OrderManagement
{
    public class DbConnection
    {
        public void InsertSalesPerson(string salesPersonName, string city, string commision)
        {
            int id = 5100;
            SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-4ECP13CA;Initial Catalog=SQL_Intermediate;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("insert into sales_person(sales_person_id,sales_person_name,city,commission) values(" + id + ",'" + salesPersonName + "','" + city + "'," + commision + ")", sqlConnection);

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
    }
}