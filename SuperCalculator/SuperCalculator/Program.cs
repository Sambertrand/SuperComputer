using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperComputer;
using System.Reflection;
using Polynome;


namespace SuperCalculator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            //IFunction function = LoadFunction(@"E:\MyDocs\School\ECAM\BA3\POO\SuperComputer\dll\Roots.dll");
            //Console.WriteLine(function.Name);
            //Console.WriteLine("");
            //Console.WriteLine(function.HelpMessage);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SuperCalculator3000());
        }

        public static IFunction LoadFunction(string path)
        {
            Assembly dll = Assembly.LoadFile(path);
            Type type = dll.GetExportedTypes()[0];
            return (IFunction) Activator.CreateInstance(type);
        }
    }
}

