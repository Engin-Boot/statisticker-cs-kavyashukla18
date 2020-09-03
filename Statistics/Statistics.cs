using System;
using System.Collections.Generic;
using System.Linq;
using static Statistics.Stats;

namespace Statistics
{
    public class StatsComputer
    {
        public Stats CalculateStatistics(List<double> numbers) {
            //Implement statistics here
            Stats statsCompute = new Stats();

            if (numbers.Count == 0)
            {
                statsCompute.average = Double.NaN;
                statsCompute.max = Double.NaN;
                statsCompute.min = Double.NaN;
            }
            else
            {
                statsCompute.average = numbers.Average();
                statsCompute.min = numbers.Min();
                statsCompute.max = numbers.Max();
            }
            return statsCompute;
        }
    }

}
