using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scada.Server
{
    public class AppDirs
    {
        public string ConfigDir { get; set; }
        public string LangDir { get; set; }
        public string LogDir { get; protected set; }
        public string ModDir { get; set; }

        public void Init(string v)
        {
            throw new NotImplementedException();
        }
    }
}
