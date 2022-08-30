using System;

namespace ClassProject
{
    class Program
    {
        public static string MostCommonWord()
        {
            string paragraph = "Bob hit a ball, the hit BALL flew far after it was hit";
            string banned = "hit";
            paragraph.ToLower();

            for(int i = 1; i < paragraph.Length; i++)
            {
                if(paragraph[i].Length == 2 && paragraph[i].Length != banned)
                {
                    return paragraph;
                }
            }
        }
        // public static int kindergartin(int[] n)
        // {

        // }
        public static int commonChild()
        {
            string s1 = "ABCDY";
            string s2 = "ABCDFR";
            
            for(int i = 0;)
            {

            }
        }

        // public static bool arrayElement()
        // {

        // }
        // public static string numberGame()
        // {

        // }
    }
}
