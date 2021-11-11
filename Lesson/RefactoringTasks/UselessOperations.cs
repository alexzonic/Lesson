using System.Collections.Generic;
using NUnit.Framework;

namespace Lesson.RefactoringTasks
{
    public class UselessOperations
    {
        private const int SomeMagicNumber = 1;
        private const int SomeAnotherNumber = 10;

        public static List<int> SimpleExample(int seed)
        {
            var result = new List<int>();
            for (var i = 0; i < seed; i++)
            {
                if (seed > SomeAnotherNumber)
                {
                    result.Add(i);
                }
            }

            if (seed == SomeMagicNumber)
                return new List<int>();

            return result;
        }
    }

    [TestFixture]
    public sealed class UselessOperationsTests
    {
        [TestCase(0, 0)]
        [TestCase(1, 0)]
        [TestCase(5, 0)]
        [TestCase(10, 0)]
        [TestCase(100, 100)]
        public void ReturnTest(int seed, int expected)
        {
            var actual = UselessOperations.SimpleExample(seed);

            Assert.AreEqual(expected, actual.Count);
        }
    }
}