using System;
using PPCalculator.Models;

namespace PPCalculator
{
    /// <summary>
    /// Responsible for calculating performance points (pp) for a given map and score.
    /// </summary>
    public class PpCalculator
    {
        /// <summary>
        /// Calculates the performance points for a given map and score.
        /// </summary>
        /// <param name="map">The map for which to calculate performance points.</param>
        /// <param name="score">The score for which to calculate performance points.</param>
        /// <returns>A <see cref="CalculationResult"/> containing the calculated performance points.</returns>
        public static CalculationResult Calculate(Map map, Score score)
        {
            if (map == null)
            {
                throw new ArgumentNullException(nameof(map), "Map cannot be null.");
            }

            if (score == null)
            {
                throw new ArgumentNullException(nameof(score), "Score cannot be null.");
            }

            // This is a simplified example. Actual pp calculation would require complex algorithms
            // involving the map's difficulty attributes and the score's hit statistics.
            var result = new CalculationResult
            {
                Map = map,
                Score = score,
                TotalPerformancePoints = CalculateTotalPerformancePoints(map, score),
                AimPerformancePoints = CalculateAimPerformancePoints(map, score),
                SpeedPerformancePoints = CalculateSpeedPerformancePoints(map, score),
                AccuracyPerformancePoints = CalculateAccuracyPerformancePoints(map, score)
            };

            return result;
        }

        private static double CalculateTotalPerformancePoints(Map map, Score score)
        {
            // Simplified example calculation
            return (map.StarRating * 100) + (score.MaxCombo * 0.5) - (score.CountMiss * 50) + (score.Count300 * 0.5);
        }

        private static double CalculateAimPerformancePoints(Map map, Score score)
        {
            // Simplified example calculation
            return (map.StarRating * 50) + (score.MaxCombo * 0.3);
        }

        private static double CalculateSpeedPerformancePoints(Map map, Score score)
        {
            // Simplified example calculation
            return (map.BPM * 0.2) + (score.MaxCombo * 0.2);
        }

        private static double CalculateAccuracyPerformancePoints(Map map, Score score)
        {
            // Simplified example calculation
            return (score.Count300 * 0.75) + (score.Count100 * 0.5) + (score.Count50 * 0.25) - (score.CountMiss * 25);
        }
    }
}
