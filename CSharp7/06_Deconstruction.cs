using System;

namespace CSharp7
{
    //
    // Expressive
    //
    // Deconstruction
    class Deconstruction
    {
        public void OldSchool()
        {
            var dt = DateTime.Now;
            var (hour, minute, second) = (dt.Hour, dt.Minute, dt.Second);
        }

        public void CSharp7Deconstruction()
        {
            var (hour, minute, second) = DateTime.Now;
        }
    }

    public static class DateTimeExtensions
    {
        public static void Deconstruct(this DateTime dt, out int hour, out int minute, out int second)
        {
            hour = dt.Hour;
            minute = dt.Minute;
            second = dt.Second;
        }
    }
}
