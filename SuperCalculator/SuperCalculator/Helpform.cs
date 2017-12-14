using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperCalculator
{
    public partial class Helpform : Form
    {
        public Helpform()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Output_TextChanged(object sender, EventArgs e)
        {
            foreach(var item in SuperCalculator3000.functions)
            {
                Output.Text += SuperCalculator3000.functions.Keys;
            }

        }
    }
}
