using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Add_Numbers_Prototype
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(numToAddTB.Text != "")
            {
                double numberToAdd = Convert.ToDouble(numToAddTB.Text);
                listBox1.Items.Add(numberToAdd);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = 0;
            double result = 0.0;
            while (i < listBox1.Items.Count)
            {
                result += Convert.ToDouble(listBox1.Items[i++]);
            }
            totalTB.Text = Convert.ToString(result);
            historyLB.Items.Add(result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            historyLB.Items.Clear();
            numToAddTB.Clear();
            totalTB.Clear();
        }
    }
}
