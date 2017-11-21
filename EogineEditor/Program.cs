using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Eogine;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace EogineEditor
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            //using (Game game = new Game())
            //{
            //    game.Run(30.0);
            //}

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (ProcessChecker.IsOnlyProcess(Application.ProductName))
            {
                Application.Run(new MainForm());
            }
        }

        //class Game : GameWindow
        //{
        //    private GLCamera mViewportCam = null;
        //    private GLGrid grid = null;

        //    public Game()
        //        : base(800, 600, GraphicsMode.Default, "OpenTK Quick Start Sample")
        //    {
        //        VSync = VSyncMode.On;
        //    }

        //    protected override void OnLoad(EventArgs e)
        //    {
        //        base.OnLoad(e);

        //        GL.ClearColor(0.1f, 0.2f, 0.5f, 0.0f);
        //        GL.Enable(EnableCap.DepthTest);

        //        this.mViewportCam = new GLCamera();
        //        GL.Viewport(ClientRectangle.X, ClientRectangle.Y, ClientRectangle.Width, ClientRectangle.Height);

        //        grid = new GLGrid();
        //    }

        //    protected override void OnResize(EventArgs e)
        //    {
        //        base.OnResize(e);
        //    }

        //    protected override void OnUpdateFrame(FrameEventArgs e)
        //    {
        //        base.OnUpdateFrame(e);

        //    }

        //    protected override void OnRenderFrame(FrameEventArgs e)
        //    {
        //        base.OnRenderFrame(e);

        //        GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

        //        Matrix4 projection = mViewportCam.GetProjection();
        //        GL.MatrixMode(MatrixMode.Projection);
        //        GL.LoadMatrix(ref projection);

        //        Matrix4 modelview = mViewportCam.GetView();
        //        GL.MatrixMode(MatrixMode.Modelview);
        //        GL.LoadMatrix(ref modelview);

        //        grid.Render();


        //        SwapBuffers();
        //    }
        //}
    }
}
