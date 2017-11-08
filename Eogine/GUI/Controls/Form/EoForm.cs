using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Eogine
{
    public partial class EoForm : Form
    {
        public EoForm()
        {
            InitializeComponent();
            ResizeForm();
        }

        [Category("Caption"), Description("ControlBox Visible")]
        public bool CaptionVisible
        {
            get { return this.CaptionBar.Visible; }
            set { this.CaptionBar.Visible = value; }
        }
        [Category("Caption"), Description("ControlBox Visible")]
        public bool ControlBoxVisible
        {
            get { return this.CaptionBar.ControlBoxVisible; }
            set { this.CaptionBar.ControlBoxVisible = value; }
        }
        [Category("Caption"), Description("Icon Visible")]
        public bool IconVisible
        {
            get { return this.CaptionBar.IconVisible; }
            set { this.CaptionBar.IconVisible = value; }
        }

        [Category("Layout"), Description("ClientSize")]
        public Size FormSize
        {
            get { return this.ClientSize; }
            set { this.ClientSize = value; }
        }

        #region resize
        private void ResizeForm()
        {
            if (FormSize.Width != this.ClientSize.Width || FormSize.Width != this.ClientSize.Width)
            {
                FormSize = new Size(this.Width, this.Height);
            }
        }
        private void EoForm_Resize(object sender, EventArgs e)
        {
            ResizeForm();
        }
        #endregion
        
    }
}
