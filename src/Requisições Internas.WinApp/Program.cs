using Requisições_Internas.WinApp.IoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Requisições_Internas.WinApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

            SimpleInjectorContainer.RegisterInstances();
            System.Windows.Forms.Application.Run(SimpleInjectorContainer.Container.GetInstance<Main>());
        }
    }
}
