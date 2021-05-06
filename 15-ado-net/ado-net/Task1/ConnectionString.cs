using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace Task1
{
    class ConnectionString
    {
        public static string CnnVal
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["ConnectDB"].ConnectionString;
            }
        }
    }
}
