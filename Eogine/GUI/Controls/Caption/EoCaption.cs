using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Eogine
{
    public partial class EoCaption : UserControl
    {
        public EoCaption()
        {
            InitializeComponent();
        }

        [Category("Caption"), Description("ControlBox Visible")]
        public bool ControlBoxVisible
        {
            get { return this.panelControlBox.Visible; }
            set { this.panelControlBox.Visible = value; }
        }
        [Category("Caption"), Description("Icon Visible")]
        public bool IconVisible
        {
            get { return this.panelIcon.Visible; }
            set { this.panelIcon.Visible = value; }
        }
    }
}
