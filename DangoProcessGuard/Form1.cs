using JsonManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceProcess;
using System.Configuration.Install;
using System.IO;
using System.Diagnostics;
using System.Collections;

namespace DangoProcessGuard
{
    public partial class Form1 : Form
    {
        private string SERVICE_NAME = "DangoProcessGuardService";

        public Form1()
        {
            InitializeComponent();

            DangoConfig config = DangoConfig.Load();
            txCommandLine.Text = config.commandLine != null ? config.commandLine : "";
            txFileName.Text = config.fileName != null ? config.fileName : "";
            txStartPath.Text = config.startPath;
            btSave.Enabled = false;

            RefreshRegisterStatus();
        }

        private void RefreshRegisterStatus()
        {
            ServiceController service = ServiceController.GetServices().FirstOrDefault(sc => sc.ServiceName == SERVICE_NAME);
            if (service == null)
            {
                lbServiceStatus.Text = "未注册";
                btRegister.Enabled = true;
                btUnRegister.Enabled = false;
                btStart.Enabled = false;
                btStop.Enabled = false;
            }
            else
            {
                lbServiceStatus.Text = service.Status.ToString();
                btRegister.Enabled = false;
                btUnRegister.Enabled = true;
                btStart.Enabled = service.Status == ServiceControllerStatus.Stopped;
                btStop.Enabled = service.Status == ServiceControllerStatus.Running;
            }
        }

        private void btShowFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "应用程序(*.exe)|*.exe|所有文件(*.*)|*.*";
            ofd.ValidateNames = true;
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txFileName.Text= ofd.FileName;
                txStartPath.Text = Path.GetDirectoryName(ofd.FileName);
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            DangoConfig config = new DangoConfig();
            config.fileName = txFileName.Text;
            config.commandLine = txCommandLine.Text;
            config.startPath = txStartPath.Text;
            config.Save();
            btSave.Enabled = false;
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            using (AssemblyInstaller installer = new AssemblyInstaller())
            {
                installer.UseNewContext = true;
                string file = Path.Combine(Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName), SERVICE_NAME +".exe");
                installer.Path = file;
                IDictionary savedState = new Hashtable();
                installer.Install(savedState);
                installer.Commit(savedState);
                RefreshRegisterStatus();
                ServiceController service = ServiceController.GetServices().FirstOrDefault(sc => sc.ServiceName == SERVICE_NAME);
                service.Start();
            }
        }

        private void btUnRegister_Click(object sender, EventArgs e)
        {
            using (AssemblyInstaller installer = new AssemblyInstaller())
            {
                installer.UseNewContext = true;
                string file = Path.Combine(Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName), SERVICE_NAME + ".exe");
                installer.Path = file;
                installer.Uninstall(null);
                RefreshRegisterStatus();
            }
        }

        private void tmRefreshStatusTimer_Tick(object sender, EventArgs e)
        {
            RefreshRegisterStatus();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            ServiceController service = ServiceController.GetServices().FirstOrDefault(sc => sc.ServiceName == SERVICE_NAME);
            if (service != null)
            {
                service.Start();
            }
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            ServiceController service = ServiceController.GetServices().FirstOrDefault(sc => sc.ServiceName == SERVICE_NAME);
            if (service != null)
            {
                service.Stop();
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txFileName_TextChanged(object sender, EventArgs e)
        {
            btSave.Enabled = true;
        }

        private void txCommandLine_TextChanged(object sender, EventArgs e)
        {
            btSave.Enabled = true;
        }

        private void txStartPath_TextChanged(object sender, EventArgs e)
        {
            btSave.Enabled = true;
        }
    }
}
