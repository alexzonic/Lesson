using NUnit.Framework;

namespace Lesson.RefactoringTasks
{
    public static class VoidRef
    {
        public static int Do(int seed)
        {
            var value = seed * seed;
            MakerSomeImportantOperations(ref value);
            return value;
        }

        private static void MakerSomeImportantOperations(ref int value)
        {
            value += 1;
            value -= 2;
            value *= 3;
            value /= 4;
            value %= 5;
        }
    }

    [TestFixture]
    public sealed class VoidRefTests
    {
        [TestCase(0, 0)]
        [TestCase(1, 0)]
        [TestCase(2, 2)]
        [TestCase(3, 1)]
        [TestCase(4, 1)]
        [TestCase(5, 3)]
        public void ReturnTest(int seed, int expected)
        {
            var actual = VoidRef.Do(seed);

            Assert.AreEqual(expected, actual);
        }
    }
}