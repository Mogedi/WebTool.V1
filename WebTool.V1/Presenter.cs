using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebTool.V1.Model;

namespace WebTool.V1
{
    class Presenter
    {
        public class PresenterInfo
        {
            public string WebsiteTitle { get; set; }

            public string Url { get; set; }

        }

        public PresenterInfo Presenting()
        {
            PresenterInfo presentInstance = new PresenterInfo();

            WriteToFile.WriteToFile("Google", "www.google.com");

            return presentInstance; 
        }
    }
}
