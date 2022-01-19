using System;
using System.Threading;

namespace ClockApplication.Event
{
    public class Clock
    {
        private int _hour;
        private int _minute;
        private int _second;
        public delegate void SeconChangeHandler(object clock, TimeInfoEventArg args);
        public event SeconChangeHandler Secondchange;
        protected void OnSecondChange(object clock, TimeInfoEventArg args)
        {
            if (Secondchange != null)
            {
                Secondchange(clock, args);
            }
        }
        public void Run()
        {
            for (; ; )
            {
                Thread.Sleep(1000);
                DateTime dateTimeNow = DateTime.Now;
                if (dateTimeNow.Second != _second)
                {
                    TimeInfoEventArg timeinfoEventArg = new TimeInfoEventArg( dateTimeNow.Hour, dateTimeNow.Minute, dateTimeNow.Second);
                    OnSecondChange(this, timeinfoEventArg);
                }

                this._hour = dateTimeNow.Hour;
                this._minute = dateTimeNow.Minute;
                this._second = dateTimeNow.Second;
            }
            
        }
    }
}