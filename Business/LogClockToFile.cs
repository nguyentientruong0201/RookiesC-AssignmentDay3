//using System.ID;
using System;
using System.IO;
using ClockApplication.Event;
namespace ClockApplication.Business
{
    public class LogClockToFile
    {
        public void Subscribe(Clock clock)
        {
            clock.Secondchange += new Clock.SeconChangeHandler(WriteToFile);
        }

        public void WriteToFile(object clock, TimeInfoEventArg timeinfo){
            string outputString = "Time " + timeinfo.hour + ":" + timeinfo.minute + ":" + timeinfo.second;
            using (FileStream stream = File.Open("D://Log1.txt", FileMode.OpenOrCreate )) {
               byte[] bytes = new System.Text.UTF8Encoding(true).GetBytes(outputString);
               stream.Write(bytes,0,bytes.Length);
            }

            using (StreamWriter writer = new StreamWriter("D://LogStream.txt", true ))
            {
                writer.WriteLine(outputString);
            }
        }
    }
}
