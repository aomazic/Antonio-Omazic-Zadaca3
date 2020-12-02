using System;
using System.IO.Compression;
using System.IO;
using System.Collections.Generic;

namespace class_library
{
	class Program
	{
		static void Main(string[] args)
		{
			string fileName = "shows.txt";
			string outputFileName = "storage.txt";
			IPrinter printer = new ConsolePrinter();
			printer.Print($"Reading data from file {fileName}");
			Episode[] episodes = TvUtilities.LoadEpisodesFromFile(fileName);
			Season season = new Season(1, episodes);
			printer.Print(season.ToString());
			for (int i = 0; i < episodes.Length; i++)
			{
				season[i].AddView(TvUtilities.GenerateRandomScore());
			}
			printer.Print(season.ToString());
			printer = new FilePrinter(outputFileName);
			printer.Print(season.ToString());
		}
	}
}