using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bmi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result.Text = "";
            int weight = int.Parse(weightB.Text);
            double height = int.Parse(heightB.Text);
            if (height>100)
            {
                height /= 100;
            }
            double tti = weight / (height*height);
            result.Text = Convert.ToString(tti);
            if (tti<18.5)
            {
                result.Text += " - egyél";

            }
            else if (tti>25)
            {
                result.Text += " - ne egyél";
            }
            else
            {
                result.Text += " - király";
            }
        }
    }
}
