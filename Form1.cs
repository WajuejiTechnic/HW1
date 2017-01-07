using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW1_Zhe_Wang_Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt6PM = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 18, 0, 0);
            DateTime dt8AM = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 8, 0, 0);
            {
                if (radioButton1.Checked && DateTime.Now > dt6PM || DateTime.Now < dt8AM)
                    MessageBox.Show("Good Evening, Mr."+ textBox2.Text +" Age "+ textBox3.Text);
            }
            {
                if (radioButton2.Checked && DateTime.Now > dt6PM && DateTime.Now < dt8AM)
                    MessageBox.Show("Good Evening, Mrs." + textBox2.Text + " Age " + textBox3.Text);
            }
            {
                if(DateTime.Now < dt6PM && DateTime.Now > dt8AM && radioButton1.Checked)
                    MessageBox.Show("Good Day, Mr." + textBox2.Text + " Age " + textBox3.Text);
            }
            {
                if (DateTime.Now < dt6PM && DateTime.Now > dt8AM && radioButton2.Checked)
                    MessageBox.Show("Good Day, Mrs." + textBox2.Text + " Age " + textBox3.Text);
            }
        }
    }
}
