using System;

namespace Open_Lab_04._13
{
    public class StringTools
    {
        public string GetLongestCommonSequence(string str1, string str2)
        {
            int j = 0;
            int i = 0;
            string longestSubstring = "";

            for (i = 1; i <= str1.Length; i++)
            {
                for (j = 0; j <= str1.Length - i; j++)
                {
                    if (str2.Contains(str1.Substring(j, i)))
                    {
                        longestSubstring = str1.Substring(j, i);
                    }
                }
            }
            return longestSubstring;
        }
    }
}
                   
                    
