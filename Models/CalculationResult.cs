using System;

namespace PPCalculator.Models
{
    /// <summary>
    /// Represents the result of a performance point (pp) calculation.
    /// </summary>
    public class CalculationResult
    {
        /// <summary>
        /// Gets or sets the map for which the calculation was performed.
        /// </summary>
        public Map? Map { get; set; }

        /// <summary>
        /// Gets or sets the score used in the calculation.
        /// </summary>
        public Score? Score { get; set; }

        /// <summary>
        /// Gets or sets the total performance points calculated.
        /// </summary>
        public double TotalPerformancePoints { get; set; }

        /// <summary>
        /// Gets or sets the aim performance points.
        /// </summary>
        public double AimPerformancePoints { get; set; }

        /// <summary>
        /// Gets or sets the speed performance points.
        /// </summary>
        public double SpeedPerformancePoints { get; set; }

        /// <summary>
        /// Gets or sets the accuracy performance points.
        /// </summary>
        public double AccuracyPerformancePoints { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CalculationResult"/> class.
        /// </summary>
        public CalculationResult()
        {
        }

        // Additional properties and methods can be added here as needed.
    }
}
