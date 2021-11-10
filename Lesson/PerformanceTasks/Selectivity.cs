using NUnit.Framework;

namespace Lesson.PerformanceTasks
{
    public static class Selectivity
    {
        /*
         * считает количество чисел от 1 до number, делящихся на 5 и 2 без остатка
         * возвращает количетсво чисел и число делений числа
         *
         * + к карме, если сможете избавиться от ref 
         */
        public static (int, int) CalculateEvenNumbers(int number)
        {
            var operationsCount = 0; // счетчик операций деления
            var divisibleCount = 0;

            for (var i = number; i > 0; i--)
            {
                if (IsDivider(i, 2, ref operationsCount) && IsDivider(i, 5, ref operationsCount))
                {
                    divisibleCount++;
                }
            }

            return (divisibleCount, operationsCount);
        }

        private static bool IsDivider(int number, int divider, ref int counter)
        {
            ++counter;
            return number % divider == 0;
        }
    }

    [TestFixture]
    public class SelectivityTests
    {
        [TestCase(100, 10, 120)]
        public void Test(int number, int expectedDivisibleCount, int expectedOperationsCount)
        {
            var (actualDivisibleCount, actualOperationsCount) = Selectivity.CalculateEvenNumbers(number);

            Assert.AreEqual(expectedDivisibleCount, actualDivisibleCount);
            Assert.AreEqual(expectedOperationsCount, actualOperationsCount);
        }
    }
}