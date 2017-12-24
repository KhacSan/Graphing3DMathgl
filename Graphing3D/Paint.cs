using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphing3D
{
    class Paint
    {
       



        private void loadListView(double x, double y, ListView list)
        {
            String[] row = { x.ToString(), y.ToString() };
            ListViewItem item = new ListViewItem(row);
            list.Items.Add(item);
        }
    }
}
