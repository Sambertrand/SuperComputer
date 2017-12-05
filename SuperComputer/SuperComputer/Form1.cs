using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperComputer
{
    public partial class SuperComputer : Form
    {
        public SuperComputer()
        {
            InitializeComponent();
        }
        //Compute
        private void Compute_Click(object sender, EventArgs e)
        {

        }
        //Save
        private void Save_Click(object sender, EventArgs e)
        {
            string[] lines = Output.Text.Split('\n');
            System.IO.File.WriteAllLines(@"../../../computed.txt", lines);
            MessageBox.Show("Operations Saved!");
        }
        //help
        private void Help_Click(object sender, EventArgs e)
        {

        }
        //text ouput
        private void Output_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
