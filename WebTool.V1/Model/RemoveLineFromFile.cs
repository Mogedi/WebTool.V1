using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WebTool.V1.Model
{
    class RemoveLineFromFile
    {
        public void RemoveLine(string lineToRemove)
        {
            string filePath = "C:\\Users\\" + System.Environment.UserName + "\\" + Assembly.GetCallingAssembly().GetName().Name
               + "\\" + Assembly.GetCallingAssembly().GetName().Name + " - Database.txt";

            List<string> lines = (System.IO.File.ReadAllLines(filePath)).ToList<string>();

            Console.WriteLine(lines.Count);

            lines.RemoveAt(lines.IndexOf(lineToRemove));

            System.IO.File.WriteAllLines(filePath, lines.ToArray());
        }
    }
}
