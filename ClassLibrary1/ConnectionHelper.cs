using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivestockDataAccess
{
    public class ConnectionHelper
    {
        //public static string StringName { get; set; }
        public static string CnnVal(string name)
        {
            //StringName = name;
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
        //public static string CnnVal()
        //{
        //    return ConfigurationManager.ConnectionStrings[StringName].ConnectionString;
        //}
    }
}
