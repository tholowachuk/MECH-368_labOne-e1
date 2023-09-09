using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labOne
{
    public partial class labOne : Form
    {
        public labOne()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            //as a continuous event, view X- and Y-values from within pictureBox to their respective listBoxes
            xText.Text = e.X.ToString("000");
            yText.Text = e.Y.ToString("000");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void clickText_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //upon mouseClick event, create string with X- and Y-values and show it in the listbox
            clickText.Text += "(" + e.X.ToString("000") + ", " + e.Y.ToString("000") + ")";
            clickText.AppendText(Environment.NewLine);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
