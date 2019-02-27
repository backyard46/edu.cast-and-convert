using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CastDoubleToInt
{
    public partial class CastDoubleToInt : Form
    {
        public CastDoubleToInt()
        {
            InitializeComponent();
        }

        /// <summary>
        /// doubleの-2.9～2.9をintにキャストしてみる。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCast_Click(object sender, EventArgs e)
        {
            TextResult1.Text = ((int) double.Parse(textBox1.Text)).ToString();
            TextResult2.Text = ((int) double.Parse(textBox2.Text)).ToString();
            TextResult3.Text = ((int) double.Parse(textBox3.Text)).ToString();
            TextResult4.Text = ((int) double.Parse(textBox4.Text)).ToString();
            TextResult5.Text = ((int) double.Parse(textBox5.Text)).ToString();
        }
    }
}
