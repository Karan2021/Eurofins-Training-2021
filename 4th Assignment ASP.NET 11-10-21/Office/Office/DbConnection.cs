using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace Office
{
    public class DbConnection
    {
        public DataTable ExecuteQuery(string query)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=LAPTOP-N42Q6CD6; Initial Catalog=office; Integrated Security= True");
            SqlDataAdapter da = new SqlDataAdapter(query, sqlconnection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable GetProject()
        {
            DataTable dt = ExecuteQuery("select * from project");
            return dt;
        }

        public DataTable GetDepartment()
        {
            DataTable dt = ExecuteQuery("select * from department");
            return dt;
        }

        public DataTable GetEmployee()
        {
            DataTable dt = ExecuteQuery("select * from employee");
            return dt;
        }

        public void InsertProject(string name,string date )
        {
            ExecuteQuery("insert into project values('"+name+"','"+date+"')");
        }

        public void InsertDepartment(string name)
        {
            ExecuteQuery("insert into department values('" + name + "')");
        }

        public void InsertEmployee(string JobTitle,string LastName,string FirstName,string Gender,string birthday,string hiredate,int DepartmentNumber,int ProjectNumber)
        {
            ExecuteQuery("insert into employee values('" + JobTitle + "','" + LastName + "','" + FirstName + "','" + Gender + "','" + birthday + "','" + hiredate + "'," + DepartmentNumber + "," + ProjectNumber + ")");
        }

        public DataTable GetProjectByNum(int ProjectNumber)
        {
            DataTable dt = ExecuteQuery("select * from project where projectNumber =" + ProjectNumber + "");
            return dt;
        }

        public DataTable GetDepartmentById(int departmentid)
        {
            DataTable dt = ExecuteQuery("select * from department where departmentNumber=" + departmentid + "");
            return dt;
        }

        public DataTable GetEmployeeById(int employeeId)
        {
            DataTable dt = ExecuteQuery("select * from employee where employeeNumber=" + employeeId + "");
            return dt;
        }

        public void UpdateProject(int projectNumber, string name, string date)
        {
            ExecuteQuery("update project set name='"+name+"',startDate='"+date+"' where projectNumber=" +projectNumber+ "");
        }

        public void UpdateDepartment(int departmentid,string name)
        {
            ExecuteQuery("update department set name='" + name + "' where departmentNumber=" + departmentid + "");
        }

        public void UpdateEmployee(int EmployeeNumber,string JobTitle,string LastName,string FirstName,string Gender,string BirthDate,string HireDate,int DepartmentNumber,int ProjectNumber)
        {
            ExecuteQuery("update employee set job_Title='" + JobTitle + "',lastName='" + LastName + "',firstName='" + FirstName + "',gender='" + Gender + "',birthday='" + BirthDate + "',hiredate='" + HireDate + "',departmentNumber=" + DepartmentNumber + ",projectNumber=" + ProjectNumber + " where employeeNumber=" + EmployeeNumber + "");
        }

        public void DeleteByProjectNum(int projectNumber)
        {
            ExecuteQuery("delete from project where projectNumber=" + projectNumber + "");
        }

        public void DeleteByDepartmentId(int departmentid)
        {
            ExecuteQuery("delete from department where departmentNumber=" + departmentid + "");
        }

        public void DeleteByEmployeeId(int employeeId)
        {
            ExecuteQuery("delete from employee where employeeNumber=" + employeeId + "");
        }

        public DataTable GetProjectByName(string name)
        {
            DataTable dt=ExecuteQuery("select * from project where name='" + name + "'");
            return dt;
        }

        public DataTable GetDepartmentByName(string name)
        {
            DataTable dt = ExecuteQuery("select * from department where name='" + name + "'");
            return dt;
        }
        public DataTable GetProjectByDate(string date)
        {
            DataTable dt = ExecuteQuery("select * from project where startDate='" + date + "'");
            return dt;
        }

        public DataTable GetDepartmentIds()
        {
            DataTable dt = ExecuteQuery("select departmentNumber,name from department");
            return dt;
        }
        public DataTable GetProjectNumbers()
        {
            DataTable dt = ExecuteQuery("select projectNumber,name from project");
            return dt;
        }

        public DataTable GetEmployeeByLastName(string LastName)
        {
            DataTable dt = ExecuteQuery("select * from employee where lastName='" + LastName + "'");
            return dt;
        }

        public DataTable GetEmployeeByFirstName(string FirstName)
        {
            DataTable dt = ExecuteQuery("select * from employee where firstName='" + FirstName + "'");
            return dt;
        }
    }
}