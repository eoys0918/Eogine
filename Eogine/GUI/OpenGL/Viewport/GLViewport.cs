using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using System.Timers;

namespace Eogine
{
    public partial class GLViewport : GLControl
    {
        public Color ViewportBackgroundColor
        {
            get { return this.BackColor; }
            set 
            { 
                this.BackColor = value; 
            }
        }

        public GLViewport()
        {
            InitializeComponent();
        }

        public void Start()
        {
            System.Timers.Timer trigger = new System.Timers.Timer();
            trigger.Elapsed += new ElapsedEventHandler(UpdateViewport);
            trigger.Interval = 1000 / 30; // FPS :  30f/s
            trigger.Start();
        }

        private void UpdateViewport(object sender, ElapsedEventArgs e)
        {
            this.Refresh();
        }

        private void GLViewport_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                GL.ClearColor(this.BackColor);
                GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);



                this.SwapBuffers();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
