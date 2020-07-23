using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Sorting_Alghotihm
{
    class InsertSort : SortAlg, ISortAlg
    {
        public new List<int> Sort()
        {
            int n = task.Count();
            int tmpValue;
            int i = 1;
            int j;

            while (i < n)
            {
                tmpValue = task[i];
                j = i - 1;
                while (j >= 0 && task[j] > tmpValue)
                {
                    task[j + 1] = task[j];
                    j = j - 1;
                }
                task[j + 1] = tmpValue;
                i++;
            }

            return task;
        }

    }
}
