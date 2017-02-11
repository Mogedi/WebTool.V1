using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebTool.V1.Model;

namespace WebTool.V1
{
    public class PresenterInfo
    {
        public string WebsiteTitle { get; set; }

        public string Url { get; set; }

        public List<string> DatabaseData { get; set; }

    }

    public class Presenter
    {
        PresenterInfo Info = new PresenterInfo();

        public PresenterInfo Presenting()
        {
            writeToFile.WriteToFile(Info.WebsiteTitle, Info.Url);

            Info.DatabaseData = ReadFromFile.Read();

            return Info; 
        }

        public void SetWebsiteTitle(string WebsiteTitle)
        {
            Info.WebsiteTitle = WebsiteTitle;
        }

        public void SetUrl(string Url)
        {
            Info.Url = Url;
        }
    }
}
