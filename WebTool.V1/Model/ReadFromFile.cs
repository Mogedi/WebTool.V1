using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WebTool.V1.Model
{
    class ReadFromFile
    {
        public static List<string> Read()
        {
            List<string> servers = new List<string>();

            string line;

            string filePath = "C:\\Users\\" + System.Environment.UserName + "\\" + Assembly.GetCallingAssembly().GetName().Name
                + "\\" + Assembly.GetCallingAssembly().GetName().Name + " - Database.txt";

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
