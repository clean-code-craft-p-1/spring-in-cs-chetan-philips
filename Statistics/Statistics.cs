namespace Statistics {
    /// <summary>
    /// Provides functionality to compute statistical values from a collection of numbers.
    /// </summary>
    public class StatsComputer {
        /// <summary>
        /// Calculates statistical values (average, minimum, maximum) from a list of numbers.
        /// </summary>
        /// <param name="numbers">The list of float numbers to analyze</param>
        /// <returns>A Stats object containing average, min, and max values. Returns NaN for all values if the list is empty.</returns>
        public Stats CalculateStatistics(List<float> numbers) {
            Stats stats = new Stats();

            if (numbers != null && numbers.Count > 0) {
                stats.average = numbers.Average(x => (double)x);
                stats.max = numbers.Max(x => (double)x);
                stats.min = numbers.Min(x => (double)x);
            }
            // If the list is empty or null, the Stats constructor already initialized with NaN values

            return stats;
        }
    }
}
