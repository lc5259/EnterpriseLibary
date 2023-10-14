using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string conStr = "Microsoft.Practices.EnterpriseLibrary.Data.Configuration.DatabaseSettings,Microsoft.Practices.EnterpriseLibrary.Data, Version=5.0.414.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35";
            string constr1 = "SqlServer.ConnectionString";
            string str2 = "SqlServer";
            string str3 = "SqlserverODBC";
            Database db = DatabaseFactory.CreateDatabase(str3);

            //string dbStr = string.Format("update Student  set name = '{1}', address ='{2}' where id = {0}",
            //    db.BuildParameterName(":id"),
            //    db.BuildParameterName("@name"),
            //    db.BuildParameterName("@address")
            //    );
            //DbCommand cmd = db.GetSqlStringCommand(dbStr);
            //db.AddInParameter(cmd, "id", DbType.Int32,1);
            //db.AddInParameter(cmd, "name", DbType.String, "mike");
            //db.AddInParameter(cmd, "address", DbType.String,"上海");
            //int count = (int)db.ExecuteScalar(cmd);
            //int count = (int)db.ExecuteScalar(CommandType.Text, "SELECT * FROM [test].[dbo].[Student]");


            //and t.id = { 0}
            string dbStr = string.Format(" SELECT * FROM [test].[dbo].[Teacher] t  where t.id = {0};",
                db.BuildParameterName("@id")
                //db.BuildParameterName("@name")

                );
            DbCommand cmd = db.GetSqlStringCommand(dbStr);
            db.AddInParameter(cmd, "id", DbType.String, '1');
            //db.AddInParameter(cmd, "name", DbType.String, "gasg");
            object sgah = db.ExecuteScalar(cmd);
            //int count = (int)db.ExecuteScalar(cmd);


            //string message = string.Format("There are {0} customers in the database", count.ToString());
            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}
