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
    public partial class EoFormCaption : UserControl
    {
        #region 속성
        [Category("Caption"), Description("ControlBox Visible")]
        public bool ControlBoxVisible
        {
            get { return this.ControlBox.Visible; }
            set { this.ControlBox.Visible = value; }
        }

        [Category("Caption"), Description("Icon Visible")]
        public bool IconVisible
        {
            get { return this.panelIcon.Visible; }
            set { this.panelIcon.Visible = value; }
        }

        [Category("Caption"), Description("Caption Text")]
        public string CaptionText
        {
            get { return this.labelTitle.Text; }
            set { this.labelTitle.Text = value; }
        }

        #endregion

        public EoFormCaption()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        public void Init(Form main)
        {
            this.mMainForm = main;
            InitMove();
            this.ControlBox.Init(main);
        }

        #region Move
        private Form mMainForm = null;
        private bool bMove = false;
        private Point mClickPoint;
        private void InitMove()
        {
            foreach (Control c in this.Controls)
            {
                c.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartMove);
                c.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UpdateMove);
                c.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StopMove);
            }
        }
        private void StartMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && this.mMainForm != null)
            {
                bMove = true;
                mClickPoint.X = Cursor.Position.X - mMainForm.Left;
                mClickPoint.Y = Cursor.Position.Y - mMainForm.Top;
            }
        }
        private void UpdateMove(object sender, MouseEventArgs e)
        {
            if (this.mMainForm != null && bMove)
            {
                mMainForm.Left = Cursor.Position.X - mClickPoint.X;
                mMainForm.Top = Cursor.Position.Y - mClickPoint.Y;
            }
        }
        private void StopMove(object sender, MouseEventArgs e)
        {
            bMove = false;
        }
        #endregion

        
        
    }
}
