using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Eogine
{
    public class EogineManager
    {
        public static event EoDelegate.Void BeforeStart;
        public static event EoDelegate.Void AfterStart;

        public static void Start(Form main)
        {
            if (main == null) return;
            if (BeforeStart != null) BeforeStart();
            Application.Run(main);
            if (AfterStart != null) AfterStart();
        }
    }
}
