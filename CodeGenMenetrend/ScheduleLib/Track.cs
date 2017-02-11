using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenMenetrend.ScheduleLib
{
    [Serializable]
    class Track
    {
        public List<Stop> Stops { get; private set; }

        public Track()
        {
            Stops = new List<Stop>();
        }
    }
}
