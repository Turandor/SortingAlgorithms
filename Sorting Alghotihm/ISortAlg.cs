using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Sorting_Alghotihm
{
    interface ISortAlg
    {
        List<int> Sort();
        void LoadTaskFromFile(TextBlock textBlock);
    }
}
