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
        #region 속성
        [Category("Caption"), Description("Caption Visible")]
        public bool CaptionEnable
        {
            get { return this.CaptionBar.Visible; }
            set { this.CaptionBar.Visible = value; }
        }
        [Category("Caption"), Description("Caption Text")]
        public string CaptionText
        {
            get { return this.CaptionBar.CaptionText; }
            set { this.CaptionBar.CaptionText = value; }
        }
        [Category("Caption"), Description("Icon Visible")]
        public bool IconVisible
        {
            get { return this.CaptionBar.IconVisible; }
            set { this.CaptionBar.IconVisible = value; }
        }
        [Category("Caption"), Description("Caption Text")]
        public Image IconImage
        {
            get { return this.CaptionBar.IconButton.DefaultImage; }
            set
            {
                this.CaptionBar.IconButton.DefaultImage = value;
                if (this.CaptionBar.IconButton.SelectedImage == null)
                {
                    this.CaptionBar.IconButton.SelectedImage = value;
                }
                if (this.CaptionBar.IconButton.OverImage == null)
                {
                    this.CaptionBar.IconButton.OverImage = value;
                }
            }
        }
        [Category("Caption"), Description("ControlBox Visible")]
        public bool ControlBoxVisible
        {
            get { return this.CaptionBar.ControlBoxVisible; }
            set { this.CaptionBar.ControlBoxVisible = value; }
        }

        [Category("Layout"), Description("ClientSize")]
        public Size FormSize
        {
            get { return this.ClientSize; }
            set { this.ClientSize = value; }
        }
        #endregion

        public EoForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.CaptionBar.Init(this);
        }

        #region resize
        private void ResizeForm()
        {
        }
        #endregion

    }
}
