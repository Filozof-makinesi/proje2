using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";

            for (int i = 0; i < this.Controls.Count ; i++)
            {
                  if (this.Controls[i]  is CheckBox)
                {
                    CheckBox c = (CheckBox)Controls[i];
                    if (c.Checked)
                        textBox1.Text += c.Text + " ";

                }
            }
        }
    }
}
