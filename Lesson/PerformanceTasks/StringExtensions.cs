namespace Lesson.PerformanceTasks
{
    public static class StringExtensions
    {
        /*
         * Петров Петр Петрович => П.П. Петров
         */
        public static string ToDocumentFormat(this string fio)
        {
            var lastName = fio.Split()[0];
            var firstName = fio.Split()[1];
            var middleName = fio.Split()[2];

            return string.Format("{0}.{1}. {2}", firstName[0], middleName[0], lastName);
        }
    }
}