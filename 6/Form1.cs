using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String s = textBox1.Text, s0 = "";
            int n = s.Length;
            if (n % 2 == 0)
            {
                for (int i = n - 1; i >= 1; i -= 2)
                    s0 += s.Substring(i, 1);
            }
            else if (n % 2 == 1)
            {
                for (int i = n - 1; i >= 0; i -= 2)
                    s0 += s.Substring(i, 1);
            }
            textBox2.Text = s0;
        }
    }
}
