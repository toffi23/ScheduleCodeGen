using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenMenetrend.ScheduleLib
{
    [Serializable]
    public class Start
    {
        public DateTime StartTime { get; set; }
        public int StartCode { get; set; }
        public Track Route { get; set; }

        public Start(DateTime pTime, int pCode, Track pRoute)
        {
            this.StartTime = pTime;
            this.StartCode = pCode;
            this.Route = pRoute;
        }
    }
}
