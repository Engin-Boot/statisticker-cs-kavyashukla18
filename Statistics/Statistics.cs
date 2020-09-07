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
                return statsCompute;
            }
            for(int iterateNumList = 0; iterateNumList < numbers.Count; iterateNumList++)
            {
                if (numbers[iterateNumList] == Double.NaN)
                        numbers.RemoveAt(iterateNumList);
            }
            statsCompute.average = numbers.Average();
            statsCompute.min = numbers.Min();
            statsCompute.max = numbers.Max();
            return statsCompute;
        }
    }

}
