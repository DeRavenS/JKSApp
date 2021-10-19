using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JKSApp.Presentation_Layer
{
    class Display
    {
        public void RefreshDVG(DataGridView dvg,BindingSource source)
        {

            source.ResetBindings(true);
            dvg.Update();
            dvg.Refresh();
        }
    }
}
