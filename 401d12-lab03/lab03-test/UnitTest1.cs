using System;
using Xunit;
using lab03;

namespace lab03_test
{
    public class UnitTest1
    {
        [Fact]
        public void testChallenge1()
        {
            string[] test1 = new string[] { "2", "3", "4" };
            string[] test2 = new string[] { "2", "3", "4", "5", "6", "7" };
            string[] test3 = new string[] { "2", "3" };
            string[] test4 = new string[] { "2", "3", "-4" };

            Assert.Equal(24, Program.labChallenge1(test1));
            Assert.Equal(24, Program.labChallenge1(test2));
            Assert.Equal(0, Program.labChallenge1(test3));
            Assert.Equal(-24, Program.labChallenge1(test4));
        }

        [Fact]
        public void testChallenge2()
        {
            decimal[] test1 = new decimal[] { 2, 3, 4 };
            decimal[] test2 = new decimal[] { 4, 5, 6 };
            decimal[] test3 = new decimal[] { 10, 10, 10 };
            decimal[] test4 = new decimal[] { 0, 0, 0 };

            Assert.Equal(3, Program.labChallenge2(test1));
            Assert.Equal(5, Program.labChallenge2(test2));
            Assert.Equal(10, Program.labChallenge2(test3));
            Assert.Equal(0, Program.labChallenge2(test4));
        }

        [Fact]
        public void testChallenge4()
        {
            int[] test1 = new int[] { 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 2 };
            int[] test2 = new int[] { 1, 2, 4, 4, 2, 3, 4 };
            int[] test3 = new int[] { 4, 3, 2, 3, 4, 11, 2, 3, 2, 11, 11 };
            int[] test4 = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            int[] test5 = new int[] { 10, 2, 3, 4, 5, 1 };

            Assert.Equal(2, Program.labChallenge4(test1));
            Assert.Equal(4, Program.labChallenge4(test2));
            Assert.Equal(3, Program.labChallenge4(test3));
            Assert.Equal(1, Program.labChallenge4(test4));
            Assert.Equal(10, Program.labChallenge4(test5));
        }

        [Fact]
        public void testChallenge5()
        {
            int[] test1 = new int[] { -6, -11, -3, -5, -7, -4 };
            int[] test2 = new int[] { 6, 6, 6, 6, 6, 6 };

            Assert.Equal(-3, Program.labChallenge5(test1));
            Assert.Equal(6, Program.labChallenge5(test2));
        }

        [Fact]
        public void testChallenge9()
        {
            string[] test1 = new string[] { "This", "is", "a", "sentence", "about", "important", "things" };
            string[] test2 = new string[] { "H3llo", "Wor|d" };

            string[] expected1 = new string[] { "This: 4", "is: 2", "a: 1", "sentence: 8", "about: 5", "important: 9", "things: 6" };
            string[] expected2 = new string[] { "H3llo: 5", "Wor|d: 5" };

            Assert.True(typeof(string[]) == Program.labChallenge9(test1).GetType());
            Assert.Matches(expected1[0], Program.labChallenge9(test1)[0]);
            Assert.Matches(expected1[1], Program.labChallenge9(test1)[1]);
            Assert.Matches(expected1[2], Program.labChallenge9(test1)[2]);
            Assert.Matches(expected1[3], Program.labChallenge9(test1)[3]);
            Assert.Matches(expected1[4], Program.labChallenge9(test1)[4]);
            Assert.Matches(expected1[5], Program.labChallenge9(test1)[5]);
            Assert.Matches(expected1[6], Program.labChallenge9(test1)[6]);
            Assert.Matches(expected2[0], Program.labChallenge9(test2)[0]);
            Assert.Matches(expected2[1], Program.labChallenge9(test2)[1]);
        }
    }
}
