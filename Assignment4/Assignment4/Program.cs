using System;
using System.Globalization;
using System.Text;

namespace Assignment4
{
    class Program
    {
        [Obsolete]
        static void Main(string[] args)
        {
            //Modified string
            String string1 = "String1";
            String string2 = "String3";

            Console.WriteLine(string1 == string2);
            string2 = string2[0..^1] + 1;
            Console.WriteLine(string1.Equals(string2));
            Console.WriteLine(string1.CompareTo(string2));

            //StringBuilder
            StringBuilder stringBuilder = new StringBuilder("StringBuilder");

            stringBuilder.Append("123");
            Console.WriteLine(stringBuilder);
            var stringBuilder1 = new StringBuilder("String1");
            Console.WriteLine(stringBuilder1.Equals(string1));

            //Split/Join
            string longString = "This is a very long string";
            string[] stringArr = longString.Split();

            Array.ForEach(stringArr, Console.WriteLine);

            Console.WriteLine(String.Join(" ",stringArr));

            //TimeSpan
            var time1 = new TimeSpan(5, 43, 21);
            var time2 = new TimeSpan(3, 23, 21);
            Console.WriteLine(time1-time2);

            //DateTime
            var date1 = DateTime.Parse("21/03/2004").ToString("dd-MM-yyyy");
            Console.WriteLine(date1);

            //DateTimeOffset
            DateTimeOffset offset = new DateTimeOffset(DateTime.Today);

            Console.WriteLine(offset);
            Console.WriteLine(offset.UtcDateTime.Kind);

            //TimeZone
            TimeZone timeZone = TimeZone.CurrentTimeZone;

            Console.WriteLine(timeZone.IsDaylightSavingTime(new DateTime(2004,7,4,13,50,30)));

            //CultureInfo
            CultureInfo ro = CultureInfo.GetCultureInfo("ro-RO");
            Console.WriteLine(50.ToString("C", ro));
        }
    }
}
