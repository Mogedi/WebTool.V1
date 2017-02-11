using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WebTool.V1.Model
{
    class ReadInDatabase
    {
        public static List<string> ReadingInDatabase()
        {
            string directoryPath = "C:\\Users\\" + Environment.UserName + "\\" + Assembly.GetCallingAssembly().GetName().Name + "\\";
            string filePath = "C:\\Users\\" + Environment.UserName + "\\" + Assembly.GetCallingAssembly().GetName().Name
                + "\\" + Assembly.GetCallingAssembly().GetName().Name + " - Database.txt";

            Console.WriteLine(filePath);

            if (!(System.IO.File.Exists(filePath)))
            {
                Console.WriteLine(filePath);

                System.IO.Directory.CreateDirectory(directoryPath);
                System.IO.File.Create(filePath).Close();
            }

            List<string> servers = new List<string>();

            string line;

            System.IO.StreamReader file = new System.IO.StreamReader(filePath);

            while ((line = file.ReadLine()) != null)
            {
                servers.Add(line.Split(',')[0] + ", " + line.Split(',')[1]);
            }

            file.Close();

            return servers;
        }
    }
}
