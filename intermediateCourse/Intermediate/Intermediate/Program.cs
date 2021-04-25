using System;

namespace Intermediate
{
    class StopWatch
    {
        private DateTime startTime;
        private DateTime endTime;
        private TimeSpan duration;
        private string startOrStop = "start";
        private bool running = false;
        private TimeSpan total;

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


        public static void Main(string[] args)
        {
            var stopwatch = new StopWatch();

            while (true)
            {
                Console.WriteLine("Type '{0}' or 'quit to quit: ", stopwatch.startOrStop);
                var input = Console.ReadLine();

                if (input.ToLower() == "start" && stopwatch.running == false)
                {
                    stopwatch.Start();
                    continue;
                }
                else if (input.ToLower() == "stop" && stopwatch.running == true)
                {
                    stopwatch.Stop();
                    Console.WriteLine(stopwatch.total);
                    continue;
                }
                else if (input.ToLower() == "quit")
                    break;
            }
        }
    }
}
