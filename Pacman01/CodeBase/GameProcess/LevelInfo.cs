using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CodeBase.GameProcess
{
    public class LevelInfo
    {
        public LevelInfo(string path, string pathOutput)
        {
            this.path = path;
            this.pathOutput = pathOutput;
        }
        public string path { get; set; }
      
        public string pathOutput { get; set; }
    }
}
