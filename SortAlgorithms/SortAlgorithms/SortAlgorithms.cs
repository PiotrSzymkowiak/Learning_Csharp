using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SortAlgorithms
{
    class SortAlgorithms
    {
        public static InsertionSort insertionSort = new InsertionSort();
        public static BubbleSort bubbleSort = new BubbleSort();
        public delegate void AlgorithmDelegate(int[] tab);

        public static void ShowTab(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++) Console.Write(tab[i] + " ");
            Console.Write("\n");
        }
        
        public static void swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }

        public static int[] GenerateRandomArray(int len, int leftBorder, int rightBorder)
        {
            if (leftBorder > rightBorder) throw new ArgumentOutOfRangeException("leftBorder",
                                                                                (int)leftBorder, 
                                                                                "the arg 'leftBorder' is higher than the 'rightBorder'" );

            int[] tab = new int[len];
            Random rnd = new Random();

            for(int i = 0; i < tab.Length; i++)
            {
                tab[i] = rnd.Next(leftBorder, rightBorder);
            }

            return tab;
        }

        public static int[] GenerateRandomArray(int len)
        {
            
            int[] tab = new int[len];
            Random rnd = new Random();

            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = i;    
            }

            for (int i = 0; i < tab.Length; i++)
            {
                int firstIdx = rnd.Next(tab.Length);
                int secondIdx = rnd.Next(tab.Length);
                if (firstIdx == secondIdx) continue;
                SortAlgorithms.swap(ref tab[firstIdx], ref tab[secondIdx]);
            }

            return tab;
        }

        public static int[] GenerateRandomArray(int len, int minValue)
        {

            int[] tab = new int[len];
            Random rnd = new Random();

            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = i + minValue;
            }

            for (int i = 0; i < tab.Length; i++)
            {
                int firstIdx = rnd.Next(tab.Length);
                int secondIdx = rnd.Next(tab.Length);
                if (firstIdx == secondIdx) continue;
                SortAlgorithms.swap(ref tab[firstIdx], ref tab[secondIdx]);
            }

            return tab;
        }

        public static long timeOfExecution(int[] tab, AlgorithmDelegate alg)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            alg(tab);
            var elapsedMs = watch.ElapsedMilliseconds;

            return elapsedMs;
        }


    }
}
