using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Scada.Server.Svc
{
    public partial class SvcMain : ServiceBase
    {
        private Manager manager;    //manager,managing the Application
        public SvcMain()
        {
            InitializeComponent();
            manager = new Manager();
        }

        protected override void OnStart(string[] args)
        {
            manager.StartService();
        }

        protected override void OnStop()
        {
            manager.StopService();
        }
        protected override void OnShutdown()
        {
            manager.ShutdownService();
        }
    }
}
