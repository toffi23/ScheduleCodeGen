using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenMenetrend.ScheduleLib
{
    [Serializable]
    public class Station : IEquatable<Station>
    {
        public String _name;
        public String Name { get { return _name; } }

        public Station(String pName)
        {
            _name = pName;
        }

        public bool Equals(Station other)
        {
            return _name == other.Name;
        }
    }
}
