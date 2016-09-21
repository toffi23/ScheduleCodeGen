using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeGenMenetrend
{
    class CodeGen
    {
        public static readonly int WORKDAY = 1;
        public static readonly int NOSCHOOLWORK = 2;
        public static readonly int FREEDAY = 3;
        public static readonly int NOWORK = 4;

        private String Output;

        private string tab;
        private string funcName;
        private string open;
        private string close;
        private string endline;

        private int[] dayCodes;
        private int YEAR;

        private string[] codeNames =
        {
            "ERROR",
            "WORKDAY",
            "NOSCHOOLWORK",
            "FREEDAY",
            "NOWORK"
        };

        public CodeGen(int[] pDayCodes, int pYear)
        {
            Output = "";
            tab = "    ";
            funcName = "private void initActiveCodes()";
            open = "{";
            close = "}";
            endline = "\r\n";

            dayCodes = pDayCodes;
            YEAR = pYear;
        }

        public void buildFunction()
        {
            Output += tab + funcName + endline + tab + open + endline;

            DateTime date;
            int days;
            String comment = "";
            String assig = "";
            int DoY;
            string codeName;

            // reserved first (0) element 
            comment = String.Format("// Reserved first element");
            assig = String.Format("ActiveCodes[0] = 0");
            Output += tab + tab + comment + endline;
            Output += tab + tab + assig + endline;
            Output += endline;

            // generate day code assigments
            for (int m = 1; m <= 12; m++)
            {
               
                days = DateTime.DaysInMonth(YEAR, m);
                for (int d = 1; d <= days; d++)
                {
                    date = new DateTime(YEAR, m, d);
                    DoY = date.DayOfYear;
                    codeName = codeNames[dayCodes[DoY]];

                    comment = String.Format("// {0,2}-{1,2}", m.ToString("D2"), d.ToString("D2"));
                    assig = String.Format("ActiveCodes[" + DoY + "] = " + codeName);

                    Output += tab + tab + comment + endline;
                    Output += tab + tab + assig + endline;
                    Output += endline;
                }
            }
            /*
            // 01-01
            ActiveCodes[0] = ACTIVE_SUNDAY;*/

            //Console.WriteLine(Output);
        }

        private string buildOneDay(DateTime date)
        {
            string dayStr = "";

            return dayStr;
        }

        public void writeToFile(string path)
        {
            StreamWriter writer = null; ;
            try
            {
                writer = new StreamWriter(path);
                //Console.Write(Output);
                writer.Write(Output);
                writer.Close();
                writer.Dispose();
            }
            catch(FileNotFoundException ex)
            {

                if(writer != null)writer.Dispose();

                MessageBox.Show(ex.ToString());
            }

            
        }


    }
}
