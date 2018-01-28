using System;
using System.Net.NetworkInformation;

namespace AlgorithmsAndStructures
{
    public static class StringAlgorithms
    {
        #region Search

        public static int DirectSearch(string str, string subStr)
        {
            int index = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == subStr[index])
                {
                    index++;
                    if (index == subStr.Length - 1)
                        return i - index;
                }
                else
                {
                    index = 0;
                }
            }

            return -1;
        }

        public static int KMPSearch(string text, string subStr)
        {
            int[] prefixes = prefixKMP(subStr);
            int k = 0;
            for (int i = 0; i < text.Length; i++)
            {
                while (k > 0 && text[i] != subStr[k])
                {
                    k = prefixes[k - 1];
                }

                if (subStr[k] == text[i])
                {
                    k++;
                }

                if (k == subStr.Length - 1)
                {
                    return i - subStr.Length + 1;
                }
                
            }

            return -1;
        }

        public static int BMSearch()
        {
            throw new NotImplementedException("I'll do this soon");
        }

        #endregion
        
        

        #region Helpers

        private static int[] prefixKMP(string subString)
        {
            int lenght = subString.Length;
            int[] prefixes = new int[lenght];
            prefixes[0] = 0;

            for (int i = 1; i < lenght; i++)
            {
                int k = prefixes[i - 1];

                while (k > 0 && subString[i] != subString[k])
                {
                    k = prefixes[k - 1];
                }

                if (subString[i] == subString[k])
                {
                    k++;
                }

                prefixes[i] = k;
            }

            return prefixes;
        }

        #endregion
    }
}