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
        /// -2.9～2.9をParseでintに変換してみる。
        /// → エラー。そもそも「Parse」は「変換」ではなく「構文読解」や「解釈」なので、
        /// 　一定のルール（ここではデータ型）にそぐわないものはエラーになる。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCast_Click(object sender, EventArgs e)
        {
            TextResult1.Text = int.Parse(textBox1.Text).ToString();
            TextResult2.Text = int.Parse(textBox2.Text).ToString();
            TextResult3.Text = int.Parse(textBox3.Text).ToString();
            TextResult4.Text = int.Parse(textBox4.Text).ToString();
            TextResult5.Text = int.Parse(textBox5.Text).ToString();
        }
    }
}
