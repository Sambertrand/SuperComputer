using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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

        private void Clear_Click(object sender, EventArgs e)
        {
            Output.Text = "";
        }

        private void Load_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = "c:\\",
                Filter = "dll files (*.dll)|*.dll|All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            Output.Text = openFileDialog.FileName;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
    }
}
