using System;
using Xunit;
using Statistics;
using System.Collections.Generic;
using Xunit.Abstractions;
using static Statistics.Stats;

namespace Statistics.Test
{
    public class StatsUnitTest
    {
        [Fact]
        public void ReportsAverageMinMax()
        {
            var statsComputer = new StatsComputer();
            var computedStats = statsComputer.CalculateStatistics(
                new List<double> { 1.5, 8.9, 3.2, 4.5 });
            float epsilon = 0.001F;
            Assert.True(Math.Abs(computedStats.average - 4.525) <= epsilon);
            Assert.True(Math.Abs(computedStats.max - 8.9) <= epsilon);
            Assert.True(Math.Abs(computedStats.min - 1.5) <= epsilon);
        }
        public void ReportsNaNForEmptyInput()
        {
            var statsComputer = new StatsComputer();
            var computedStats = statsComputer.CalculateStatistics(
                new List<double> {});
            Assert.True(Double.IsNaN(computedStats.average));
            Assert.True(Double.IsNaN(computedStats.max));
            Assert.True(Double.IsNaN(computedStats.min));
        }
    }

}
