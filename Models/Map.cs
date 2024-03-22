using System;

namespace PPCalculator.Models
{
    /// <summary>
    /// Represents an osu! beatmap.
    /// </summary>
    public class Map
    {
        /// <summary>
        /// Gets or sets the beatmap ID.
        /// </summary>
        public int BeatmapId { get; set; }

        /// <summary>
        /// Gets or sets the beatmap set ID.
        /// </summary>
        public int BeatmapSetId { get; set; }

        /// <summary>
        /// Gets or sets the artist of the song.
        /// </summary>
        public string? Artist { get; set; }

        /// <summary>
        /// Gets or sets the title of the song.
        /// </summary>
        public string? Title { get; set; }

        /// <summary>
        /// Gets or sets the difficulty name of the beatmap.
        /// </summary>
        public string? DifficultyName { get; set; }

        /// <summary>
        /// Gets or sets the creator of the beatmap.
        /// </summary>
        public string? Creator { get; set; }

        /// <summary>
        /// Gets or sets the BPM of the song.
        /// </summary>
        public double BPM { get; set; }

        /// <summary>
        /// Gets or sets the star rating of the beatmap.
        /// </summary>
        public double StarRating { get; set; }

        /// <summary>
        /// Gets or sets the maximum combo possible on the beatmap.
        /// </summary>
        public int MaxCombo { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Map"/> class.
        /// </summary>
        public Map()
        {
        }

        // Additional properties and methods can be added here as needed.
    }
}
