using System;
using System.Collections.Generic;
using System.Linq;

namespace Statistics
{
    public class Stats
    {
        public double average {get; set;}
        public double max {get; set;}
        public double min {get; set;}
    }
    public class StatsComputer: Stats
    {
        public Stats CalculateStatistics(List<double> numbers) {
            //Implement statistics here
            Stats stats = new Stats();

            if (numbers.Count == 0)
            {
                stats.average = Double.NaN;
                stats.max = Double.NaN;
                stats.min = Double.NaN;
            }
            else
            {
                stats.average = numbers.Average();
                stats.min = numbers.Min();
                stats.Max = numbers.Max();
            }
            return stats;
        }
    }

}
