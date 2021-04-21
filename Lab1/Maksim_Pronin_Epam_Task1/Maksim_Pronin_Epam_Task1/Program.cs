using System;

namespace Maksim_Pronin_Epam_Task1
{
    class Program
    {
        static void SortedArr(double[] arr)
        {

            for (int j = 0; j < arr.Length; j++) 
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if(arr[i] > arr[i + 1])
                    {
                        double lokalSortArr = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = lokalSortArr;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Arr[" + (i + 1) + "] = " + arr[i]);
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the size of the array");
            int syzeArr = int.Parse(Console.ReadLine());
            double[] array = new double[syzeArr];
            for (int i = 0; i < syzeArr; i++)
            {
                Console.Write("Arr[" + (i + 1) + "] = ");
                array[i] = double.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            SortedArr(array);
            Console.ReadLine();
        }
    }
}
