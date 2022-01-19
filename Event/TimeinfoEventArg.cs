namespace ClockApplication.Event
{
    public class TimeInfoEventArg
    {
        public readonly int hour;
        public readonly int minute;
        public readonly int second;


        public TimeInfoEventArg(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;

        }
    }
}