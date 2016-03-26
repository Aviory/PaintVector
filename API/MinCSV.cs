using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API
{
    class MinCSV : IDS
    {
        string file;
        public MinCSV(string file)
        {
            this.file = file;
        }
        public List<Figure> Load()
        {
            StreamReader SW = new StreamReader(new FileStream(file, FileMode.Open));
            var csv = new CsvReader(SW);
            csv.Configuration.HasHeaderRecord = false;
            csv.Configuration.Delimiter = ";";
            List<Figure> ListFig = (List<Figure>)csv.GetRecords<List<Figure>>();
            SW.Close();
            return ListFig;
        }

        public void Save(List<Figure> fig)
        {
            StreamWriter SW = new StreamWriter(new FileStream(file, FileMode.Create));
            var csv = new CsvWriter(SW);
            csv.Configuration.HasHeaderRecord = false;
            csv.Configuration.Delimiter = ";";
            csv.WriteRecord(fig);
            SW.Close();
        }
        //StreamReader sr = new StreamReader(new FileStream(file, FileMode.Open));
        //CsvReader csv = new CsvReader(sr);
        //csv.Configuration.HasHeaderRecord = true;
        //    csv.Configuration.Delimiter = ";";
        //    csv.Configuration.RegisterClassMap<CsvMap>();
        //    var lf = csv.GetRecords<Figure>().ToList();

        //sr.Close();
        //    return lf as List<Figure>;
    }
}
