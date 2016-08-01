using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NecroBot_Settings_GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LauncherForm _SettingsForm = new LauncherForm();
            if (_SettingsForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new LauncherForm());
            }
        }
    }
}
