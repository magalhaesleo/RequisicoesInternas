using NLog;
using NLog.Config;
using NLog.Targets;
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
            var config = new LoggingConfiguration();
            var logFile = new FileTarget("Arquivo de Log") { FileName = "LogRequisicoesInternas.txt", ArchiveEvery = FileArchivePeriod.Minute };
            config.AddRule(LogLevel.Debug, LogLevel.Fatal,logFile);
            NLog.LogManager.Configuration = config;
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

            SimpleInjectorContainer.RegisterInstances();
            System.Windows.Forms.Application.Run(SimpleInjectorContainer.Container.GetInstance<Main>());
        }
    }
}
