using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Eogine
{
    public class EoDelegate
    {
        public delegate void Void();
        public delegate void Void<T>(T param);
        public delegate void VoidObject(object param);

        public delegate void VoidEvent(object sender, EventArgs e);
        public delegate void VoidKeyEvent(object sender, KeyEventArgs e);
    }
}
