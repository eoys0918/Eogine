using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Eogine;
using OpenTK;

namespace EogineEditor
{
    public partial class MainForm : EoForm
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
        #region 화면 로드
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            InitViewport();
            
        }

        private void InitViewport()
        {
            this.glViewport.ViewportCam.position = new Vector3(-100.0f, 100.0f, -100.0f);
            this.glViewport.ViewportCam.target = Vector3.Zero;



            this.glViewport.Start();
        }
        #endregion
    }
}
