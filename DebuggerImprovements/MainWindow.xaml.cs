using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows;

namespace DebuggerImprovements
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnThrow_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var num = int.Parse("abc");
            }
            catch (Exception inner)
            {
                var logFileName = "DoesNotExist";

                try
                {
                    var openLog = File.Open(logFileName, FileMode.Open);
                    //TODO: Log stuff
                }
                catch 
                {
                    throw new FileNotFoundException($"Could not find file \'{logFileName}\'", inner);
                }
            }
        }

        private void BtnThrowNull_Click(object sender, RoutedEventArgs e)
        {
            Person p = new Person();
            LocationUtilities.FindCity(p.Address.ZipCode);
        }

        private void BtnRunToClick_Click(object sender, RoutedEventArgs e)
        {
            string[] lines = { "First line", "Second line", "Third line" };

            string mydocpath =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter outputFile = new StreamWriter(mydocpath + @"\WriteLines.txt"))
            {
                foreach (string line in lines)
                    outputFile.WriteLine(line);
            }
        }
    }
}
