using System;
using NUnit.Framework;

namespace Lesson.PerformanceTasks
{
    public static class Circles
    {
        /*
         * Петров Петр Петрович => П.П. Петров
         */
        public static int Calculate(int seed)
        {
            var random = new Random(seed);
            var count = random.Next((int) Math.Pow(seed, 2) + seed);
            var buffer = new int[count];
            var result = 0;

            for (var i = 0; i < count; i++)
            {
                buffer[i] = random.Next(seed);
            }

            for (var i = 0; i < count; i++)
            {
                buffer[i] += random.Next(seed);
            }

            for (var i = 0; i < count; i++)
            {
                result += buffer[i];
            }

            return result;
        }
    }

    [TestFixture]
    public sealed class CirclesTests
    {
        [TestCase(3324, 1253637047)]
        public void Test(int seed, int expected)
        {
            var actual = Circles.Calculate(seed);

            Assert.AreEqual(expected, actual);
        }
    }
}