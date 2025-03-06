using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weekly_Assesment2
{
public sealed class ConfigurationManager
    {
        private static ConfigurationManager _instance;
        private static readonly object _lock = new object();

        public string ConfigSetting { get; set; }

        private ConfigurationManager()
        {
            ConfigSetting = "Default Config";
        }

        public static ConfigurationManager GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new ConfigurationManager();
                    }
                }
            }
            return _instance;
        }
    }
    //class Program
    //{
    //    static void Main()
    //    {
    //        ConfigurationManager config1 = ConfigurationManager.GetInstance();
    //        config1.ConfigSetting = "Database: SQLServer";

    //        ConfigurationManager config2 = ConfigurationManager.GetInstance();
    //        Console.WriteLine(config2.ConfigSetting); // Output: Database: SQLServer

    //        Console.WriteLine(ReferenceEquals(config1, config2)); // Output: True
    //    }
    //}
}
