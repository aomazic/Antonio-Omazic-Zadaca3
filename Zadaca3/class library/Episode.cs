using System;
using System.Collections.Generic;
using System.Text;

namespace class_library
{
    class Episode
    {
        public int viewers { get; private set; }
        public double ratingsum { get; private set; }
        public double maxrating { get; private  set; }
        public Description descriptioN { get; private set; }
        public double averagerating { get; private set; }

    public Episode()
        {
            viewers = 0;
            ratingsum = 0;
            maxrating = 0;
            averagerating = 0;
            
        }

        public Episode(int viewers, double ratingsum, double averagerating, Description descriptioN)
        {
            this.viewers = viewers;
            this.ratingsum = ratingsum;
            this.averagerating = averagerating;
            this.descriptioN = descriptioN;
        }

        public void AddView(double score)
        {
            viewers++;
            ratingsum += score;
            if (score > maxrating) maxrating = score;

        }
        public static bool operator >(Episode ep1, Episode ep2)
        {
            return (ep1.averagerating > ep2.averagerating);
        }
        public static bool operator <(Episode ep1, Episode ep2)
        {
            return (ep1.averagerating < ep2.averagerating);
        }
        public override string ToString()
        {
            return $"{viewers}, {ratingsum}, {averagerating}, {descriptioN.EpisodeNumber}, {descriptioN.Timespan}, {descriptioN.EpisodeName}";
        }


    }
}