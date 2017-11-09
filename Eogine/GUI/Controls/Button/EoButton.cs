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
        public Image DefaultImage { get; set; }
        [Category("Button"), Description("Over Image")]
        public Image OverImage { get; set; }
        [Category("Button"), Description("Selected Image")]
        public Image SelectedImage { get; set; }
        [Category("Button"), Description("Disabled Image")]
        public Image DisabledImage { get; set; }

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
        }
        #endregion

    }
}
