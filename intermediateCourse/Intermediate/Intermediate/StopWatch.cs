using System;
namespace Intermediate
{
    public class StopWatch
    {

        private DateTime startTime;
        private DateTime endTime;
        private TimeSpan duration;
        public string startOrStop = "start";
        public bool running = false;
        public TimeSpan total;

        public void Start()
        {
            this.startTime = DateTime.Now;
            this.startOrStop = "stop";
            this.running = true;
            Console.WriteLine(this.startTime);
        }

        public void Stop()
        {
            this.endTime = DateTime.Now;
            this.startOrStop = "start";
            this.running = false;
            this.duration = this.endTime - this.startTime;
            this.total += this.duration;
        }

        public void RunStopwatch()
        {
           
        }
    }
}
