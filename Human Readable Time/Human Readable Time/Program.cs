using System;

namespace Human_Readable_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TimeFormat.GetReadableTime(61)); 
        }
    }
    public static class TimeFormat
    {
        public static string GetReadableTime(int seconds)
        {
            int hour = seconds / 3600;
            int minute = (seconds % 3600) / 60;
            int sec = seconds - hour * 3600 - minute * 60;
            return TimeToStr(hour)+":"+TimeToStr(minute) + ":" + TimeToStr(sec);
        }
        private static string TimeToStr(int time)
        {
            if (time < 10)
                return "0" + time.ToString();
            else
                return time.ToString();
        }
    }
}
