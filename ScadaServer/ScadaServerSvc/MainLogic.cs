using Utils;
using System;
using System.IO;
using System.Reflection;

namespace Scada.Server.Svc
{

    
    internal class MainLogic
    {
        private const string LogFileName = "ScadaServerSvc.log";
        private const string InfoFileName = "ScadaServerSvc.txt";
        private string infoFileName;    // the full name of the file infomation

        public AppDirs AppDirs { get; private set; }
        public Log AppLog { get; private set; }
        internal void InitAppDirs(out bool dirsExist, out bool logDirExists)
        {
            AppDirs.Init(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

            AppLog.FileName = AppDirs.LogDir + LogFileName;
            infoFileName = AppDirs.LogDir + InfoFileName;
            logDirExists = Directory.Exists(AppDirs.LogDir);
            dirsExist = Directory.Exists(AppDirs.ConfigDir) && Directory.Exists(AppDirs.LangDir) &&
                logDirExists && Directory.Exists(AppDirs.ModDir);
        }
    }
}