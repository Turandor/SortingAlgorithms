using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.TextFormatting;

namespace Sorting_Alghotihm
{
    public class BubbleSort : SortAlg, ISortAlg
    {
        public new List<int> Sort()
        {
            int n = task.Count();
            int tmpValue;
            do
            {
                for (int i = 0; i < n-1; i++)
                {
                    if (task[i] > task[i + 1])
                    {
                        tmpValue = task[i];
                        task[i] = task[i + 1];
                        task[i + 1] = tmpValue;
                    }
                }
                n = n - 1;
            } while (n > 1);

            return task;
        }
    }
}
