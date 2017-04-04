using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenMenetrend.ScheduleLib
{
    [Serializable]
    public class Line
    {
        public string ID { get; set; }
        public List<Track> Tracks { get; private set; }
        public List<Start> Starts { get; private set; }

        public Line(string _id)
        {
            ID = _id;
            Tracks = new List<Track>();
            Starts = new List<Start>();
        }

        public override string ToString()
        {
            if(Tracks.Count > 0)
            {
                StringBuilder sb = new StringBuilder();
                return sb.Append(ID)
                            .Append(" | ")
                            .Append(getFirstStop().Station.Name)
                            .Append(" - ")
                            .Append(getLastStop().Station.Name).ToString();
            }
            else
            {
                return ID;
            }
        }

        private Stop getFirstStop()
        {
            Track longestTrack = Tracks.First();
            foreach(var track in Tracks)
            {
                if(track.Stops.Count > longestTrack.Stops.Count)
                {
                    longestTrack = track;
                }
            }

            return longestTrack.Stops.First();
        }

        private Stop getLastStop()
        {
            Track longestTrack = Tracks.First();
            foreach (var track in Tracks)
            {
                if (track.Stops.Count > longestTrack.Stops.Count)
                {
                    longestTrack = track;
                }
            }

            return longestTrack.Stops.Last();
        }

        public void SortStarts()
        {
            Starts.Sort((start1, start2) => start1.StartTime.CompareTo(start2.StartTime));
        }
    }
}
