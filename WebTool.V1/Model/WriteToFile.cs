using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WebTool.V1.Model
{
    class WriteToFile
    {
        public static void WriteToFile(string websiteTitle, string url)
        {
            string directoryPath = "C:\\Users\\" + System.Environment.UserName;
            string filePath = "C:\\Users\\" + System.Environment.UserName + "\\" + Assembly.GetCallingAssembly().GetName().Name  
                + "\\" + Assembly.GetCallingAssembly().GetName().Name + " - Database.txt";

            Console.WriteLine(filePath);

            if (!(System.IO.File.Exists(filePath)))
            {
                System.IO.Directory.CreateDirectory(directoryPath);
                System.IO.File.Create(filePath).Close();
            }

            System.IO.File.AppendAllText(filePath, websiteTitle + "," + url + Environment.NewLine);
        }
    }
}
