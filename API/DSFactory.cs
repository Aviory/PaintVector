using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API
{
    public class DSFactory
    {
        public static IDS getInstance(string file)
        {
            IDS ds = null;
            string ext = Path.GetExtension(file);
            switch (ext)
            {
                case ".JSON": ds = new MinJSON(file); break;
                case ".XML": ds = new MinXML(file); break;
                case ".CSV": ds = new MinCSV(file); break;
                case ".Yaml": ds = new MinYAML(file); break;
                default: throw new InvalidOperationException();
            }
            return ds;
        }
    }
}
