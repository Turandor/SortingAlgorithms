using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.TextFormatting;

namespace Sorting_Alghotihm
{
    class BubbleSort
    {
        private List<int> task;

        public List<int> DoBubbleSort()
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

        public void LoadTask(List<int> taskToLoad)
        {
            task = taskToLoad;
        }
    }
}
