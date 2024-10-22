using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class LonestCommon
    {
        public static int LonestCommonSubSeq(string str, string sample)
        {
            int n = str.Length;
            int m = sample.Length;

            int[] prev = new int[m + 1];
            int[] cur = new int[m + 1];

            for (int ind1 = 1; ind1 <= n; ind1++)
            {
                for (int ind2 = 1; ind2 <= m; ind2++)
                {

                    if (str[ind1 - 1] == sample[ind2 - 1])
                        cur[ind2] = 1 + prev[ind2 - 1];

                    else
                        cur[ind2] = Math.Max(prev[ind2], cur[ind2 - 1]);
                }
                // Update the 'prev' array to the values of 'cur' for the next iteration
                prev = (int[])(cur.Clone());
            }

            return prev[m];
        }
    }
}
