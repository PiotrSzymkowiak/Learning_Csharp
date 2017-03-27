using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms
{
    class Program
    {

        public static void testExecTime(int[] tab, IAlgorithm alg)
        {
            SortAlgorithms.AlgorithmDelegate Algorithm_Delegate = new SortAlgorithms.AlgorithmDelegate(alg.Run);
            var time = SortAlgorithms.timeOfExecution(tab, Algorithm_Delegate);
            Console.WriteLine($"time: {time}");
        }

        public static void testResultsDemonstration(int[] tab, IAlgorithm alg)
        {
            SortAlgorithms.ShowTab(tab);
            alg.Run(tab);
            SortAlgorithms.ShowTab(tab);
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            IAlgorithm bubble = new BubbleSort();
            IAlgorithm insertion = new InsertionSort();

            int[] tab = { 5, 2, 9, 3, 7, 1, 6, 4, 8 };
            int[] tab2 = SortAlgorithms.GenerateRandomArray(25, 0, 29);           
            int[] tab3 = SortAlgorithms.GenerateRandomArray(25);         
            int[] tab4 = SortAlgorithms.GenerateRandomArray(15, 100);                      
            int[] tab5 = SortAlgorithms.GenerateRandomArray(25000, 0, 1000000);

            
            testResultsDemonstration((int[])tab.Clone(), bubble);           
            testResultsDemonstration((int[])tab.Clone(), insertion);

            // testExecTime((int[])tab5.Clone(), bubble);
            // testExecTime((int[])tab5.Clone(), insertion);
            testResultsDemonstration((int[])tab2.Clone(), SortAlgorithms.insertionSort);
            testExecTime((int[])tab2.Clone(), SortAlgorithms.insertionSort);

            Console.ReadLine();

        }     
    }
}
