using System;
using ClockApplication.Business;
using ClockApplication.Event;
namespace ClockApplication
{
    class Program
    {
        static void Main(string[] args)
        {
           Clock clock = new Clock();
           DisplayClock view = new DisplayClock();
           view.Subcribe(clock);
           LogClockToFile log = new LogClockToFile();
           log.Subscribe(clock);
           clock.Run();
        }
    }
}
