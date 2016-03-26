using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Yaml.Serialization;

namespace API
{
    class MinYAML : IDS
    {
        string file;
        YamlSerializer serializer = new YamlSerializer();
        public MinYAML(string file)
        {
            this.file = file;
        }
        public List<Figure> Load()
        {

            StreamReader SW = new StreamReader(new FileStream(file, FileMode.Open));
            string s = SW.ReadToEnd();
            List<Figure> ListFig = (List<Figure>)serializer.Deserialize(s)[0];
            SW.Close();
            return ListFig;

        }

        public void Save(List<Figure> fig)
        {
            StreamWriter SW = new StreamWriter(new FileStream(file, FileMode.Create, FileAccess.Write));
            string yaml = serializer.Serialize(fig);
            SW.WriteLine(yaml);
            SW.Close();
        }
    }
}
