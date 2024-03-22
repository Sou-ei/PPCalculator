using System;

namespace PPCalculator.Models
{
    /// <summary>
    /// Represents a score in osu!.
    /// </summary>
    public class Score
    {
        /// <summary>
        /// Gets or sets the score ID.
        /// </summary>
        public long ScoreId { get; set; }

        /// <summary>
        /// Gets or sets the user ID of the player.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the username of the player.
        /// </summary>
        public string? Username { get; set; }

        /// <summary>
        /// Gets or sets the total score.
        /// </summary>
        public int TotalScore { get; set; }

        /// <summary>
        /// Gets or sets the max combo achieved in the play.
        /// </summary>
        public int MaxCombo { get; set; }

        /// <summary>
        /// Gets or sets the number of 300s hit.
        /// </summary>
        public int Count300 { get; set; }

        /// <summary>
        /// Gets or sets the number of 100s hit.
        /// </summary>
        public int Count100 { get; set; }

        /// <summary>
        /// Gets or sets the number of 50s hit.
        /// </summary>
        public int Count50 { get; set; }

        /// <summary>
        /// Gets or sets the number of misses.
        /// </summary>
        public int CountMiss { get; set; }

        /// <summary>
        /// Gets or sets the rank achieved in the play.
        /// </summary>
        public string? Rank { get; set; }

        /// <summary>
        /// Gets or sets the mods used.
        /// </summary>
        public string? Mods { get; set; }

        /// <summary>
        /// Gets or sets the accuracy of the play.
        /// </summary>
        public double Accuracy { get; set; }

        /// <summary>
        /// Gets or sets the performance points earned from the play.
        /// </summary>
        public double PerformancePoints { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Score"/> class.
        /// </summary>
        public Score()
        {
        }

        // Additional properties and methods can be added here as needed.
    }
}
