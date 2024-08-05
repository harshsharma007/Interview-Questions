using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearTest
{
    class TestClassByHarsh
    {
        public void SubArray()
        {
            int[] arr = new int[] { 12, 5, 31, 9, 21, 8 };
            int sum = 0, number = 45, currentIndex = 0, index = 0;

            foreach (var item in arr)
            {
                sum += arr[index];
                if (sum == number)
                {
                    int[] newArr = new int[index];
                    Array.Copy(arr, currentIndex, newArr, 0, newArr.Length);
                }
                else if (sum > number)
                {
                    sum = 0;
                    index = currentIndex + 1;
                    currentIndex += 1;
                }
                else
                    index += 1;
            }
        }
    }
}
