using System;
using System.Collections.Generic;
using System.Linq;

namespace Statistics
{
    public class Stats
    {
        public double average;
        public double max;
        public double min;
    }
    public class StatsComputer
    {
        public Stats CalculateStatistics(List<double> numbers) {
            //Implement statistics here
            Stats stats = new Stats();

            if (numbers.Count == 0)
            {
                stats.average = stats.max = stats.min = Double.NaN;
            }
            else
            {
                stats.max = numbers[0];
                stats.min = numbers[0];
                foreach (var num in numbers)
                {
                    stats.average += num;
                    if (num > stats.max)
                    {
                        stats.max = num;
                    }
                    if (num < stats.min)
                    {
                        stats.min = num;
                    }
                }

                stats.average /= numbers.Count;
            }
            return stats;
        }
    }

}
