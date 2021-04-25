using System;

namespace Intermediate
{
    class Program
    {
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
