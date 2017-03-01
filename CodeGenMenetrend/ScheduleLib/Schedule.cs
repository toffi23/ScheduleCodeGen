using System;
using System.ComponentModel;

namespace CodeGenMenetrend.ScheduleLib
{
    [Serializable]
    public class Schedule
    {
        private BindingList<Station> _stations;
        public BindingList<Station> Stations { get { return _stations; } }

        private BindingList<Line> _lines;
        public BindingList<Line> Lines { get { return _lines; } }

        public Schedule()
        {
            _stations = new BindingList<Station>();
            _lines = new BindingList<Line>();
        }
    }
}
