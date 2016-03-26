using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API
{
    public interface IDS
    {
        void Save(List<Figure> figs);
        List<Figure> Load();
    }
}
