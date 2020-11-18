using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace WpfApp1.Utilities
{
    public static class AppConfigMethods
    {
        static List<Tuple<string, string>> ReadAllSettings()
        {
            List<Tuple<string,string>> lstSetting = new List<Tuple<string, string>>();
            try
            {
                var appSettings = ConfigurationManager.AppSettings;

                if (appSettings.Count != 0)
                {
                    foreach (var key in appSettings.AllKeys)
                    {
                        var item = Tuple.Create(key, appSettings[key]);
                        lstSetting.Add(item);
                    }
                }
            }
            catch (ConfigurationErrorsException)
            {
                return new List<Tuple<string, string>>();
            }
            return lstSetting;
        }

        static string ReadSetting(string key)
        {
            string res = "Not Found";
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                res = appSettings[key] ?? "Not Found";
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
            }
            return res;
        }

        static void AddUpdateAppSettings(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings");
            }
        }
    }
}
