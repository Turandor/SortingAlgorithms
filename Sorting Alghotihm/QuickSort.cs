using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.TextFormatting;

namespace Sorting_Alghotihm
{
    class QuickSort : SortAlg, ISortAlg
    {
        public new List<int> Sort()
        {
            DoQuickSort(0, task.Count-1);
            return task;
        }

        void DoQuickSort (int iBegin, int iEnd)
        {
            int iSplit;
            if (iBegin<iEnd-1)
            {
                iSplit = SplitTask(iBegin, iEnd);
                //if (iSplit-1-iBegin > 10)
                    DoQuickSort(iBegin, iSplit - 1);
                /*
                else
                {
                    InsertSort insertSort = new InsertSort();
                    insertSort.LoadTask(task.GetRange(iBegin, (iSplit-1-iBegin)));
                    task.InsertRange(iBegin, insertSort.Sort());
                }

                iSplit = SplitTask(iBegin, iEnd);
                if (iEnd - (iSplit + 1) > 10)
                */
                    DoQuickSort(iSplit + 1, iEnd);
                /*
                else
                {
                    InsertSort insertSort = new InsertSort();
                    insertSort.LoadTask(task.GetRange(iBegin, (iEnd - (iSplit + 1))));
                    task.InsertRange(iBegin, insertSort.Sort());
                }
                */
            }
        }
        int SplitTask(int iBegin, int iEnd)
        {
            int iSplit = ChooseSplitPoint(iBegin, iEnd);
            int splitValue = task[iSplit];
            Swap(iSplit, iEnd);

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

        int ChooseSplitPoint (int iBegin, int iEnd)
        {
            return iBegin + (iEnd - iBegin) / 2;
            //return iEnd;
        }

        void Swap (int i1, int i2)
        {
            int tmp = task[i1];
            task[i1] = task[i2];
            task[i2] = tmp;
        }
    }
}
