using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperComputer;
using System.Reflection;

namespace SuperComputer
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            foreach (IFunction function in LoadFunction(@"../../../../dll/Combefis.dll"))
            {
                Console.WriteLine(function.Name);
                Console.WriteLine(function.HelpMessage);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SuperComputer());
        }

        static List<IFunction> LoadFunction(string path)
        {
            List<IFunction> functions = new List<IFunction>();
            Assembly dll = Assembly.LoadFile(path);
            Type type = dll.GetExportedTypes()[0];
            functions.Add( (IFunction) Activator.CreateInstance(type));
            return functions;
        }
    }
}
