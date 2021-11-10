using System;
using System.Collections.Generic;

namespace Lesson.RefactoringTasks
{
    public static class SecurityOperations
    {
        private const string NotFound = "NOT_FOUND";

        public static int GetNumber(Guid guid)
        {
            var stringValue = GetStringByGuid(guid);

            if (stringValue == NotFound)
                return -1;

            var number = int.Parse(stringValue);
            return number;
        }

        private static string GetStringByGuid(Guid guid)
        {
            var dic = new Dictionary<Guid, string>();
            FillDictionary(dic);

            var result = dic[guid];
            if (result == null)
            {
                return NotFound;
            }
            else
            {
                return result;
            }
        }

        /* типа получаем данные окда */
        private static void FillDictionary(Dictionary<Guid, string> dic)
        {
            dic.Add(Guid.NewGuid(), "1");
            dic.Add(Guid.NewGuid(), "2");
            dic.Add(Guid.NewGuid(), "a");
            dic.Add(Guid.NewGuid(), "b");
            dic.Add(Guid.NewGuid(), "5");
            dic.Add(Guid.NewGuid(), "");
            dic.Add(Guid.NewGuid(), "6");
        }
    }
}