using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Eogine;

namespace EogineEditor
{
    public partial class MainForm : EoForm
    {
        public MainForm()
        {
            InitializeComponent();
            this.glViewport.ViewportCam.SetPosition(0.0f, 100.0f, -100.0f);
            this.glViewport.Start();
        }
    }
}
