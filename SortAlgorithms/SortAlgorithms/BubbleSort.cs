using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms
{
    class BubbleSort : IAlgorithm
    {
        public void Run(int[] tab)
        {
            bool swapped = true;
            while (swapped)
            {
                swapped = false;   
                for (int i = 1; i < tab.Length; i++)
                {
                    if (tab[i - 1] > tab[i])
                    {
                        SortAlgorithms.swap(ref tab[i - 1], ref tab[i]);
                        swapped = true;
                    }
                }
            }
        }


    }
}
