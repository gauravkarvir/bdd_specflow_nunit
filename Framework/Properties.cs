
using BDD_Specflow_Webdriver.Data;
using Ganss.Excel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD_Specflow_Webdriver.framework
{
   static class Properties
    {
        public static UserData GetUserType(String userType)
        {
            var userExcel = new ExcelMapper("Data.xls").Fetch<UserData>("UserData");
            var userExcelData = userExcel.GetEnumerator();
            while (userExcelData.MoveNext())
            {
                if (userExcelData.Current.UserType.Equals(ConfigurationManager.AppSettings["environment"] + userType))
                {
                    UserData current = userExcelData.Current;
                    Console.Write("Data " + ConfigurationManager.AppSettings["environment"] + userType);
                    return current;
                }

            }
            Console.Write("Error Data not found" + userType + " #######");

            return null;
        }


        



        public static SettingsData Settings(String property)
        {
            var userExcel = new ExcelMapper("Data.xls").Fetch<SettingsData>("Settings");
            var userExcelData = userExcel.GetEnumerator();
            while (userExcelData.MoveNext())
            {
                if (userExcelData.Current.Property.Equals(ConfigurationManager.AppSettings["environment"] + property))
                {
                    SettingsData current = userExcelData.Current;
                    return current;

                }

            }
            Console.Write("Error Data not found for " + property + " #######");

            return null;
        }
        

    }
}
