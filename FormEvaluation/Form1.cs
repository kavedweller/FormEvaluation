using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormEvaluation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Display dp = new Display
            {
                UName = textBox1.Text,
                Age = Convert.ToInt32(textBox2.Text),
                Address = textBox3.Text
            };

            dp.Show();
            this.Hide();
        }

     }
}
