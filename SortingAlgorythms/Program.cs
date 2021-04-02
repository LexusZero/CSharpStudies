using System;

namespace SortingAlgorythms
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 10;
            int[] array = new int[size];
            InitializeArray(array);
            int[] copy = new int[size];
            Array.Copy(array, copy, size);
            MergeSort(array, copy, 0, size - 1);
            PrintArray(array);
        }

        static void InitializeArray(int[] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next() % 100;
            }
        }

        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ", ");
            }
            Console.WriteLine();
        }

        static void SortArray(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[i - 1])
                {
                    Swap(array, i, i - 1);
                }
            }
        }

        static void BubbleSort(int[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--) 
            {
                for (int j = i + 1; j < array.Length; j++)  
                {
                    if (array[j] < array[j - 1])        
                    {
                        Swap(array, j, j - 1);
                    }
                }
            }
        }

        static void MergeSort(int[] array, int[] copy, int startIndex, int endIndex)
        {
            if (endIndex <= startIndex)
            {
                return;
            }
            int middleIndex = (startIndex + endIndex) / 2;
            MergeSort(copy, array, startIndex, middleIndex);
            MergeSort(copy, array, middleIndex + 1, endIndex);

            int leftIndex = startIndex;
            int rightIndex = middleIndex + 1;
            int currentIndex = startIndex;
            
            while (rightIndex <= endIndex && leftIndex <= middleIndex)
            {
                if (copy[leftIndex] <= copy[rightIndex])
                {
                    array[currentIndex] = copy[leftIndex];
                    currentIndex++;
                    leftIndex++;
                }
                else
                {
                    array[currentIndex] = copy[rightIndex];
                    currentIndex++;
                    rightIndex++;
                }
            }

            while (leftIndex <= middleIndex)
            {
                array[currentIndex] = copy[leftIndex];
                currentIndex++;
                leftIndex++;
            }

            while (rightIndex <= endIndex)
            {
                array[currentIndex] = copy[rightIndex];
                currentIndex++;
                rightIndex++;
            }
        }

        static void InternalSort(int[] array)
        {
            Array.Sort(array);
        }

        static void Swap(int[] array, int index1, int index2)
        {
            int tmp = array[index1];
            array[index1] = array[index2];
            array[index2] = tmp;
        }
    }
}
