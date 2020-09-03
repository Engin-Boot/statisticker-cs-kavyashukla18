using System;
using Xunit;
using Statistics;
using System.Collections.Generic;
using Xunit.Abstractions;

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
            Assert.True(Math.Abs(statsComputer.average - 4.525) <= epsilon);
            Assert.True(Math.Abs(statsComputer.max - 8.9) <= epsilon);
            Assert.True(Math.Abs(statsComputer.min - 1.5) <= epsilon);
        }
        public void ReportsNaNForEmptyInput()
        {
            var statsComputer = new StatsComputer();
            var computedStats = statsComputer.CalculateStatistics(
                new List<double> {});
            Assert.True(Double.IsNaN(statsComputer.average));
            Assert.True(Double.IsNaN(statsComputer.max));
            Assert.True(Double.IsNaN(statsComputer.min));
        }
    }

}
