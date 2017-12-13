using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperComputer;
using System.IO;

namespace SuperCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //IFunction function = Program.LoadFunction(path);
            InitializeComponent();
        }
        private void Input_TextChanged(object sender, EventArgs e)
        {

        }
        //va revoyer un 2eme form qui afiche chaque help d'afilé dans la text box
        private void Help_Click_1(object sender, EventArgs e)
        {

        }

        //loads new functions
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

        //clears the output
        private void Clear_Click(object sender, EventArgs e)
        {
            Output.Text = "";
        }

        //gl
        private void Compute_Click(object sender, EventArgs e)
        {

        }

        //save function
        private void Save_Click(object sender, EventArgs e)
        {
            string[] lines = Output.Text.Split('\n');
            System.IO.File.WriteAllLines(@"../../../computed.txt", lines);
            MessageBox.Show("Operations Saved!");
        }

        //output text
        private void Ouput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
