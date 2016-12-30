using Dapper;
using SQLProcessor.Library.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLProcessor.Library
{
    public class DBCommands
    {
        public static DataCommandResultModel ProcessStatement(string statement, string connectionStringName = "")
        {
            DataCommandResultModel output = new DataCommandResultModel();
            int rows = 0;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(LoadConnectionString(connectionStringName)))
            {
                try
                {
                    rows = connection.Execute(statement);
                    output.StatusId = Enums.ResultStatus.Success;
                    output.StatusMessage = "";
                    output.RecordsAffected = rows;
                }
                catch (Exception ex)
                {
                    output.StatusId = Enums.ResultStatus.Error;
                    output.StatusMessage = ex.Message;
                    output.RecordsAffected = -1;
                }
            }

            return output;
        }

        internal static string LoadConnectionString(string id = "")
        {
            string output = "";

            if (id.Length > 0)
            {
                output = System.Configuration.ConfigurationManager.ConnectionStrings[id].ConnectionString;
            }
            else
            {
                output = System.Configuration.ConfigurationManager.ConnectionStrings[1].ConnectionString;
            }

            return output;
        }
    }
}
