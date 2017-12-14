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
using System.Reflection;
using Polynome;
using System.IO;

namespace SuperCalculator
{
    public partial class SuperCalculator3000 : Form
    {
        public static Dictionary<string, IFunction> functions = new Dictionary<string, IFunction>();

        private void LoadFunction(string path)
        {
            try
            {
                Assembly dll = Assembly.LoadFile(path);
                foreach (Type type in dll.GetExportedTypes())
                {
                    try
                    {
                        IFunction function = (IFunction) Activator.CreateInstance(type);
                        functions.Add(function.Name, function);
                    }
                    catch
                    {
                        MessageBox.Show("This is not a dll based on SuperComputer interface !");
                    }
                }
            }
            catch
            {
                MessageBox.Show("This is not a dll !");
            };
        }


        public SuperCalculator3000()
        {
            string featured = Path.GetFullPath("../../../../dll");
            foreach (string filename in Directory.EnumerateFiles(featured))
            {
                LoadFunction(filename);
            }
            InitializeComponent();
        }
        private void Input_TextChanged(object sender, EventArgs e)
        {
            
        }
        //va revoyer un 2eme form qui afiche chaque help d'afilé dans la text box
        private void Help_Click_1(object sender, EventArgs e)
        {
            Helpform Helpform = new Helpform();
            Helpform.Show();
        }

        //loads new functions
        private void Load_Click(object sender, EventArgs e)
        {
            string path;
            Stream myStream = null;
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = "c:\\",
                Filter = "dll files (*.dll)|*.dll",
                FilterIndex = 1,
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
                            path = openFileDialog.FileName;
                            LoadFunction(path);
                            MessageBox.Show("Loaded" + path);
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
            File.WriteAllLines(@"../../../computed.txt", lines);
            MessageBox.Show("Operations Saved!");
        }

        //output text
        private void Ouput_TextChanged(object sender, EventArgs e)
        {

        }

        private void Input_TextChanged_1(object sender, EventArgs e)
        {

        }


    }
}
