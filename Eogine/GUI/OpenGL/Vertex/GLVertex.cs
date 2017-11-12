using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Eogine
{
    public class GLVertex
    {


        public GLVertex(double x, double y, double z = 0.0)
        {
            SetLocation(x, y, z);
        }

        #region location
        private Vector3d vLocation = Vector3d.Zero;

        public void SetLocation(double x, double y, double z = 0.0)
        {
            vLocation.X = x;
            vLocation.Y = y;
            vLocation.Z = z;
        }
        #endregion


        #region texture
        private bool Texturable = false;
        private Vector2d vTexCood = Vector2d.Zero;

        public void SetTexCood(double u, double v)
        {
            Texturable = true;
            vTexCood.X = u;
            vTexCood.Y = v;
        }

        public void SetTexturable(bool render)
        {
            Texturable = render;
        }
        #endregion

        #region color
        private Color vColor;
        private bool Colorable = false;

        public void SetColor(Color color)
        {
            Colorable = true;
            vColor = color;
        }

        public void SetColorable(bool render)
        {
            Colorable = render;
        }
        #endregion
        
        public void Render(bool draw3D = true)
        {
            if (Colorable)
            {
                GL.Color4(Color.White);
            }
            if (Texturable)
            {
                GL.TexCoord2(vTexCood);
            }
            if (draw3D)
            {
                GL.Vertex3(vLocation);
            }
            else
            {
                GL.Vertex2(vLocation.X, vLocation.Y);
            }
        }
    }
}
