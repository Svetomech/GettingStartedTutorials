using System;
using IntExtensions;

namespace greeter
{
    class Program
    {
        static void Main()
        {
            var now = DateTime.Now;
            var hour = now.TimeOfDay.Hours;

            var timeOfDay = new TimeOfDay();
            if (hour.In((int)TimeOfDay.Morning, (int)TimeOfDay.Afternoon - 1))
            {
                timeOfDay = TimeOfDay.Morning;
            }
            if (hour.In((int)TimeOfDay.Afternoon, (int)TimeOfDay.Evening - 1))
            {
                timeOfDay = TimeOfDay.Afternoon;
            }
            if (hour.In((int)TimeOfDay.Evening, (int)TimeOfDay.Night - 1))
            {
                timeOfDay = TimeOfDay.Evening;
            }
            if (hour.In((int)TimeOfDay.Night, (int)TimeOfDay.Midnight - 1) ||
                hour.In((int)TimeOfDay.None, (int)TimeOfDay.Morning - 1))
            {
                timeOfDay = TimeOfDay.Night;
            }

            Console.WriteLine($"Good {timeOfDay}");
        }
    }
}
