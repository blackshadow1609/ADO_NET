using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ADO.NET:
using System.Data.SqlClient;
using System.Configuration;

namespace ADO_NET
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Connector connector = new Connector(ConfigurationManager.ConnectionStrings["Movies"].ConnectionString);
            connector.SelectWithParameters("James", "Cameron");
        }
    }
}

