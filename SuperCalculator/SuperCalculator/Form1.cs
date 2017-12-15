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
                        IFunction function = (IFunction)Activator.CreateInstance(type);
                        functions.Add(function.Name, function);
                    }
                    catch (MissingMethodException e)
                    {
                        MessageBox.Show("This is not a dll based on SuperComputer interface ! : \n" + e.Message);
                    }
                }
            }
            catch (BadImageFormatException e)
            {
                MessageBox.Show("This is not a good dll ! : \n" + e.Message);
            }
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
                Filter = "dll files (*.dll)|*.dll|All files(*.*)| *.*",
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
                            int c = functions.Count();
                            path = openFileDialog.FileName;
                            LoadFunction(path);
                            if (c < functions.Count())
                                MessageBox.Show("Loaded " + path);
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

        private string Calcul(string input)
        {
            string result="";
            string[] stuff = input.Split(' ');
            string op = stuff[0];
            string[] data = stuff.Skip(1).ToArray();
            if (functions.ContainsKey(op))
            {
                IFunction function = functions[op];
                Type type = function.GetType();
                object eval = null;
                try
                {
                    eval = type.InvokeMember("Evaluate", BindingFlags.InvokeMethod, null, function, new object[] { data });
                }
                catch (EvaluationException e)
                {
                    result = e.Message;
                }
                catch 
                {
                    result = "Wrong parameters";
                }
                if (eval is System.Collections.IEnumerable enumerable)
                {
                    if (enumerable.GetType() == "".GetType())
                    {
                        result += enumerable;
                    }
                    else
                    {
                        result = "[";
                        foreach (var item in enumerable)
                        {
                            result += item.ToString();
                            result += " ,";
                        }
                        try
                        {
                            result = result.Remove(result.Length - 2);
                        }
                        catch
                        {
                            result += "None";
                        }
                        result += "]";
                    }
                }
                else if (eval != null)
                {
                    result = eval.ToString();
                }
            }
            else
            {
                result = "Unkwon command";
            }

            return result;
        }

        //gl
        private void Compute_Click(object sender, EventArgs e)
        {
            Output.Text += ">" + Input.Text + "\n";
            Output.Text += Calcul(Input.Text) + "\n";
            Input.Text = "";
        }

        //save function
        private void Save_Click(object sender, EventArgs e)
        {
            string[] lines = Output.Text.Split('\n');
            File.WriteAllLines(@"../../../../SuperCalulator3000Save.txt", lines);
            MessageBox.Show("Operations Saved!\n" 
                + Path.GetFullPath(@"../../../../SuperCalulator3000Save.txt"));
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
