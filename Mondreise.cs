using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mond
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double pace = Convert.ToDouble(textBox1.Text); 
            Mondreise m = new Mondreise();
            if (rB_Stunden.Checked == true)
            {
                double dauer = 384400 / pace;
                textBox2.Text = dauer.ToString();
            }
            if(rB_Tage.Checked == true)
            {
                double dauer = 384400 / pace / 24;
                textBox2.Text = dauer.ToString();

            }

        }
    }
}
