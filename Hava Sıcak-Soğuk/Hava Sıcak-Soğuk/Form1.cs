using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hava_Sıcak_Soğuk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sıcaklık;
            sıcaklık = Convert.ToDouble(textBox1.Text);
            if (sıcaklık >= 25) 
            {
                this.BackColor = Color.Red;
                MessageBox.Show("Hava Sıcak");
            }
            else if (sıcaklık >= 10) 
            {
                this.BackColor = Color.Gold;
                MessageBox.Show("Hava Hafif Sıcak");
            }
            else if (sıcaklık < 10)
            {
                this.BackColor = Color.Blue;
                MessageBox.Show("Hava Soğuk");
            }

        }
    }
}
