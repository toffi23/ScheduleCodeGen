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
        public List<Stop> Stops { get; private set; }

        public Line(string _id)
        {
            ID = _id;
            Stops = new List<Stop>();
        }

        public override string ToString()
        {
            return ID;
        }
    }
}
