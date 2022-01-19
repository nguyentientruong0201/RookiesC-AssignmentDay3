using System;
using ClockApplication.Event;

namespace ClockApplication.Business
{
    public class DisplayClock
    {
        public void Subcribe(Clock clock) {
            clock.Secondchange += new Clock.SeconChangeHandler(TimeHasChange);

        }
        private void TimeHasChange (object clock, TimeInfoEventArg args){
            Console.WriteLine("{0}:{1}:{2}", args.hour, args.minute, args.second);
        }
    }
}