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
        public Track Route { get; set; }
        public int StartCode { get; set; }
        public int ActiveFrom { get; set; }
        public int ActiveTill { get; set; }
        
        public Start(DateTime pTime, int pCode, Track pRoute, int pFrom = 0, int pTill = 0)
        {
            this.StartTime = pTime;
            this.StartCode = pCode;
            this.Route = pRoute;
            this.ActiveFrom = pFrom;
            this.ActiveTill = pTill;
        }

        public override string ToString()
        {
            return string.Format(StartTime.ToString("hh:mm"));
        }
    }
}
