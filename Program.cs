using System;

namespace ClassProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string paragraph = "Bob hit a ball, the hit BALL flew far after it was hit";
            string banned = "hit";
            paragraph.ToLower();

            for(char i = 0; i < Convert.ToChar(paragraph); i++)
            {
                if(paragraph[i].Length == 2 && !paragraph[i].Length == banned)
                {
                    Console.WriteLine(i);
                }
            }
        }
        // public static int kindergartin(int[] n)
        // {

        // }
        // public static  commonChild()
        // {
        //     int max = 0;
        //     string s1 = "ABCD";
        //     string s2 = "ABDC";
        //     for(int i = 0; i < s1.Length; i++)
        //     {
        //         for(int j = 0; j < s2.Length; j++)
        //         if(s1[i].Length == s2[j].Length)
        //         {
        //             return max += i;
        //         }
        //     }
        // }   

        // public static bool arrayElement()
        // {
        //    string[] arrayElement = new[] {};
        // }
        // public static string numberGame()
        // {

        // }
    }
}
