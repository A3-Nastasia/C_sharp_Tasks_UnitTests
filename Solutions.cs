using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class SolutionsClass
    {
        public static int[] PlusOne(int[] digits)
        {
            int n = digits.Length;
            for (int i = n - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }
                digits[i] = 0;
            }
            int[] appendDigits = new int[n + 1];
            appendDigits[0] = 1;
            return appendDigits;
        }

        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0) return "";

            string prefix = strs[0];

            for (int i = 1; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);

                    if (prefix == "") return "";
                }
            }
            return prefix;
        }

        public static int SingleNumber(int[] nums)
        {
            int single = 0;

            for (int i = 0; i < nums.Length; i++)
                single ^= nums[i];

            return single;
        }
        
        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            int max = 0;
            int temp = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    temp++;
                    if (temp > max)
                        max = temp;
                }
                else
                    temp = 0;
            }
            return max;
        }

        public static int MissingNumber1(int[] nums)
        {
            int min = 0;
            int max = nums.Length;

            int temp = 0;

            for (int i = 0; i < max - 1; i++)
                for (int j = 0; j < max - i - 1; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }

            for (int i = 0; i < max; i++)
            {
                if (nums[i] != min)
                    return min;
                else
                    min++;
            }
            return min;
        }


        public static int MissingNumber(int[] nums)
        {
            return getNaturalNumsSum(nums.Length) - nums.Sum();
        }

        public static bool ContainsDuplicate(int[] nums)
        {
            return !(nums.Distinct().ToArray().Length == nums.Length);
        }

        public static int SmallestEqual(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
                if (nums[i] == i % 10)
                    return i;
            return -1;
        }

        public static int FindNonMinOrMax(int[] nums)
        {
            if (nums.Length <= 2)
                return -1;

            int max = nums.Max();
            int min = nums.Min();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != max && nums[i] != min)
                    return nums[i];
            }
            return 0;
        }

        public static double Average(int[] salary)
        {
            int max = salary.Max();
            int min = salary.Min();
            return salary.Where(item => item != max && item != min).Average();
        }

        public static int MostWordsFound(string[] sentences)
        {
            int maxAmountOfSentences = 0;
            int singleSentence;
            for (int i = 0; i < sentences.Length; i++)
            {
                singleSentence = sentences[i].Split(" ").Length;
                if (maxAmountOfSentences < singleSentence)
                    maxAmountOfSentences = singleSentence;
            }
            return maxAmountOfSentences;
        }

        public static int FinalValueAfterOperations(string[] operations)
        {
            int X = 0;

            for (int i = 0; i < operations.Length; i++)
            {
                switch (operations[i])
                {
                    case "X++":
                        X++;
                        break;
                    case "++X":
                        ++X;
                        break;
                    case "X--":
                        X--;
                        break;
                    case "--X":
                        --X;
                        break;
                    default:
                        break;
                }
            }

            return X;
        }

        public static string Interpret(string command)
        {
            char[] symbolsArr = command.ToCharArray();
            string result = "";

            for (int i = 0; i < symbolsArr.Length; i++)
            {
                if (symbolsArr[i] == 'G')
                {
                    result += "G";
                }
                else if (symbolsArr[i] == '(' && symbolsArr[i + 1] == ')')
                {
                    result += "o";
                    i++;
                }
                else
                {
                    result += "al";
                    i += 3;
                }
            }
            return result;
        }

        public static int DifferenceOfSums(int n, int m)
        {
            int num1 = 0;
            int num2 = 0;

            while (n != 0)
            {
                if (n % m == 0)
                    num2 += n;
                else
                    num1 += n;
                n--;
            }
            return num1 - num2;
        }




        private static int getNaturalNumsSum(int n) => n * (n + 1) / 2;
    }
}
