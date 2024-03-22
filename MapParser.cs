using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using PPCalculator.Models;
using PPCalculator.Utilities;

namespace PPCalculator
{
    /// <summary>
    /// Responsible for parsing beatmap data from osu! API responses into <see cref="Map"/> objects.
    /// </summary>
    public class MapParser(string apiKey)
    {
        private readonly string _apiKey = apiKey ?? throw new ArgumentNullException(nameof(apiKey));

        /// <summary>
        /// Asynchronously retrieves and parses a beatmap given its ID.
        /// </summary>
        /// <param name="beatmapId">The ID of the beatmap to retrieve.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the <see cref="Map"/> object.</returns>
        public async Task<Map> GetBeatmapAsync(int beatmapId)
        {
            string requestUrl = $"https://osu.ppy.sh/api/get_beatmaps?k={_apiKey}&b={beatmapId}";

            using var client = new HttpClient();
            var response = await HttpHelper.GetAsync(client, requestUrl);
            var beatmaps = JsonConvert.DeserializeObject<Map[]>(response);

            if (beatmaps == null || beatmaps.Length == 0)
            {
                throw new InvalidOperationException("No beatmap found with the specified ID.");
            }

            return beatmaps[0]; // Assuming the first beatmap is the one we're interested in.
        }

        /// <summary>
        /// Parses a beatmap from a JSON string.
        /// </summary>
        /// <param name="json">The JSON string containing the beatmap data.</param>
        /// <returns>The parsed <see cref="Map"/> object.</returns>
        public static Map ParseBeatmap(string json)
        {
            try
            {
                var map = JsonConvert.DeserializeObject<Map>(json);
                return map ?? throw new InvalidOperationException("Failed to parse the beatmap.");
            }
            catch (JsonException ex)
            {
                throw new InvalidOperationException("Error occurred while parsing the beatmap JSON.", ex);
            }
        }
    }
}
