using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_II_PreLab_2
{
    public class AppHelper
    {
        public static string ConnectionString=>ConfigurationManager.ConnectionStrings["OOP_II_PreLab_2.Properties.Settings.cn"].ConnectionString;
    }
}
