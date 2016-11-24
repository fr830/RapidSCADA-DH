using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scada.Server.Svc
{
    sealed class Manager
    {
        private MainLogic mainLogic;
        public void StartService()
        {
            // initializing the necessary directories
            bool dirsExist; // necessary directories exist
            bool logDirExists;  // There are log files directory
            mainLogic.InitAppDirs(out dirsExist, out logDirExists);


        }

        internal void StopService()
        {
            throw new NotImplementedException();
        }

        internal void ShutdownService()
        {
            throw new NotImplementedException();
        }
    }
}
