using System;
using System.Collections.Generic;

namespace DojoListeEtDictionnaire
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integersList = new List<int> { 1, 2, 3, 4, 76, 89, 32, 4565, 789, 43, 765 };
            Console.WriteLine(GetSumList(integersList)); 
            Console.WriteLine(CalculateMean(integersList));
            SortList(integersList);
            //foreach (int el in integersList)
                //{
                //    Console.WriteLine(el);
                //}
            Console.WriteLine(integersList);


        }

        public static int GetSumList(List<int> integersList)
        {
            
            int sum = 0;
            foreach (int el in integersList)
            {
                sum = sum + el;
            }
            return sum; 
        }

        public static double CalculateMean(List<int> integersList)
        {
            double mean = GetSumList(integersList) / integersList.Count;
            return mean;
        }

        public static void SortList(List<int> integersList)
        {
            for (int i = 0; i < integersList.Count - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < integersList.Count; j++)
                {
                    if (integersList[minIndex] > integersList[j])
                    {
                        minIndex = j;
                    }
                }
                int temp;
                temp = integersList[i];
                integersList[i] = integersList[minIndex];
                integersList[minIndex] = temp;
            }
        }

    }
}
