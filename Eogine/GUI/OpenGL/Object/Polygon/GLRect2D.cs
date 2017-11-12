using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using OpenTK.Graphics.OpenGL;


namespace Eogine
{
    public class GLRect2D : GLObject
    {
        private GLVertex[] vertices;

        public GLRect2D()
        {
            vertices = new GLVertex[4];
        }

        private void Init()
        {

        }

        public override void UpdateFrame()
        {

        }

        public override void RenderFrame()
        {
            try
            {
                GL.Begin(PrimitiveType.Polygon);
                foreach (GLVertex v in vertices)
                {
                    v.Render(false);
                }
                GL.End();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
