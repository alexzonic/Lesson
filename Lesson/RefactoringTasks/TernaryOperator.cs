using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Lesson.RefactoringTasks
{
    public static class TernaryOperator
    {
        public static void SimpleExample()
        {
            var count = 0;

            /*
             * ...
             * тут много полезного кода
             * ...
             */

            if (new Random().Next(0, 1) == 0)
                count += 1;
            else
                count += 0;

            var list = new List<int> {count}; // пустышка, чтобы райдер не жаловался что count бесполезный // теперь жалуется, что list бесполезный

            /*
             * ...
             */
        }

        public static string ReturnNullOrEmpty(bool condition)
        {
            string result;

            if (condition)
            {
                result = null;   
                return result;
            }
            else
            {
                result = string.Empty;
                return result;
            }
        }

        public static int Add2Or1AndReturn(int value, bool condition)
        {
            if (condition)
                value += 2;
            else
                value += 1;

            return value;
        }
    }

    [TestFixture]
    public sealed class TernaryOperatorTests
    {
        [TestCase(true, null)]
        [TestCase(false, "")]
        public void ReturnTest(bool condition, string expected)
        {
            var actual = TernaryOperator.ReturnNullOrEmpty(condition);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, true, 2)]
        [TestCase(0, false, 1)]
        public void ReturnAndAddTest(int value, bool condition, int expected)
        {
            var actual = TernaryOperator.Add2Or1AndReturn(value, condition);

            Assert.AreEqual(expected, actual);
        }
    }
}