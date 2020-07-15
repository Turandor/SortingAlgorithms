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

            List<int> taskToDo = new List<int>();
            taskToDo.Add(3);
            taskToDo.Add(2);
            taskToDo.Add(4);
            taskToDo.Add(1);
            taskToDo.Add(6);
            taskToDo.Add(5);

            BubbleSort bubbleSort = new BubbleSort();
            bubbleSort.LoadTask(taskToDo);
            List<int> outputTask = new List<int>(bubbleSort.DoBubbleSort());

            string inputString = string.Join(",", taskToDo.ToArray());
            OutputText.Text = inputString;
            string outputString = string.Join(",", outputTask.ToArray());
            OutputText.Text = outputString;

        }
    }
}
