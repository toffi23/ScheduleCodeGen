using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenMenetrend.ScheduleLib
{
    [Serializable]
    public class Track
    {
        public int TrackNum { get; set; }
        public List<Stop> Stops { get; private set; }

        public Track(int pNum)
        {
            TrackNum = pNum;
            Stops = new List<Stop>();
        }

        public override string ToString()
        {
            return TrackNum.ToString();
        }
    }
}
