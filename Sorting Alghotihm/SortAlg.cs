using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Sorting_Alghotihm
{
    class SortAlg : ISortAlg
    {
        protected List<int> task;

        public void LoadTask(TextBlock filePath)
        {
            var logFile = File.ReadAllLines(filePath.Text);
            task = logFile.Select(int.Parse).ToList();
        }
        public List<int> Sort() { return null; }



    }
}
