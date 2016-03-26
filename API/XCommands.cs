using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace API
{
    public class XCommands
    {
        public StateAction aState = new StateAction();

        public class StateAction : ICmd
        {
            public void Action(object sender, EventArgs e)
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "JSON|*.JSON|XML|*.XML|CSV|*.CSV|Yaml|*.Yaml";
                saveFileDialog1.Title = "Save File";
                saveFileDialog1.ShowDialog();
            }
        }
    }
}
