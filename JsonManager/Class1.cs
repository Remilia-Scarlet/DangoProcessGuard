using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JsonManager
{
    public class DangoConfig
    {
        public string fileName;
        public string commandLine;
        public string startPath;
        public static DangoConfig Load()
        {
            try
            {
                string file = Path.Combine(Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName), "config.json");
                DangoConfig config = JsonConvert.DeserializeObject<DangoConfig>(File.ReadAllText(file));
                return config;
            }
            catch(Exception)
            {
                return new DangoConfig();
            }
        }
        public void Save()
        {
            string json = JsonConvert.SerializeObject(this, Formatting.Indented);
            string file = Path.Combine(Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName), "config.json");
            File.WriteAllText(file, json);
        }
    }
}
