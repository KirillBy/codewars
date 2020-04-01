using System;
using System.Collections.Generic;
using System.Text;

namespace Human_Readeable_Duration_Format
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(HumanTimeFormat.formatDuration(56));
        }
    }
    public enum DatesType
    {
        year, day, hour, minute, second
    }
    public class HumanTimeFormat
    {
        const int SEC_IN_YEAR = 31536000;
        const int SEC_IN_DAY = 86400;
        const int SEC_IN_HOUR = 3600;
        const int SEC_IN_MINUTE = 60;

        public static string formatDuration(int seconds)
        {
            if (seconds == 0)
                return "now";
            int year = seconds / SEC_IN_YEAR;
            int days = (seconds % SEC_IN_YEAR) / SEC_IN_DAY;
            int hour = (seconds % SEC_IN_DAY) / SEC_IN_HOUR;
            int minute = (seconds % SEC_IN_HOUR) / SEC_IN_MINUTE;
            int sec = seconds % SEC_IN_MINUTE;
            string yStr = ToStr(year, DatesType.year);
            string dStr = ToStr(days, DatesType.day);
            string hStr = ToStr(hour, DatesType.hour);
            string mStr = ToStr(minute, DatesType.minute);
            string sStr = ToStr(sec, DatesType.second);
            return StringParser(yStr, dStr, hStr, mStr, sStr);
        }
        private static string StringParser(string y, string d, string h, string m, string s)
        {
            List<string> dateString = new List<string>();
            if (!String.IsNullOrEmpty(y))
                dateString.Add(y);
            if (!String.IsNullOrEmpty(d))
                dateString.Add(d);
            if (!String.IsNullOrEmpty(h))
                dateString.Add(h);
            if (!String.IsNullOrEmpty(m))
                dateString.Add(m);
            if (!String.IsNullOrEmpty(s))
                dateString.Add(s);
            StringBuilder resultStr = new StringBuilder();
            for(var i = 0; i < dateString.Count; i++)
            {
                resultStr.Append(dateString[i]);
                if (dateString.Count > 1 && i == dateString.Count - 2)
                    resultStr.Append(" and ");
                else if (dateString.Count > 1 && i != dateString.Count - 1)
                    resultStr.Append(", ");
            }
            return resultStr.ToString();
        }
        private static string ToStr(int date, DatesType dateTime)
        {
            if (date == 0)
                return "";
            else if(date == 1)
            {
                switch (dateTime)   
                {
                    case (DatesType.year): return "1 year"; 
                    case (DatesType.day): return "1 day"; 
                    case (DatesType.hour): return "1 hour"; 
                    case (DatesType.minute): return "1 minute"; 
                    case (DatesType.second): return "1 second";
                    default:return "";
                }
            }
            else 
            {
                switch (dateTime)
                {
                    case (DatesType.year): return date.ToString() +" years";
                    case (DatesType.day): return date.ToString() + " days";
                    case (DatesType.hour): return date.ToString() + " hours";
                    case (DatesType.minute): return date.ToString() + " minutes";
                    case (DatesType.second): return date.ToString() + " seconds";
                    default: return "";
                }
            }
        }
    }
    
}
