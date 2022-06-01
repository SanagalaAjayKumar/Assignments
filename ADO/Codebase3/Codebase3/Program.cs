using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Codebase3
{
    internal class Program
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;



        public static void insertEmployee()
        {
            try
            {
                con = getconnection();
                Console.WriteLine("Enter the Employee name : ");
                string ename = Console.ReadLine();
                Console.WriteLine("Enter the Employee Salary : ");
                float esal = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Enter the Employee type (C or P) : ");
                string etype = Console.ReadLine();
                cmd = new SqlCommand("AddEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd = new SqlCommand("execute Addnewemploye @ename,@esal,@etype");
                cmd.Parameters.Add(new SqlParameter("@ename", ename));
                cmd.Parameters.Add(new SqlParameter("@esal", esal));
                cmd.Parameters.Add(new SqlParameter("@etype", etype));

                cmd.Connection = con;
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine("rows effected :{0}", res);
                }
                else
                {
                    Console.WriteLine("No Row Effected");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void DisplayAllEmployee()
        {
            con = getconnection();


            cmd = new SqlCommand("select * from Code_Employee", con);



            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine("Emp Id is : " + dr[0]);
                Console.WriteLine("Emp name is : " + dr[1]);
                Console.WriteLine("Emp Salary is : " + dr[2]);
                Console.WriteLine("Emp Type is : " + dr[3]);


            }
        }
        public static SqlConnection getconnection()
        {
            con = new SqlConnection("data source =RMGW58ZLPC0941\\SQLEXPRESS ; initial catalog =EmployeeManagement; user id = sa; password=Temp1234");
            con.Open();
            return con;
        }
        static void Main(string[] args)
        {
            insertEmployee();
            DisplayAllEmployee();
            Console.Read();
        }
    }
}
