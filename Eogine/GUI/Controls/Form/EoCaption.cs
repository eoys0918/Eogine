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
        #region 속성
        [Category("Layout"), Description("ControlBox Visible")]
        public bool ControlBoxVisible
        {
            get { return this.panelControlBox.Visible; }
            set { this.panelControlBox.Visible = value; }
        }

        [Category("Layout"), Description("Icon Visible")]
        public bool IconVisible
        {
            get { return this.panelIcon.Visible; }
            set { this.panelIcon.Visible = value; }
        }
        #endregion

        public EoCaption()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        #region Move
        private Control mMainControl = null;
        private bool bMove = false;
        private Point mClickPoint;
        public void InitMove(Control main)
        {
            this.mMainControl = main;
            foreach(Control c in this.Controls)
            {
                c.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartMove);
                c.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UpdateMove);
                c.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StopMove);
            }
        }
        private void StartMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && this.mMainControl != null)
            {
                bMove = true;
                mClickPoint.X = Cursor.Position.X - mMainControl.Left;
                mClickPoint.Y = Cursor.Position.Y - mMainControl.Top;
            }
        }
        private void UpdateMove(object sender, MouseEventArgs e)
        {
            if (this.mMainControl != null && bMove)
            {
                mMainControl.Left = Cursor.Position.X - mClickPoint.X;
                mMainControl.Top = Cursor.Position.Y - mClickPoint.Y;
            }
        }
        private void StopMove(object sender, MouseEventArgs e)
        {
            bMove = false;
        }
        #endregion

        
        
    }
}
