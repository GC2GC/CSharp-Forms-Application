using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmStudent().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmAssessor().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new frmVenue().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new frmCourse().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new ScheduleForm().Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
