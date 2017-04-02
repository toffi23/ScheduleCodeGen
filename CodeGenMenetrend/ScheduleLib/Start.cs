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
        // If isSpecialActive is true ActiveFrom and ActiveTill
        // determines the start and end date of the 
        public bool isSpecialActive { get; set; }
        public int ActiveFrom { get; set; }
        public int ActiveTill { get; set; }
        
        public Start(DateTime pTime, int pCode, Track pRoute, bool pSpecial = false, 
            int pFrom = 0, int pTill = 0)
        {
            this.StartTime = pTime;
            this.StartCode = pCode;
            this.Route = pRoute;
            this.isSpecialActive = pSpecial;
            this.ActiveFrom = pFrom;
            this.ActiveTill = pTill;
        }

        public override string ToString()
        {
            return string.Format(StartTime.ToString("hh:mm"));
        }
    }
}
