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
        public List<Track> Stops { get; private set; }
        public List<Start> Starts { get; private set; }

        public Line(string _id)
        {
            ID = _id;
            Stops = new List<Track>();
            Starts = new List<Start>();
        }

        public override string ToString()
        {
            return ID;
        }

    }
}
