using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms
{
    class InsertionSort : IAlgorithm
    {
        public void Run(int[] tab)
        {        
            for(int i = 1; i < tab.Length; i++)
            {
                int j = i;
                while(j > 0 && tab[j-1] > tab[j])
                {
                    SortAlgorithms.swap(ref tab[j - 1], ref tab[j]);
                    j--;
                }           
            }          
        }

    }
}
