using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenMenetrend.ScheduleLib
{
    [Serializable]
    public class Stop
    {
        public Station Station { get; private set; }
        public int Delay { get; private set; }

        public Stop(Station _station, int _delay)
        {
            Station = _station;
            Delay = _delay;
        }
    }
}
