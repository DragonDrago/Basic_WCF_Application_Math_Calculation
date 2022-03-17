using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformsClient
{
    public partial class Form1 : Form
    {
        MathServiceReference.MathServiceClient obj = new MathServiceReference.MathServiceClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MathServiceReference.MyNumbers obj1 = new MathServiceReference.MyNumbers();
            obj1.Number1 = Convert.ToInt32(textBox1.Text);
            obj1.Number2 = Convert.ToInt32(textBox2.Text);
            int c = obj.AddAsync(obj1).Result; 
            textBox3.Text = c.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MathServiceReference.MyNumbers obj1 = new MathServiceReference.MyNumbers();
            obj1.Number1 = Convert.ToInt32(textBox1.Text);
            obj1.Number2 = Convert.ToInt32(textBox2.Text);
            int c = obj.SubtractAsync(obj1).Result;
            textBox3.Text = c.ToString();
        }
    }
}
