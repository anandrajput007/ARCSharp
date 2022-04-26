using System;

namespace TimeZoneConversation
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeZoneInfo indiazone, centralAmericazone, ukZone;
            DateTime dateTime, india, camerica, london;

            dateTime = DateTime.Now;
            DateTime utcDateTime = dateTime.ToUniversalTime();

            indiazone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
            centralAmericazone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
            ukZone = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");

            india = TimeZoneInfo.ConvertTime(dateTime, indiazone);
            camerica = TimeZoneInfo.ConvertTime(dateTime, centralAmericazone);
            london = TimeZoneInfo.ConvertTime(dateTime, ukZone);

            Console.WriteLine($"UTC Time\t\t :\t{utcDateTime.ToString()}");
            Console.WriteLine($"Local Time\t\t :\t{utcDateTime.ToLocalTime()}");
            Console.WriteLine($"Indian Standard Time\t :\t{india.ToString()}");
            Console.WriteLine($"Central America Time\t :\t{camerica.ToString()}");
            Console.WriteLine($"London Time\t\t :\t{london.ToString()}");
            Console.ReadLine();
        }
    }
}
