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

namespace SuperCalculator
{
    public partial class Helpform : Form
    {
        public Helpform()
        {
            InitializeComponent();
            //change output font and size
            Output.Font = new Font("Century Gothic", 10, FontStyle.Regular);
            //loads the available function in the combobox
            foreach (KeyValuePair<string, IFunction> stuff in SuperCalculator3000.functions)
            {
                ComboFunctions.Items.Add(stuff.Key);                           
            }            

        }

        //close
        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        //gets the help message of the selected function
        private void Select_Click(object sender, EventArgs e)
        {           
            Output.Text = SuperCalculator3000.functions[ComboFunctions.Text].HelpMessage;
        }
    }
}
