using System.ComponentModel;
using System.Reflection;
using System.Security.Cryptography;

namespace AlgorithmSolutionsAndComplexityAnalysis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Find the Missing Number in an Array
            //Problem: Given an array containing `n` distinct numbers taken from the range `0` to `n`, write an algorithm to find the missing number.
            //Example Input: `[3, 0, 1]`
            //Example Output: `2`


            ////the worst way to solve

            Console.WriteLine("enter the n of numbers to random: ");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++) { numbers[i] = 3 * i + 5; }//time complexity O(n) and  O(n) space.
            int maxNumber = int.MinValue;//O(1)
            for (int i = 0; i < numbers.Length; i++)
            { if (numbers[i] > maxNumber) maxNumber = numbers[i]; }//O(n) in numbers[]
            //O(maxNumber)
            int[] totalNumber= new int[maxNumber];
            for (int i = 0; i <= totalNumber.Length; i++)
            {
                totalNumber[i] = i;//totalNumber array has size O(maxNumber)
            }
            List<int> missNumber = new List< int > ();
            bool isThere;
            for (int i = 0; i <= totalNumber.Length; i++) //O(maxNumber)
            {
                isThere = false;
                for (int j = 0;j<numbers.Length; j++)//O(maxNumber * n)
                { if (totalNumber[i] == numbers[j])
                    { isThere = true; } }
                if (isThere != false) { missNumber.Add(totalNumber[i]); }
            }

            for (int i = 0;i < missNumber.Count; i++)//O(maxNumber)
            {
                Console.WriteLine(missNumber[i]);
            }
        }
    }
}
