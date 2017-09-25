using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace szarendszer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const string szamjegyek = "0123456789abcdefghijklmnopqrstuvwxyz";
            int originalNum;
            int originalNSys = int.Parse(ocB.Text);
            int converterNSys = int.Parse(ncB.Text);
            string convertedNum = "";
            int temp=0;
            /*if (originalNSys>converterNSys)
            {
                while (originalNum!=0)
                {
                    convertedNum += (originalNum % converterNSys).ToString();
                    originalNum /= converterNSys;
                }
                convertedNum.Reverse();
            }
            else if (originalNSys<converterNSys)
            {*/
                for (int i = 0; i < onB.Text.Length; i++)
                {
                    temp *= originalNSys;
                if (szamjegyek.IndexOf(onB.Text[i])>=originalNSys)
                {
                    nnB.Text = "Te nem vagy normális!";
                    return;
                }
                    temp += szamjegyek.IndexOf(onB.Text[i]);
                    //temp += (int.Parse(temps[i].ToString()) * Convert.ToInt32(Math.Pow(converterNSys,i)));
                }
                originalNum = temp;
            while (originalNum != 0)
            {
                int leftover = originalNum % converterNSys;
                convertedNum = szamjegyek[leftover] + convertedNum;
                originalNum /= converterNSys;
            }
            
            /*}
            else
            {
                convertedNum = onB.Text;
            }
            */
            nnB.Text = convertedNum;
        }
    }
}
