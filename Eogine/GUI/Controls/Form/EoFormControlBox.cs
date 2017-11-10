using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Eogine.Properties;

namespace Eogine
{
    public partial class EoFormControlBox : UserControl
    {
        private Form mMainForm = null;

        public EoFormControlBox()
        {
            InitializeComponent();
        }

        public void Init(Form main)
        {
            this.mMainForm = main;
            InitButtons();
        }

        public void InitButtons()
        {
            
        }

        private void MinButton_Click(object sender, EventArgs e)
        {
            if(this.mMainForm != null)
            {
                this.mMainForm.WindowState = FormWindowState.Minimized;
            }
        }

        private bool isMaxized = false;
        private void MaxButton_Click(object sender, EventArgs e)
        {
            if (this.mMainForm != null)
            {
                if (isMaxized)
                {
                    this.mMainForm.WindowState = FormWindowState.Normal;
                }
                else
                {
                    this.mMainForm.WindowState = FormWindowState.Maximized;
                }
                isMaxized = !isMaxized;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            if (this.mMainForm != null)
            {
                this.mMainForm.Close();
            }
        }
    }
}
