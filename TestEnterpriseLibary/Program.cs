using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TestEnterpriseLibary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string conStr = "Microsoft.Practices.EnterpriseLibrary.Data.Configuration.DatabaseSettings,Microsoft.Practices.EnterpriseLibrary.Data, Version=5.0.414.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35";
            //string cinstr1 = "Server=LAPTOP-1DERTSDM\\MSSQLSERVER2019;Database=[test];Trusted_Connection=True";
            //Database db = DatabaseFactory.CreateDatabase(cinstr1);
            //int count = (int)db.ExecuteScalar(CommandType.Text, "SELECT Count(*) From cms_company");
            //string message = string.Format("There are {0} customers in the database", count.ToString());
            //Console.WriteLine(message);
            //Console.ReadLine();


            //string sqlConnStr = "Server=LAPTOP-1DERTSDM\\MSSQLSERVER2019;Database=test;Trusted_Connection=True";
            //SqlConnection sqlConnection = new SqlConnection(sqlConnStr);
            //try
            //{
            //    sqlConnection.Open();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //string sql = "SELECT * FROM [test].[dbo].[Student]";
            //SqlCommand cmd = new SqlCommand();//创建SQL语句处理对象
            //                                  //或SqlCommand cmd = new SqlCommand(sql,sqlConnection);//构造函数绑定
            //cmd.Connection = sqlConnection;//绑定连接
            //cmd.CommandText = sql;//绑定SQL语句
            //int count = (int)cmd.ExecuteScalar();



            //string conStr = "Microsoft.Practices.EnterpriseLibrary.Data.Configuration.DatabaseSettings,Microsoft.Practices.EnterpriseLibrary.Data, Version=5.0.414.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35";
            //string constr1 = "SqlServer.ConnectionString";
            string str2 = "SqlServer";
            Database db = DatabaseFactory.CreateDatabase(str2);
            int count = (int)db.ExecuteScalar(CommandType.Text, "SELECT * FROM [test].[dbo].[Student]");

            string message = string.Format("There are {0} customers in the database", count.ToString());
            Console.WriteLine(message);
            Console.ReadLine();

        }
    }
}
