using System;
using System.Collections.Generic;
using System.Linq;
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
using System.IO;
using Microsoft.Win32;


namespace Sorting_Alghotihm
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void chooseFileButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "txt files (*.txt)|*.txt";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == true)
            {
                txtEditor.Text = File.ReadAllText(openFileDialog.FileName);
                filePath.Text = openFileDialog.FileName;
                filePath.Visibility = Visibility.Visible;
                var logFile = File.ReadAllLines(openFileDialog.FileName);
                var task = logFile.Select(int.Parse).ToList();
            }

        }

        private void sortButton_Click(object sender, RoutedEventArgs e)
        {
            ISortAlg sortAlg;
            if ((bool)mergeRB.IsChecked)
                sortAlg = new MergeSort();
            else if ((bool)insertRB.IsChecked)
                sortAlg = new InsertSort();
            //else ((bool)bubbleRB.IsChecked)
            else
                sortAlg = new BubbleSort();


            sortAlg.LoadTask(filePath);
            List<int> outputTask = new List<int>(sortAlg.Sort());

            string outputString = string.Join(",", outputTask.ToArray());
            OutputText.Text = outputString;
        }
        private void resetButton_Click(object sender, RoutedEventArgs e)
        {
            OutputText.Text = null;
        }
    }
}
