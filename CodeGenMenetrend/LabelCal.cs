using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace CodeGenMenetrend
{   
    public partial class LabelCal : Form
    {
        private MainMenu parent;

        private Label[] dates;
        private Color[] colors;
        private int[] dayCodes; 

        private readonly int YEAR = DateTime.Now.Year;

        private static readonly Color WORKDAY = Color.White;
        private static readonly Color NOSCHOOLWORK= Color.BlueViolet;
        private static readonly Color FREEDAY = Color.LimeGreen;
        private static readonly Color NOWORK = Color.Red;

        private readonly string CODESPATH = "dateCodes.xml";
        private readonly string GENERATEDPATH = Directory.GetCurrentDirectory()+"\\ScheduleCalendar_initActiveCodes.txt";

        private Color SELECTCOLOR;

        private readonly string[] MONTHNAMES =
        {
            "Január",
            "Február",
            "Március",
            "Április",
            "Május",
            "Június",
            "Július",
            "Augusztus",
            "Szeptember",
            "Október",
            "November",
            "December"
        };

        public LabelCal(MainMenu pMainMenu)
        {
            parent = pMainMenu;

            InitializeComponent();

            radioFree.BackColor = FREEDAY;
            radioNoschool.BackColor = NOSCHOOLWORK;
            radioWork.BackColor = WORKDAY;
            radioSun.BackColor = NOWORK;
            SELECTCOLOR = WORKDAY;

            this.label_Title.Text = "Menetrendi naptár - " + YEAR;

            Panel[] months = { january, february, march, april, may, june, july, august, september, october, november, december };

            dateCodes codes = DeSerialize();

            bool newCal;

            if (codes == null)
            {
                dates = new Label[367];
                colors = new Color[367];
                dayCodes = new int[367];

                newCal = true;
            }
            else
            {
                dates = new Label[367];
                colors = codes.getColors();
                dayCodes = codes.getDayCodes();

                newCal = false;
            }

            for (int i = 0; i < 12; i++)
            {
                drawMonth(i + 1, months[i],newCal);
            }

        }

        private dateCodes DeSerialize()
        {
            dateCodes codes;

            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(dateCodes));
                FileStream reader = new FileStream(CODESPATH, FileMode.Open);

                codes = (dateCodes)ser.Deserialize(reader);

                reader.Close();
                reader.Dispose();
            }
            catch(FileNotFoundException)
            {
                codes = null;
            }
            catch(Exception)
            {
                codes = null;
            }

            return codes;
        }

        private void drawMonth(int month, Panel container, bool newCal)
        {
            if (month < 1 || month > 12)
            {
                MessageBox.Show("Incorrect parameter for drawMonth(int,int,int): month");
                return;
            }

            string monthName = MONTHNAMES[month - 1];

            DateTime date;
            Label label;
            int daysInMonth = 0;

            int dayW = 30;
            int dayH = 15;

            int X0 = label5_csutortok.Width + 20;
            int Y0 = label1_title.Height + 5;
            int X = X0;
            int Y = Y0;
            int W = 20;
            int H = dayH;
            int padW = 2;
            int padH = 2;

            int m = month;

            // draw day numbers
            daysInMonth = DateTime.DaysInMonth(YEAR, m);

            for (int d = 1; d <= daysInMonth; d++)
            {
                date = new DateTime(YEAR, m, d);
                label = new Label();

                dates[date.DayOfYear] = label;
                if (newCal)
                {
                    colors[date.DayOfYear] = WORKDAY;
                    dayCodes[date.DayOfYear] = CodeGen.WORKDAY;
                }

                
                label.Tag = date;
                label.Text = String.Format("{0,2}", d);
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.BackColor = colors[date.DayOfYear];

                label.Click += new EventHandler(onDateSelected);

                if(d == 1)
                {
                    Y = Y0 + getFirstDay(date.DayOfWeek) * (H + padH);
                }
                else if(date.DayOfWeek == DayOfWeek.Monday && d > 1)
                {
                    X += W + padW;
                    Y = Y0;
                }
                else
                {
                    Y += H + padH;
                }

                label.SetBounds(X, Y, W, H);

                container.Controls.Add(label);
            }                
        }

        private int getFirstDay(DayOfWeek dow)
        {
            switch(dow)
            {
                case DayOfWeek.Monday:
                    return 0;
                case DayOfWeek.Tuesday:
                    return 1;
                case DayOfWeek.Wednesday:
                    return 2;
                case DayOfWeek.Thursday:
                    return 3;
                case DayOfWeek.Friday:
                    return 4;
                case DayOfWeek.Saturday:
                    return 5;
                case DayOfWeek.Sunday:
                    return 6;
                default:
                    return -1;
            }
        }

        private void setLabel(Label lab,int X, int Y, int W, int H)
        {
            lab.SetBounds(X, Y, W, H);


        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            SELECTCOLOR =
                radioWork.Checked ? WORKDAY :
                radioNoschool.Checked ? NOSCHOOLWORK :
                radioFree.Checked ? FREEDAY : NOWORK;
        }

        private void onDateSelected(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            DateTime date = (DateTime)label.Tag;

            label.BackColor = SELECTCOLOR;
            colors[date.DayOfYear] = SELECTCOLOR;

            dayCodes[date.DayOfYear] =
                SELECTCOLOR == WORKDAY ? CodeGen.WORKDAY :
                SELECTCOLOR == NOSCHOOLWORK ? CodeGen.NOSCHOOLWORK :
                SELECTCOLOR == FREEDAY ? CodeGen.FREEDAY :
                SELECTCOLOR == NOWORK ? CodeGen.NOWORK :
                0;

                
        }

        private void LabelCal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to save changes?", "Save chamges", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {

                dateCodes codes = new dateCodes();
                codes.setYear(YEAR);
                codes.setColors(colors);
                codes.setDayCodes(dayCodes);

                XmlSerializer ser = new XmlSerializer(typeof(dateCodes));
                StringWriter sw = new StringWriter();
                StreamWriter writer = new StreamWriter(CODESPATH);
                ser.Serialize(writer, codes);

                writer.Close();
                writer.Dispose();
                sw.Dispose();
            }

            parent.Show();
        }

        private void button_gencode_Click(object sender, EventArgs e)
        {
            CodeGen gen = new CodeGen(dayCodes, YEAR);
            gen.buildFunction();
            gen.writeToFile(GENERATEDPATH);
        }
    }
}
