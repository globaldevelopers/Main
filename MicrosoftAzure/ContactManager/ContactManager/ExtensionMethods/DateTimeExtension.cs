using System;

namespace ContactManager.ExtensionMethods
{
    public static class DateTimeExtension
    {
        public static DateTime Tomorrow(this DateTime dateTime)
        {
            return dateTime.AddDays(1);
        }
    }
}