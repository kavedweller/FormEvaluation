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
    public partial class Display : Form
    {
        public Display()
        {
            InitializeComponent();
            Load += new EventHandler(Display_Load);
        }

        private void AppendTextBoxLine(string newStr)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.AppendText(Environment.NewLine);
            }
            textBox1.AppendText(newStr);
        }

        public string UName;
        public int Age;
        public string Address;

        public string AgeGroup;


        public void Display_Load(object sender, System.EventArgs e)
        {
            AppendTextBoxLine("Name:");
            AppendTextBoxLine(UName);
            AppendTextBoxLine("\n");
            AppendTextBoxLine("Address:");
            AppendTextBoxLine(Address);

            if (Age < 12)
            {
                AgeGroup = "a child.";
            }
            else if (Age < 20 && Age >= 13)
            {
                AgeGroup = "a teen-ager.";
            }
            else
            {
                AgeGroup = "an adult.";
            }

            label1.Text = "This user is " + AgeGroup;

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

    }
}
