using System;


namespace StopWatchWSB
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeCounter stopWatch = new TimeCounter();

            while (true)
            {
                Console.WriteLine("Choose action: start,stop, reset");
                    string action = Console.ReadLine();

                switch (action)
                {
                    case "start":
                        stopWatch.Start();
                        break;
                    case "stop":
                        stopWatch.Stop();
                        break;
                    case "reset":
                        stopWatch.Reset();
                        break;
                    default:
                        break;

                }
            }
        }
    }
}
