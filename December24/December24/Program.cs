using System;
using System.Collections.Generic;
using System.Linq;

namespace December24
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new int[] { -1, -2, -3, 1,2,4,6,7};
            var placelist = new List<int>();
            //iterate through array to take out negatives
            foreach (var item in input)
            {
                if (item > 0)
                {
                    placelist.Add(item);
                }
            }
            int result = 0;
            
            placelist.Sort();
            //check if list starts from 1
            if (placelist.Min() != 1)
            {
                result = placelist.Min() - 1; 
            }
            //if lists does start from 1 check for gap
            else
            {
                for (int i = 0; i < placelist.Count; i++)
                {
                    
                    //stop loop 1 before the end so we don't run out of bounds
                    if (i != placelist.Count - 1)
                    {
                        //check if gap between numbers
                        if ((placelist[i] + 1) != placelist[i + 1] && i != placelist.Count - 1) //next number in list is not one above
                        {
                            result = placelist[i] + 1;
                            break; //print first place gap appears
                        }
                        //if no gap between numbers than first missing positive is 1 more than highest number
                        else
                        {
                            result = placelist.Max() + 1;
                        }
                    }

                }
            }
            //for (int i = 0; i < placelist.Count; i++)
            //{
            //    //get rid of duplicates
            //    if (placelist[i] == placelist[i + 1] && placelist[i + 1] != placelist.Count)
            //    {
            //        placelist.Remove(placelist[i + 1]);
            //    }
            //}
            
            
            
            
            
            Console.WriteLine(result);
        }
    }
}
