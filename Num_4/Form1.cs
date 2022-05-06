using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Num_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Day.TextChanged += Date_Change;
            Month.TextChanged += Date_Change;
            Year.TextChanged += Date_Change;
        }
        private void Date_Change(object sender, EventArgs e)
        {
            if (Day.Text != "" && Month.Text != "" && Year.Text != "")
            {
                int d = int.Parse(Day.Text);
                int m = int.Parse(Month.Text);
                int y = int.Parse(Year.Text);
                if (d != 0 && m != 0 && y != 0)
                    monthCalendar1.SetDate(new DateTime(y, m, d));
            }
        }
    }
}
