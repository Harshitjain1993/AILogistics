using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapViewer
{
    public class DoubledBufferedPanel : Panel
    {
        public DoubledBufferedPanel()
        {
            base.DoubleBuffered = true;
        }
    }
}
