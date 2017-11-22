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
using System.Collections;

namespace Eogine
{
    public partial class GLViewport : GLControl
    {
        private Matrix4 projection;
        private Matrix4 modelview;

        private EoContainer<GLObject> mObjectContainer = null;
        //private EoContainer<GLCamera> mCameraContainer = null;

        private GLGrid mGrid = null;
        private GLCamera mViewportCamera = null;

        private bool updateViewport = false;
        private bool updateProjection = false;
        private bool updateView = false;

        #region 속성
        [Category("GLViewport"), Description("Background Color")]
        public Color BackgroundColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }
        [Category("GLViewport"), Description("Grid")]
        public GLGrid Grid
        {
            get { return this.mGrid; }
        }
        [Category("GLViewport"), Description("Viewport Camera")]
        public GLCamera ViewportCam
        {
            get { return this.mViewportCamera; }
        }
        #endregion

        public GLViewport()
        {
            InitializeComponent();
            InitObject();
            InitCamera();
        }

        private void GLViewport_Load(object sender, EventArgs e)
        {            
        }

        public void Start()
        {
            updateViewport = true;
            updateProjection = true;
            updateView = true;
            System.Timers.Timer trigger = new System.Timers.Timer();
            trigger.Elapsed += new ElapsedEventHandler(UpdateViewport);
            int fps = 30;
            trigger.Interval = 1000 / fps;
            trigger.Start();
        }

        private void RenderViewport()
        {
            try
            {
                if (updateViewport)
                {
                    GL.Viewport(ClientRectangle.X, ClientRectangle.Y, ClientRectangle.Width, ClientRectangle.Height);
                    updateViewport = false;
                }
                if (updateProjection)
                {
                    projection = ViewportCam.GetProjection();
                    GL.MatrixMode(MatrixMode.Projection);
                    GL.LoadMatrix(ref projection);
                    updateProjection = false;
                }
                if (updateView)
                {
                    modelview = ViewportCam.GetView();
                    GL.MatrixMode(MatrixMode.Modelview);
                    GL.LoadMatrix(ref modelview);
                    updateView = false;
                }
                GL.ClearColor(this.BackColor);
                GL.ClearDepth(1);
                GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

                this.mObjectContainer.Update();

                this.SwapBuffers();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

       

        #region GLObject
        private void InitObject()
        {
            this.mObjectContainer = new EoContainer<GLObject>();
            this.mObjectContainer.eventUpdate += new EoDelegate.Void<GLObject>(UpdateObject);

            this.mGrid = new GLGrid();
            this.mObjectContainer.Add("Grid", this.mGrid);
        }
        private void UpdateObject(GLObject glObject)
        {
            if (glObject != null)
            {
                glObject.Update();
            }
        }
        #endregion

        #region GLCamera
        private void InitCamera()
        {
            this.mViewportCamera = new GLCamera();
            this.mViewportCamera.eventUpdateProjection += new EoDelegate.Void(UpdateProjection);
            this.mViewportCamera.eventUpdateView += new EoDelegate.Void(UpdateView);
            this.mObjectContainer.Add("ViewportCamera", this.mViewportCamera);
        }
        public void UpdateProjection()
        {
            updateProjection = true;
        }
        public void UpdateView()
        {
            updateView = true;
        }
        #endregion


        private void UpdateViewport(object sender, ElapsedEventArgs e)
        {
            this.Refresh();
        }

        private void GLViewport_Paint(object sender, PaintEventArgs e)
        {
            RenderViewport();
        }

        private void GLViewport_KeyDown(object sender, KeyEventArgs e)
        {
            //if (ViewportCam.CameraControl != null)
            //{
            //    ViewportCam.CameraControl.EventController.KeyDown(sender, e);
            //}
        }

        private void GLViewport_KeyUp(object sender, KeyEventArgs e)
        {
            //if (ViewportCam.CameraControl != null)
            //{
            //    ViewportCam.CameraControl.EventController.KeyUp(sender, e);
            //}
        }
    }
}
