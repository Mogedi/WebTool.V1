using System;
using System.Collections.Generic;
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
using WebTool.V1.Model;

namespace WebTool.V1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //writeToFile.WriteToFile("Google", "www.google.com");

            List<string> read = ReadInDatabase.ReadingInDatabase();

            foreach (string item in ReadFromFile.Read())
            {
                WebEntryUserControl1 webEntry = new WebEntryUserControl1();

                webEntry.Test(item, stackPanel);

                stackPanel.Children.Add(webEntry);
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (!(string.IsNullOrEmpty(titleTextBlock.Text) || string.IsNullOrEmpty(urlTextBlock.Text)))
            {
                Presenter present = new Presenter();

                present.SetWebsiteTitle(titleTextBlock.Text);

                present.SetUrl(urlTextBlock.Text);

                var info = present.Presenting();

                WebEntryUserControl1 webEntry = new WebEntryUserControl1();

                webEntry.Test(titleTextBlock.Text + "," + urlTextBlock.Text, stackPanel);
                stackPanel.Children.Add(webEntry);

            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //ClearFile.ClearingFile();
            //stackPanel.Children.Clear();
        }
    }
}
