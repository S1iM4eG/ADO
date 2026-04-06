using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using DBtools;

namespace DLLCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Connector connector = new Connector(ConfigurationManager.ConnectionStrings["MoviesPV_522"].ConnectionString);
            connector.Select("*", "Directors");
            connector.Select("title,release_date,first_name,last_name", "Movies,Directors", "director = director_id");
            Connector connectorAcademy = new Connector(ConfigurationManager.ConnectionStrings["PV_522_Import"].ConnectionString);
            connectorAcademy.Select("*", "Disciplines");
        }
    }
}
