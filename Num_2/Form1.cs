using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Num_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load_1;
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            dateTimePicker1.ValueChanged += Date;
            dateTimePicker2.ValueChanged += Date;

            this.BackColor = Color.Aqua;
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(new Rectangle(55, 55, 400, 400));
            Region region = new Region(path);
            this.Region = region;
        }
        private void Date(object sender, EventArgs e)
        {
            TimeSpan time = dateTimePicker2.Value - dateTimePicker1.Value;
            if (time.Days == 0)
                Result.Text = $"{time.Hours.ToString()} часa";
            if (time.Days < 0)
            {
                MessageBox.Show("Отсчет начинается с большей даты", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateTimePicker2.Value = dateTimePicker1.Value;
            }
            if (time.Days > 0)
                Result.Text = $"{time.Days.ToString()} дней";
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
