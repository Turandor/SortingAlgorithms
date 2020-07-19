using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Alghotihm
{
    class MergeSort : SortAlg, ISortAlg
    {
        public new List<int> Sort()
        {
            List<int> A = new List<int>(task);
            List<int> B = new List<int>(task);
            Split(B, 0,  task.Count, A);

            return A;
        }

        void Split(List<int> B, int iBegin, int iEnd, List<int> A)
        {
            if (iEnd - iBegin < 2)
                return;

            int iMiddle = (iEnd + iBegin) / 2;

            Split(A, iBegin, iMiddle, B); // Left
            Split(A, iMiddle, iEnd, B); // Rigth

            Merge(B, iBegin, iMiddle, iEnd, A);
        }
        void Merge(List<int> A, int iBegin, int iMiddle, int iEnd,  List<int> B)
        {
            int i = iBegin;
            int j = iMiddle;

            for (int k = iBegin; k < iEnd; k++)
            {
                if (i < iMiddle && (j >= iEnd || A[i] <= A[j] ))
                {
                    B[k] = A[i];
                    i++;
                }
                else
                {
                    B[k] = A[j];
                    j++;
                }
            }
        }
        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }
    }

}
