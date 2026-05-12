using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Leaño_Linchangco_FinalProject
{
    internal static class ScoreManager
    {
        private static string filePath = "leaderboard.xml";

        public static List<PlayerScore> LoadScores()
        {
            if (!File.Exists(filePath))
                return new List<PlayerScore>();

            XDocument doc = XDocument.Load(filePath);

            return doc.Root.Elements("Player")
                .Select(x => new PlayerScore
                {
                    Name = x.Element("Name").Value,
                    Score = int.Parse(x.Element("Score").Value)
                })
                .ToList();
        }

        public static void SaveScore(string name, int score)
        {
            var scores = LoadScores();

            var existing = scores.FirstOrDefault(s => s.Name == name);

            if (existing != null)
            {
                if (score > existing.Score)
                    existing.Score = score;
            }
            else
            {
                scores.Add(new PlayerScore { Name = name, Score = score });
            }

            var topScores = scores
                .OrderByDescending(s => s.Score)
                .Take(10)
                .ToList();

            XDocument doc = new XDocument(
                new XElement("Leaderboard",
                    topScores.Select(s =>
                        new XElement("Player",
                            new XElement("Name", s.Name),
                            new XElement("Score", s.Score)
                        )
                    )
                )
            );

            doc.Save(filePath);
        }

        public static List<PlayerScore> GetTopScores()
        {
            return LoadScores()
                .OrderByDescending(s => s.Score)
                .Take(10)
                .ToList();
        }
    }
}