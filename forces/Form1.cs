using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
        double sin(double x)
        {
            return (Math.Sin(x) * 180.0 / Math.PI);
        }
        double asin(double x)
        {
            return (Math.Asin(x) * 180 / Math.PI);

        }
        double  Cos(double x)
        {
            return (Math.Cos(x) * 180.0 / Math.PI);
        }
        double Acos(double x)
        {
            return (Math.Acos(x) * 180.0 / Math.PI);
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            double F = double.Parse(textBox1.Text);
            double angle = double.Parse(textBox2.Text);

            double fx = F * Cos(angle);
            double Fy = F * sin(angle);
            MessageBox.Show("Fx = " + fx + "*n");
            MessageBox.Show("Fy = " + Fy + "*n");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

         


        }
    }
}
