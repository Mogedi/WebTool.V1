using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WebTool.V1
{
    /// <summary>
    /// Interaction logic for WebEntryUserControl1.xaml
    /// </summary>
    public partial class WebEntryUserControl1 : UserControl
    {
        private string webTitle;
        private string url;
        private Panel stackPanel;
        public WebEntryUserControl1()
        {
            InitializeComponent();
        }

        public void Test(string webString, Panel stackPanel)
        {
            webTitle = webString.Split(',')[0];
            url = webString.Split(',')[1];
            this.stackPanel = stackPanel;

            webTitleTextBlock.Text = webString.Split(',')[0];
            urlTextBlock.Text = webString.Split(',')[1];
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("chrome.exe", url);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string lineToRemove = webTitle.Trim() + "," + url.Trim();

            string filePath = "C:\\Users\\" + System.Environment.UserName + "\\" + "WebTool.V1"
               + "\\" + "WebTool.V1" + " - Database.txt";

            Console.WriteLine(filePath);

            List<string> lines = (System.IO.File.ReadAllLines(filePath)).ToList<string>();

            Console.WriteLine(lines.Count);

            Console.WriteLine(lineToRemove);

            Console.WriteLine(lines.IndexOf(lineToRemove));

            lines.RemoveAt(lines.IndexOf(lineToRemove));

            System.IO.File.WriteAllLines(filePath, lines.ToArray());

            this.stackPanel.Children.Remove(this);


        }
    }
}
