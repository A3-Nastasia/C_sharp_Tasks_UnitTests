using System;
using Xunit;
using Solutions;

namespace SolutionsTests
{
    public class UnitTests
    {
        [Fact]
        public void isPlusOneCorrect1()
        {
            int[] digits = new int[] { 9, 2, 3, 9 };
            int[] result = SolutionsClass.PlusOne(digits);
            Assert.Equal(new int[] { 9, 2, 4, 0}, result);
        }

        [Fact]
        public void isPlusOneCorrect2()
        {
            int[] digits = new int[] { 9 };
            int[] result = SolutionsClass.PlusOne(digits);
            Assert.Equal(new int[] { 1, 0 }, result);
        }

        [Fact]
        public void LongestCommonPrefix1()
        {
            string[] strs1 = new string[] { "flower", "flow", "flight" };
            string result = SolutionsClass.LongestCommonPrefix(strs1);
            Assert.Equal("fl", result);
        }

        [Fact]
        public void LongestCommonPrefix2()
        {
            string[] strs2 = new string[] { "dog", "racecar", "car" };
            string result = SolutionsClass.LongestCommonPrefix(strs2);
            Assert.Equal("", result);
        }
        
        [Fact]
        public void SingleNumber1()
        {
            int result = SolutionsClass.SingleNumber(new int[] { 4, 2, 1, 2, 1 });
            Assert.Equal(4, result);
        }
        
        [Fact]
        public void SingleNumber2()
        {
            int result = SolutionsClass.SingleNumber(new int[] { 4, 2, 1, 2, 1, 4, -1 });
            Assert.Equal(-1, result);
        }

        [Fact]
        public void FindMaxConsecutiveOnes1()
        {
            int result = SolutionsClass.FindMaxConsecutiveOnes(new int[] { 1, 0, 1, 1, 0, 1 });
            Assert.Equal(2, result);
        }

        [Fact]
        public void FindMaxConsecutiveOnes2()
        {
            int result = SolutionsClass.FindMaxConsecutiveOnes(new int[] { 1, 1, 0, 1, 1, 1 });
            Assert.Equal(3, result);
        }

        [Fact]
        public void MissingNumberLongTime()
        {
            int result = SolutionsClass.MissingNumber1(new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 });
            Assert.Equal(8, result);
        }
        
        [Fact]
        public void MissingNumberShortTime()
        {
            int result = SolutionsClass.MissingNumber(new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 });
            Assert.Equal(8, result);
        }        

        [Fact]
        public void ContainsDuplicate()
        {
            bool result = SolutionsClass.ContainsDuplicate(new int[] { 1, 2, 3, 1 });
            Assert.True(result);
        }

        [Fact]
        public void SmallestEqual1()
        {
            int result = SolutionsClass.SmallestEqual(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 });
            Assert.Equal(-1 ,result);
        }

        [Fact]
        public void SmallestEqual2()
        {
            int result = SolutionsClass.SmallestEqual(new int[] { 4, 3, 2, 1 });
            Assert.Equal(2 ,result);
        }

        [Fact]
        public void SmallestEqual3()
        {
            int result = SolutionsClass.SmallestEqual(new int[] { 0, 1, 2 });
            Assert.Equal(0, result);
        }

        [Fact]
        public void FindNonMinOrMax1()
        {
            int result = SolutionsClass.FindNonMinOrMax(new int[] { 2, 4, 25 });
            Assert.Equal(4, result);
        }

        [Fact]
        public void FindNonMinOrMax2()
        {
            int result = SolutionsClass.FindNonMinOrMax(new int[] { 1, 2 });
            Assert.Equal(-1, result);
        }

        [Fact]
        public void Average()
        {
            double result = SolutionsClass.Average(new int[] { 4000, 3000, 1000, 2000 });
            Assert.Equal(2500, result);
        }

        [Fact]
        public void MostWordsFound1()
        {
            int result = SolutionsClass.MostWordsFound(new string[] { "alice and bob love leetcode", "i think so too", "this is great thanks very much" });
            Assert.Equal(6, result);
        }

        [Fact]
        public void MostWordsFound2()
        {
            int result = SolutionsClass.MostWordsFound(new string[] { "please wait", "continue to fight", "continue to win" });
            Assert.Equal(3, result);
        }

        [Fact]
        public void FinalValueAfterOperations1()
        {
            int result = SolutionsClass.FinalValueAfterOperations(new string[] { "X++", "++X", "--X", "X--" });
            Assert.Equal(0, result);
        }

        [Fact]
        public void FinalValueAfterOperations2()
        {
            int result = SolutionsClass.FinalValueAfterOperations(new string[] { "++X", "++X", "X++" });
            Assert.Equal(3, result);
        }

        [Fact]
        public void Interpret1()
        {
            string result = SolutionsClass.Interpret("G()(al)");
            Assert.Equal("Goal", result);
        }

        [Fact]
        public void Interpret2()
        {
            string result = SolutionsClass.Interpret("(al)G(al)()()G");
            Assert.Equal("alGalooG", result);
        }

        [Fact]
        public void DifferenceOfSums1()
        {
            int result = SolutionsClass.DifferenceOfSums(10,3);
            Assert.Equal(19, result);
        }

        [Fact]
        public void DifferenceOfSums2()
        {
            int result = SolutionsClass.DifferenceOfSums(5,1);
            Assert.Equal(-15, result);
        }
    }
}
