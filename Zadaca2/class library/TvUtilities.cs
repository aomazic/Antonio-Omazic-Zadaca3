using System;
using System.Collections.Generic;
using System.Text;

namespace class_library
{
	static class TvUtilities
	{
		public static double GenerateRandomScore()
		{
			double number, number2;
			Random rnd = new Random();
			number = rnd.NextDouble() * 10;
			number2 = Math.Round(number, 1);
			return number2;

		}
		public static void exchange(Episode[] episodes, int m, int n)
		{
			Episode temporary;
			temporary = episodes[m];
			episodes[m] = episodes[n];
			episodes[n] = temporary;
		}
	
		public static void Sort(Episode[] episodes){
			int i, j;
			int N = episodes.Length;

			for (j = N - 1; j > 0; j--)
			{
				for (i = 0; i < j; i++)
				{
					if (episodes[i] < episodes[i + 1])
						exchange(episodes, i, i + 1);
				}
			}

		}
		public static Episode Parse(string episodeintput)
        {
			string[] a = episodeintput.Split(",", 6);
			Description description = new Description(int.Parse(a[3], System.Globalization.CultureInfo.InvariantCulture), TimeSpan.Parse(a[4]),a[5]);
			return new Episode(int.Parse(a[0]), double.Parse(a[1], System.Globalization.CultureInfo.InvariantCulture),double.Parse(a[2], System.Globalization.CultureInfo.InvariantCulture),description);


		}
		

}
	}

