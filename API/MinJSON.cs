using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace API
{
    class MinJSON : IDS
    {
        string file;
        DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(List<Figure>));
        public MinJSON(string file)
        {
            this.file = file;
        }
        public List<Figure> Load()
        {
            FileStream sr = new FileStream(file, FileMode.Open, FileAccess.Read);
            List<Figure> ListFig = (List<Figure>)ser.ReadObject(sr);
            return ListFig;
        }

        public void Save(List<Figure> fig)
        {
            FileStream stream = new FileStream(file, FileMode.Create, FileAccess.Write);
            ser.WriteObject(stream, fig);
            stream.Close();
        }
    }
}
