using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatchWSB
{
    public class TimeCounter
    {
        public TimeSpan Elapsed { get; set; }
        public DateTime StartTime { get; set; }
        public bool isOn;
        public void Start()
        {
            if (isOn == true)
            {
                throw new InvalidOperationException("StopWatch is already on");
            }
            else
            {
                StartTime = DateTime.Now - Elapsed;
                isOn = true;
            }
        }

        public void Stop()
        {
            if(isOn == true)
            {
                isOn = false;
                Elapsed = DateTime.Now - StartTime;
                Console.WriteLine($"Time elapsed: {Elapsed}");
            }
            else
            {
                Console.WriteLine("You haven't started the StopWatch. ");
            }
        }
        public void Reset()
        {
            StartTime = DateTime.Now;
            Elapsed = TimeSpan.Zero;
        }
    }
}
