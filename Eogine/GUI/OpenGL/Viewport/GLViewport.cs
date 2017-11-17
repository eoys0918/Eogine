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

        public GLViewport()
        {
            InitializeComponent();
        }

        private void GLViewport_Load(object sender, EventArgs e)
        {
            this.ObjectList.Add(this.Grid);
        }
        #region Grid(test)
        private GLGrid mGrid = null;
        public GLGrid Grid
        {
            get
            {
                if (this.mGrid == null)
                {
                    this.mGrid = new GLGrid();
                }
                return this.mGrid;
            }
        }
        #endregion

        #region 속성
        [Category("GLViewport"), Description("Background Color")]
        public Color BackgroundColor
        {
            get { return this.BackColor; }
            set
            {
                this.BackColor = value;
            }
        }
        #endregion

        #region Objects
        private List<GLObject> mObjList = null;
        [Category("GLViewport"), Description("Object List")]
        public List<GLObject> ObjectList
        {
            get
            {
                if (this.mObjList == null)
                {
                    this.mObjList = new List<GLObject>();
                }
                return this.mObjList;
            }
        }
        #endregion

        #region Cameras
        [Category("GLViewport"), Description("Camera List")]
        public List<GLCamera> Cameralist
        {
            get
            {
                if (this.mCamList == null)
                {
                    this.mCamList = new List<GLCamera>();
                }
                return this.mCamList;
            }
        }
        private List<GLCamera> mCamList = null;

        [Category("GLViewport"), Description("ViewportCam")]
        public GLCamera ViewportCam
        {
            get
            {
                if (this.mViewportCam == null)
                {
                    SetViewportCam(new GLCamera());
                }
                return this.mViewportCam;
            }
            set { SetViewportCam(value); }
        }
        private GLCamera mViewportCam = null;
        private void SetViewportCam(GLCamera camera)
        {
            this.mViewportCam = camera;
            this.mViewportCam.updateProjection += new EoDelegate.Void(UpdateProjection);
            this.mViewportCam.updateView += new EoDelegate.Void(UpdateView);
        }

        #endregion

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

        public void UpdateProjection()
        {
            updateProjection = true;
        }

        public void UpdateView()
        {
            updateView = true;
        }

        private void UpdateViewport(object sender, ElapsedEventArgs e)
        {
            ViewportCam.Update();
            foreach (GLObject obj in ObjectList)
            {
                obj.Update();
            }
            this.Refresh();
        }

        private bool updateViewport = false;
        private bool updateProjection = false;
        private bool updateView = false;
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
                    projection = mViewportCam.GetProjection();
                    GL.MatrixMode(MatrixMode.Projection);
                    GL.LoadMatrix(ref projection);
                    updateProjection = false;
                }
                if (updateView)
                {
                    modelview = mViewportCam.GetView();
                    GL.MatrixMode(MatrixMode.Modelview);
                    GL.LoadMatrix(ref modelview);
                    updateView = false;
                }
                GL.ClearColor(this.BackColor);
                GL.ClearDepth(1);
                GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
                foreach (GLObject obj in ObjectList)
                {
                    obj.Render();
                }
                this.SwapBuffers();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void GLViewport_Paint(object sender, PaintEventArgs e)
        {
            RenderViewport();
        }

        private void GLViewport_KeyDown(object sender, KeyEventArgs e)
        {
            if (ViewportCam.CameraControl != null)
            {
                ViewportCam.CameraControl.EventController.KeyDown(sender, e);
            }
        }

        private void GLViewport_KeyUp(object sender, KeyEventArgs e)
        {
            if (ViewportCam.CameraControl != null)
            {
                ViewportCam.CameraControl.EventController.KeyUp(sender, e);
            }
        }
    }
}
