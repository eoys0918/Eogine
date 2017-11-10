using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Eogine.Properties;

namespace Eogine.GUI.Controls.Form
{
    public partial class EoFormControlBox : UserControl
    {
        private Control mMainControl = null;

        public EoFormControlBox()
        {
            InitializeComponent();
        }

        public void Init(Control main)
        {
            this.mMainControl = main;
            InitButtons();
        }

        public void InitButtons()
        {
            
        }

        public event EoDelegate.VoidEvent MinClick;
        private void MinButton_Click(object sender, EventArgs e)
        {
            if(this.mMainControl != null)
            {

            }
            if(MinClick != null)
            {
                MinClick(sender, e);
            }
        }

        public event EoDelegate.VoidEvent MaxClick;
        private void MaxButton_Click(object sender, EventArgs e)
        {
            if (this.mMainControl != null)
            {

            }
            if (MaxClick != null)
            {
                MaxClick(sender, e);
            }
        }

        public event EoDelegate.VoidEvent CloseClick;
        private void CloseButton_Click(object sender, EventArgs e)
        {
            if (this.mMainControl != null)
            {
                
            }
            if (CloseClick != null)
            {
                CloseClick(sender, e);
            }
        }
    }
}
