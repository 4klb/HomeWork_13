using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace HomeWork_13
{
    class Program
    {
        static void Main(string[] args)
        { 
            var list = new List<int>();
            list.Add(8);
            list.Add(6);
            list.Add(4);
            int maximumValue = 0;
            int maximumIndex = 0;
            int secondMaximumValue = 0;
            int secondMaximumIndex = 0;
            int sum = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > maximumValue)
                {
                    maximumValue = list[i];
                    maximumIndex = i;
                }
            }

            for(int i = 0; i < list.Count; i++)
            {
                if(list[i] > secondMaximumValue && list[i] != maximumValue)
                {
                    secondMaximumValue = list[i];
                    secondMaximumIndex = i;
                }
            }
            Console.WriteLine($"Индекс второго максимального элемента {secondMaximumIndex}");

            for(int i = 0; i < list.Count; i++)
            {
                if(i %2 == 0 && i != 0)
                {
                    sum += list[i];
                }
            }
            Console.WriteLine($"Сумма элементов на четных позициях {sum}");

            Console.WriteLine($"Пузырьковая сортировка");
            var bubbleSort = new BubbleSort();
            bubbleSort.Add(8);
            bubbleSort.Add(5);
            bubbleSort.Add(6);
            bubbleSort.Add(4);

            int[] array = new int[bubbleSort.Count];

            for (int i = 0; i < bubbleSort.Count; i++)
            {
                array[i] = bubbleSort[i];
            }

            bubbleSort.BubbleSortMethod(array);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadLine();
        }
    }
}
