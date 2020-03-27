using OrderLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; set; }

        public static void InitializeConnection(DatabaseType db)
        {
            if (db == DatabaseType.Sql)
            {
                SqlConnection sql = new SqlConnection();
                Connection = sql;
            }            
        }


        public static string ConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }


        public static string AppKeyLookup(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
    }
}
