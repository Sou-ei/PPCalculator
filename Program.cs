using System;
using System.Threading.Tasks;
using PPCalculator.Models;

namespace PPCalculator
{
    internal abstract class Program
    {
        private static async Task Main(string[] args)
        {
            Console.WriteLine("Enter your osu! API key:");
            string apiKey = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("Enter the beatmap ID or difficulty ID:");
            int beatmapId = int.Parse(Console.ReadLine() ?? string.Empty);

            Console.WriteLine("Enter the URL of the beatmap (optional, press Enter to skip):");
            var url = Console.ReadLine();

            var osuApiClient = new OsuApiClient(apiKey);
            Map map;

            if (!string.IsNullOrEmpty(url))
            {
                map = await osuApiClient.GetBeatmapByUrlAsync(url);
            }
            else
            {
                map = await osuApiClient.GetBeatmapAsync(beatmapId);
            }

            // ReSharper disable once ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
            if (map == null)
            {
                Console.WriteLine("Beatmap not found.");
                return;
            }

            Console.WriteLine("Enter score details:");
            Console.Write("Max Combo: ");
            var maxCombo = int.Parse(Console.ReadLine() ?? string.Empty);

            Console.Write("Count 300: ");
            var count300 = int.Parse(Console.ReadLine() ?? string.Empty);

            Console.Write("Count 100: ");
            var count100 = int.Parse(Console.ReadLine() ?? string.Empty);

            Console.Write("Count 50: ");
            var count50 = int.Parse(Console.ReadLine() ?? string.Empty);

            Console.Write("Count Miss: ");
            var countMiss = int.Parse(Console.ReadLine() ?? string.Empty);

            var score = new Score
            {
                MaxCombo = maxCombo,
                Count300 = count300,
                Count100 = count100,
                Count50 = count50,
                CountMiss = countMiss
            };
            
            var result = PpCalculator.Calculate(map, score);

            Console.WriteLine($"Total Performance Points: {result.TotalPerformancePoints}");
            Console.WriteLine($"Aim Performance Points: {result.AimPerformancePoints}");
            Console.WriteLine($"Speed Performance Points: {result.SpeedPerformancePoints}");
            Console.WriteLine($"Accuracy Performance Points: {result.AccuracyPerformancePoints}");
        }
    }
}
