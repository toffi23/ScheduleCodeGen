using System;
using System.ComponentModel;

namespace CodeGenMenetrend.ScheduleLib
{
    [Serializable]
    public class Schedule
    {
        private BindingList<Station> _stations;
        public BindingList<Station> Stations { get { return _stations; } }

        public Schedule()
        {
            _stations = new BindingList<Station>();
        }
        
    }
}
