using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.TextFormatting;

namespace Sorting_Alghotihm
{
    public class QuickSort : SortAlg, ISortAlg
    {
        public new List<int> Sort()
        {
            DoQuickSort(0, task.Count-1);
            return task;
        }

        void DoQuickSort(int iBegin, int iEnd)
        {
            int iSplit;
            if (iBegin < iEnd)
            {
                iSplit = SplitTask(iBegin, iEnd);
                DoQuickSort(iBegin, iSplit - 1);
                DoQuickSort(iSplit + 1, iEnd);
            }
        }
        int SplitTask(int iBegin, int iEnd)
        {
            int pivot = ChoosePivot(iBegin, iEnd);
            int splitValue = task[pivot];
            Swap(pivot, iEnd);

            int iCurrent = iBegin;

            for (int i = iBegin; i < iEnd; i++)
            {
                if (task[i] < splitValue)
                {
                    Swap(i, iCurrent);
                    iCurrent++;
                }
            }
            Swap(iCurrent, iEnd);
            return iCurrent;
        }

        int ChoosePivot (int iBegin, int iEnd)
        {
            return iBegin + (iEnd - iBegin) / 2;
        }

        void Swap (int i1, int i2)
        {
            int tmp = task[i1];
            task[i1] = task[i2];
            task[i2] = tmp;
        }
    }
}
