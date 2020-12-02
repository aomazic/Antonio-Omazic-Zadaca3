using System;
using System.Collections.Generic;
using System.Text;


namespace class_library
{
    class Season
    {

        public int SeasonNumber { get; private set; }
        public Episode[] episodes {get; private set;}
   
        public Season(int seasonNumber, Episode[] episodes)
        {
            SeasonNumber = seasonNumber;
            this.episodes = episodes;
        }
        public int Length()
        {

            return episodes.Length;
        }
        public Episode this[int Index]
        { get { return episodes[Index]; } 
          set { episodes[Index] = value; } }
        private int Totalviewers()
        {
            int totalviewers = 0;
            for (int i = 0; i < episodes.Length; i++)
            {
                totalviewers += episodes[i].viewers;
            }
            return totalviewers;
        }
            private TimeSpan Totalduration()
            {
                TimeSpan totalduration = new TimeSpan();
                for (int i = 0; i < episodes.Length; i++)
                {
                    totalduration += episodes[i].descriptioN.Timespan;
                }
                return totalduration;
            }
        public override string ToString()
        {
            string[] message = new string[9];
            message[0]= $"Season {SeasonNumber}:";
            message[1] = "=================================================";
            message[2] = string.Join<Episode>(Environment.NewLine, episodes);
            message[3] = "Report:";
            message[4] = "=================================================";
            message[5] = $"Total viewers: {Totalviewers()}";
            message[6] = $"Total duration: {Totalduration()}";
            message[7] = "=================================================";
            message[8] = " ";
            return string.Join("\n", message) ;
        }

    }
}
