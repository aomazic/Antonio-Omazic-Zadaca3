using System;
using System.IO.Compression;
using System.IO;

namespace class_library
{
	class Program
	{
		static void Main(string[] args)
		{
			Description description = new Description(1, TimeSpan.FromMinutes(45), "Pilot");
			Console.WriteLine(description);
			Episode episode = new Episode(10, 88.64, 9.78, description);
			Console.WriteLine(episode);
			string fileName = "shows.txt";
			string[] episodesInputs = File.ReadAllLines(fileName);
			Episode[] episodes = new Episode[episodesInputs.Length];
			for (int i = 0; i < episodes.Length; i++)
			{
				episodes[i] = TvUtilities.Parse(episodesInputs[i]);
			}
			Console.WriteLine("Episodes:");
			Console.WriteLine(string.Join<Episode>(Environment.NewLine, episodes));
			TvUtilities.Sort(episodes);
			Console.WriteLine("Sorted episodes:");
			string sortedEpisodesOutput = string.Join<Episode>(Environment.NewLine, episodes);
			Console.WriteLine(sortedEpisodesOutput);
			File.WriteAllText("sorted.tv", sortedEpisodesOutput);
		}
	}
}