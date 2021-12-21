using System;
using System.Collections.Generic;

namespace TwoNumbersAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            var numList = new List<int>() { 10, 15, 3, 7 };
            var num = 17;
            TwoNumbersAdd(numList, num);
        }
        public static void TwoNumbersAdd(List<int> nums, int num)
        {
            for (int i = 0; i < nums.Count; i++)
            {
                for (int j = 0; j < nums.Count; j++)
                {
                    if (nums[i] + nums[j] == num)
                    {
                        Console.WriteLine($"{nums[i]} + {nums[j]} = {num}");
                        break; //this way we stop after the first instances
                    }
                }
            }
        }

        
    }
}