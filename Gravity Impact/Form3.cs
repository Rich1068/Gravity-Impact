using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gravity_Impact
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //quit
            for (int i = Application.OpenForms.Count - 1; i != -1; i = Application.OpenForms.Count - 1)
            {
                Application.OpenForms[i].Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //retry
            this.Close();

        }
        

        private void Form3_Load(object sender, EventArgs e)
        {
            //score and highscore
            label1.Text = "Score:  " + Form1.score3;
            label3.Text = Properties.Settings.Default.h_score;

        }
    }
}
