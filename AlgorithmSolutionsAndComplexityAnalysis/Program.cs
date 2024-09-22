using System.ComponentModel;
using System.Reflection;
using System.Security.Cryptography;

namespace AlgorithmSolutionsAndComplexityAnalysis
{
    internal class Program
    {
        static void Main(string[] args)
        {List<string> list = new List<string>();




            //            Find the Missing Number in an Array
            //Problem: Given an array containing `n` distinct numbers taken from the range `0` to `n`, write an algorithm to find the missing number.
            //Example Input: `[3, 0, 1]`
            //Example Output: `2`


            ////the worst way to solve

            Console.WriteLine("enter the n of numbers to random: ");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++) { numbers[i] = 3 * i + 5; }
            int maxNumber = int.MinValue;
            for (int i = 0; i < numbers.Length; i++)
            { if (numbers[i] > maxNumber) maxNumber = numbers[i]; }
            int[] totalNumber= new int[maxNumber];
            for (int i = 0; i <= totalNumber.Length; i++)
            {
                totalNumber[i] = i;
            }
            List<int> missNumber = new List< int > ();
            bool isThere;
            for (int i = 0; i <= totalNumber.Length; i++) 
            {
                isThere = false;
                for (int j = 0;j<numbers.Length; j++)
                { if (totalNumber[i] == numbers[j])
                    { isThere = true; } }
                if (isThere != false) { missNumber.Add(totalNumber[i]); }
            }

            for (int i = 0;i < missNumber.Count; i++)
            {
                Console.WriteLine(missNumber[i]);
            }
        }
    }
}
