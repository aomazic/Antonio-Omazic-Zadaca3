using System;
using System.Collections.Generic;
using System.Text;

namespace class_library
{
    class Description
    {
        public int EpisodeNumber { get; set; }
        public TimeSpan Timespan { get; set; }
        public string EpisodeName { get; set; }

        public Description() {
        }

        public Description(int episodeNumber, TimeSpan timespan, string episodeName)
        {
            EpisodeNumber = episodeNumber;
            Timespan = timespan;
            EpisodeName = episodeName;
        }
    }
}
