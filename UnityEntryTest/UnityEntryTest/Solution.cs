using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEntryTest
{
    class Solution
    {



        #region  GrayCode
        public IList<int> GrayCode(int n)
        {

            if (n == 0)
            {
                List<int> result = new List<int>();
                result.Add(0);
                return result;
            }

            List<int> res = (List<int>)GrayCode(n - 1);
            int numToAdd = 1 << (n - 1);

            for (int i = res.Count - 1; i >= 0; i--)
            { 
                res.Add(numToAdd + res[i]);
            }

            return res;
        }
        #endregion

        #region  Maximum Length of Repeated Subarray
        public int FindLength(int[] nums1, int[] nums2)
        {
            int m = nums1.Length, n = nums2.Length;
            int[,] dp = new int[m + 1, n + 1];
            int res = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (nums1[i] == nums2[j])
                    {
                        dp[i + 1, j + 1] = dp[i, j] + 1;
                        res = Math.Max(res, dp[i + 1, j + 1]);
                    }
                }
            }
            return res;
        }
        #endregion

        #region Find Peak Element
        public int FindPeakElement(int[] nums)
        {

            int start = 0;
            int end = nums.Length- 1;
            while (start < end)
            {
                int middle = start + (end - start) / 2;
                if (nums[middle] > nums[middle + 1]) end = middle;
                else start = middle + 1;
            }

            return start;
        }
        #endregion
    }
}

