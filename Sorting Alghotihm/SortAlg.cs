﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Sorting_Alghotihm
{
    public class SortAlg : ISortAlg
    {
        protected List<int> task;
        public List<int> Task => task;
        public void LoadTask(List<int> taskList)
        {
            task = taskList;
        }
        public void LoadTaskFromFile(TextBlock filePath)
        {
            var logFile = File.ReadAllLines(filePath.Text);
            task = logFile.Select(int.Parse).ToList();
        }
 
        public List<int> Sort() { return null; }

    }
}
