using NUnit.Framework;

namespace Summator.Tests
{
    public class Tests
    {
        [Test]

       public void Test_Sum_TwoPossitiveNumbers()
        {
            long actual = Summator.Sum (new long[] { 5, 7, });
            int expected = 12;
            
            Assert.That(actual == expected);
        }
        [Test]

        public void Test_Sum_OnePossitiveNumber()
        {
            long actual = Summator.Sum(new long[] { 5 });
            int expected = 5;
            Assert.That(actual == expected);
        }
        [Test]

        public void Test_Sum_NegativetiveNumber()
        {
            long actual = Summator.Sum(new long[] { -5, -9 });
            int expected = -14;
            Assert.That(actual == expected);
        }
        [Test]

        public void Test_Sum_EmptyArray()
        {long actual = Summator.Sum(new long[] { });
            int expected = 0;
            Assert.That(actual == expected);
        }
        [Test]

        public void Test_Sum_BigValues()
        {
            long actual = Summator.Sum(new long[] { 2000000000, 2000000000, 2000000000 });
            long expected = 6000000000;
            Assert.That(actual == expected);
        }

        [Test]

        public void Test_Average_TwoPossitiveNumbers()
        {
            int actual = Summator.Average(new int[] { 5, 7 });
            int expected = 6;

            Assert.That(actual == expected);
        }

        [Test]

        public void Test_Average_NegativetiveNumber()
        {
            int actual = Summator.Average(new int[] { -5, -10, -15 });
            int expected = -10;
            Assert.That(actual == expected);
        }

    }
}