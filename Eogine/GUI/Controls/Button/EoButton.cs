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
    public partial class EoButton : UserControl
    {
        public enum TYPE
        {
            DEFAULT,
            IMAGE
        }
        #region 속성
        [Category("Button"), Description("Type")]
        public TYPE ButtonType
        {
            get { return mButtonType; }
            set { SetButtonType(value); }
        }

        [Category("Button"), Description("Default Image")]
        public Image DefaultImage
        {
            get { return this.mDefaultImage; }
            set
            {
                this.mDefaultImage = value;
                this.BackgroundImage = value;
            }
        }
        private Image mDefaultImage;

        [Category("Button"), Description("Over Image")]
        public Image OverImage
        {
            get { return this.mOverImage; }
            set { this.mOverImage = value; }
        }
        private Image mOverImage;

        [Category("Button"), Description("Selected Image")]
        public Image SelectedImage
        {
            get { return this.mSelectedImage; }
            set { this.mSelectedImage = value; }
        }
        private Image mSelectedImage;

        [Category("Button"), Description("Disabled Image")]
        public Image DisabledImage
        {
            get { return this.mDisabledImage; }
            set { this.mDisabledImage = value; }
        }
        private Image mDisabledImage;

        #endregion

        public EoButton()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        #region 버튼 유형
        private TYPE mButtonType = TYPE.DEFAULT;
        private void SetButtonType(TYPE value)
        {
            switch (this.mButtonType = value)
            {
                case TYPE.DEFAULT:
                    this.BackgroundImage = null;
                    break;
                case TYPE.IMAGE:
                    this.BackgroundImage = this.DefaultImage;
                    break;
            }
            Invalidate();
        }
        #endregion

        private void EoButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.mButtonType == TYPE.IMAGE)
            {
                this.BackgroundImage = this.SelectedImage;
            }
        }
        
        private void EoButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.mButtonType == TYPE.IMAGE)
            {
                this.BackgroundImage = this.DefaultImage;
            }
        }

        private void EoButton_MouseEnter(object sender, EventArgs e)
        {
            if (this.mButtonType == TYPE.IMAGE)
            {
                this.BackgroundImage = this.OverImage;
            }
        }

        private void EoButton_MouseLeave(object sender, EventArgs e)
        {
            if (this.mButtonType == TYPE.IMAGE)
            {
                this.BackgroundImage = this.DefaultImage;
            }
        }

    }
}
