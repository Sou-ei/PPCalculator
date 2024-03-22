using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using PPCalculator.Models;

namespace PPCalculator
{
    /// <summary>
    /// Client for interacting with the osu! API.
    /// </summary>
    public class OsuApiClient
    {
        private readonly string _apiKey;
        private const string BaseUrl = "https://osu.ppy.sh/api/";

        /// <summary>
        /// Initializes a new instance of the <see cref="OsuApiClient"/> class.
        /// </summary>
        /// <param name="apiKey">Your osu! API key.</param>
        public OsuApiClient(string apiKey)
        {
            _apiKey = apiKey;
        }

        /// <summary>
        /// Asynchronously gets a beatmap by its ID.
        /// </summary>
        /// <param name="beatmapId">The beatmap ID.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the <see cref="Map"/>.</returns>
        public async Task<Map> GetBeatmapAsync(int beatmapId)
        {
            var url = $"{BaseUrl}get_beatmaps?k={_apiKey}&b={beatmapId}";

            using var client = new HttpClient();
            var response = await client.GetStringAsync(url);
            var maps = JsonConvert.DeserializeObject<Map[]>(response);

            if (maps != null && maps.Length > 0)
            {
                return maps[0];
            }

            return null!;
        }

        /// <summary>
        /// Asynchronously gets a beatmap by its difficulty ID.
        /// </summary>
        /// <param name="difficultyId">The difficulty ID.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the <see cref="Map"/>.</returns>
        public async Task<Map> GetBeatmapByDifficultyAsync(int difficultyId)
        {
            // Assuming difficultyId is equivalent to beatmapId in this context
            return await GetBeatmapAsync(difficultyId);
        }

        /// <summary>
        /// Asynchronously gets a beatmap by a URL.
        /// </summary>
        /// <param name="url">The URL of the beatmap.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the <see cref="Map"/>.</returns>
        public async Task<Map> GetBeatmapByUrlAsync(string url)
        {
            // Extract beatmapId from the URL
            var uri = new Uri(url);
            var query = HttpUtility.ParseQueryString(uri.Query);
            var beatmapId = int.Parse(query["b"] ?? string.Empty);

            return await GetBeatmapAsync(beatmapId);
        }
    }
}
