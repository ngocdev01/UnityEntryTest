using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEntryTest
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] nums1 = { 1, 2, 3, 2, 1 }, nums2 = { 3, 2, 1, 4, 7 };


            Console.WriteLine("Gray Code");
            List<int> res = (List<int>)solution.GrayCode(4);

            foreach(int number in res)
            {
                Console.WriteLine(number);
            }


            Console.WriteLine("Maximum Length of Repeated Subarray");
            Console.WriteLine(solution.FindLength(nums1, nums2));




            Console.WriteLine("Find Peak Element");
            Console.WriteLine(solution.FindPeakElement(nums1));
            Console.ReadLine();



        }
    }

}


