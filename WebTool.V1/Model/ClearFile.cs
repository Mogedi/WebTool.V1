using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WebTool.V1.Model
{
    public class ClearFile
    {
        public static void ClearingFile()
        {
            string directoryPath = "C:\\Users\\" + Environment.UserName + "\\" + Assembly.GetCallingAssembly().GetName().Name + "\\";
            string filePath = "C:\\Users\\" + Environment.UserName + "\\" + Assembly.GetCallingAssembly().GetName().Name
                + "\\" + Assembly.GetCallingAssembly().GetName().Name + " - Database.txt";

            if (System.IO.File.Exists(filePath))
            {
                System.IO.File.WriteAllText(filePath, string.Empty);

            }
        }
    }
}
