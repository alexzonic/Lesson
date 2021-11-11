using NUnit.Framework;

namespace Lesson.RefactoringTasks
{
    public static class FloatComparison
    {
        public static bool Do(int in1, int in2)
        {
            var value1 = in1 / 3d;
            var value2 = in2 / 3d - 1;

            return value1 == value2;
        }
    }

    [TestFixture]
    public sealed class FloatComparisonTests
    {
        [TestCase(0, 3, true)]
        [TestCase(1, 4, true)]
        [TestCase(2, 5, true)]
        [TestCase(3, 6, true)]
        public void ReturnAndAddTest(int in1, int in2, bool expected)
        {
            var actual = FloatComparison.Do(in1, in2);

            Assert.AreEqual(expected, actual);
        }
    }
}