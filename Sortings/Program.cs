using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortings
{
    class Program
    {
        public static int[] BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        ConsolePrintArray(array);
                        SwapIntValue(ref array[j], ref array[j + 1]);
                    }
                }
            }
            return array;
        }
        public static void SwapIntValue(ref int firstValue, ref int secondValue)
        {
            int tmpValue = firstValue;
            firstValue = secondValue;
            secondValue = tmpValue;
        }

        public static int[] InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int tmp = array[i];
                int j;
                for (j = i - 1; j >= 0 && array[j] > tmp; j--)
                {
                    ConsolePrintArray(array);
                    SwapIntValue(ref array[j], ref array[j + 1]);
                }

            }
            return array;
        }

        public static int[] QuickSort(int[] array, int leftBound, int rightBound)
        {
            if (leftBound < rightBound)
            {
                int midPivot = array[(leftBound + rightBound) / 2];
                int leftTokenIndex = leftBound, rightTokenIndex = rightBound;

                while (leftTokenIndex <= rightTokenIndex)
                {
                    while (array[leftTokenIndex] < midPivot)
                    {
                        leftTokenIndex++;
                    }
                    while (array[rightTokenIndex] > midPivot)
                    {
                        rightTokenIndex--;
                    }
                    if (leftTokenIndex <= rightTokenIndex)
                    {
                        ConsolePrintArray(array);
                        SwapIntValue(ref array[leftTokenIndex], ref array[rightTokenIndex]);
                        leftTokenIndex++;
                        rightTokenIndex--;
                    }
                }

                if (leftBound < rightTokenIndex)
                {
                    QuickSort(array, leftBound, rightTokenIndex);
                }
                if (leftTokenIndex < rightBound)
                {
                    QuickSort(array, leftTokenIndex, rightBound);
                }
            }
            return array;
        }

        public static void ConsolePrintArray(int[] array)
        {
            foreach (var e in array)
                Console.Write(e + " ");
            Console.WriteLine();
        }


        public static void Main()
        {
            int[] arrayOfInt = new int[] { 5, -7, 3, 2, -7, 1, 0, 10 };
            Console.Write("Изначальный массив: ");
            ConsolePrintArray(arrayOfInt);
            Console.WriteLine("\nВыберите сортировку:\n1. Сортировка пузырьком\n2. Сортировка вставками\n3. Быстрая сортировка\n");
            switch (int.Parse(Console.ReadLine()))
            {
                case (1):
                    BubbleSort(arrayOfInt);
                    break;
                case (2):
                    InsertionSort(arrayOfInt);
                    break;
                case (3):
                    QuickSort(arrayOfInt, 0, arrayOfInt.Length - 1);
                    break;
                default:
                    Console.WriteLine("Ошибка");
                    break;
            }
            ConsolePrintArray(arrayOfInt);
            Console.ReadKey();
        }
    }
}

