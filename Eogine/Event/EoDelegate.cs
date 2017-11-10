using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eogine
{
    public class EoDelegate
    {
        public delegate void Void();
        
        public delegate void VoidEvent(object sender, EventArgs e);
    }
}
