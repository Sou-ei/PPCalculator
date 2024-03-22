namespace PPCalculator.Utilities
{
    public static class HttpHelper
    {
        private static readonly HttpClient Client = new HttpClient();

        /// <summary>
        /// Sends a GET request to the specified URL and returns the response as a string.
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="url">The URL to send the GET request to.</param>
        /// <returns>The response from the server as a string.</returns>
        public static async Task<string> GetAsync(HttpClient httpClient, string url)
        {
            try
            {
                var response = await Client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                return responseBody;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"\nException Caught!");
                Console.WriteLine($"Message :{e.Message}");
                return null!;
            }
        }
    }
}
