namespace Statistics {
    /// <summary>
    /// Represents statistical calculations including average, minimum, and maximum values.
    /// </summary>
    public class Stats {
        /// <summary>
        /// Gets or sets the average (mean) value of the data set
        /// </summary>
        public double average { get; set; }

        /// <summary>
        /// Gets or sets the maximum value in the data set
        /// </summary>
        public double max { get; set; }

        /// <summary>
        /// Gets or sets the minimum value in the data set
        /// </summary>
        public double min { get; set; }

        public Stats() {
            // Initialize with NaN values by default
            this.average = double.NaN;
            this.max = double.NaN;
            this.min = double.NaN;
        }
    }
}
