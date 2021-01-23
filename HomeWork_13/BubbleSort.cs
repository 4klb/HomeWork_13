using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_13
{
    public class BubbleSort : List<int>
    {
        public void BubbleSortMethod(int[] array)
        {
            int temporary;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temporary = array[i];
                        array[i] = array[j];
                        array[j] = temporary;
                    }
                }
            }
        }
    }
}
