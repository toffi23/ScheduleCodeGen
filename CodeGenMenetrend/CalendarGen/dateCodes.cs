using System;
using System.Drawing;

namespace CodeGenMenetrend.CalendarGen
{
    [Serializable]
    public class dateCodes
    {
        public int year;
        public int[] colors;
        public int[] dayCodes;

        public dateCodes()
        {
            
        }

        public void setColors(Color[] _colors)
        {
            colors = new int[_colors.Length];
            for(int i = 0; i < _colors.Length; i++)
            {
                colors[i] = _colors[i].ToArgb();
            }
        }

        public Color[] getColors()
        {
            Color[] _colors = new Color[colors.Length];

            for(int i = 0; i < colors.Length; i++)
            {
                _colors[i] = Color.FromArgb(colors[i]);
            }

            return _colors;
        }

        public void setYear(int _year)
        {
            year = _year;
        }

        public int getYear()
        {
            return year;
        }

        public void setDayCodes(int[] _daycodes)
        {
            dayCodes = _daycodes;
        }

        public int[] getDayCodes()
        {
            return dayCodes;
        }


    }
}
