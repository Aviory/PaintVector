using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace API
{
    class MinXML : IDS
    {
        string file;
        XmlSerializer doc = new XmlSerializer(typeof(List<Figure>));
        FileStream stream;
        public MinXML(string file)
        {
            this.file = file;
        }

        public List<Figure> Load()
        {
            stream = new FileStream(file , FileMode.Open, FileAccess.Read);
            List<Figure> ListFig = (List<Figure>)doc.Deserialize(stream);
            return ListFig;
        }

        public void Save(List<Figure> fig)
        {
            stream = new FileStream(file, FileMode.Create, FileAccess.Write);
            doc.Serialize(stream, fig);
            stream.Close();
        }
    }
}
