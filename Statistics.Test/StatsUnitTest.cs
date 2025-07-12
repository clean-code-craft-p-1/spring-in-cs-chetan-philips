using System;
using System.Collections.Generic;
using Xunit;

namespace Statistics.Test {
    public class StatsUnitTest {
        [Fact]
        public void ReportsAverageMinMax() {
            var statsComputer = new StatsComputer();
            var computedStats = statsComputer.CalculateStatistics(
                new List<float> { 1.5f, 8.9f, 3.2f, 4.5f });
            float epsilon = 0.001F;
            Assert.True(Math.Abs(computedStats.average - 4.525f) <= epsilon);
            Assert.True(Math.Abs(computedStats.max - 8.9f) <= epsilon);
            Assert.True(Math.Abs(computedStats.min - 1.5f) <= epsilon);
        }
        [Fact]
        public void ReportsNaNForEmptyInput() {
            var statsComputer = new StatsComputer();
            var computedStats = statsComputer.CalculateStatistics(
                new List<float> { });
            // All fields of computedStats (average, max, min) must be
            // Double.NaN (not-a-number), as described in
            // https://docs.microsoft.com/en-us/dotnet/api/system.double.nan?view=netcore-3.1
            Assert.True(double.IsNaN(computedStats.average));
            Assert.True(double.IsNaN(computedStats.max));
            Assert.True(double.IsNaN(computedStats.min));
        }
    }
}
