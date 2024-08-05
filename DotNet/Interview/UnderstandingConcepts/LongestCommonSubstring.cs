using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearTest
{
    class LongestCommonSubstring
    {
        public LongestCommonSubstring(string firstString, string secondString)
        {
            firstString = firstString.ToLower();
            secondString = secondString.ToLower();
            int[,] l = new int[firstString.Length, secondString.Length];
            int end = -1, lcs = -1;
            string substring = string.Empty;

            for (int i = 0; i < firstString.Length; i++)
            {
                for (int j = 0; j < secondString.Length; j++)
                {
                    if (firstString[i] == secondString[j])
                    {
                        if (i == 0 || j == 0)
                        {
                            l[i, j] = 1;
                        }
                        else
                        {
                            l[i, j] = l[i - 1, j - 1] + 1;
                        }

                        if (l[i, j] > lcs)
                        {
                            lcs = l[i, j];
                            end = 1;
                        }
                    }
                }
            }

            for (int i = end - lcs + 1; i <= end; i++)
            {
                substring += firstString[i];
            }

            Console.WriteLine(substring != string.Empty ? "Longest Common Substring {0}" : "No Common Substring", substring.ToUpper());
        }
    }
}
