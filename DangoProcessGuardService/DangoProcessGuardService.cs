using JsonManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Threading;

namespace DangoProcessGuardService
{
    public partial class DangoProcessGuardService : ServiceBase
    {
        private Process _process;

        public DangoProcessGuardService()
        {
            InitializeComponent();
        }

        protected void Work()
        { 
            DangoConfig config = DangoConfig.Load();

            if (config.fileName != null)
            {
                ProcessStartInfo info = new ProcessStartInfo();
                info.FileName = config.fileName;
                info.Arguments = config.commandLine;
                info.WorkingDirectory = (config.startPath != null && config.startPath.Length > 0 ? config.startPath : Path.GetDirectoryName(config.fileName));
                _process = Process.Start(info);
                _process.WaitForExit();
            }

            Stop();
        }

        protected override void OnStart(string[] args)
        {
            new Thread(Work).Start();
        }

        protected override void OnStop()
        {
            if (_process != null && !_process.HasExited)
            {
                _process.Kill();
            }
        }
    }
}
