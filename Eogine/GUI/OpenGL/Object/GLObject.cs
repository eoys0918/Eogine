using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenTK;

namespace Eogine
{
    public abstract class GLObject
    {
        protected Vector3d location = Vector3d.Zero;
        protected Vector3d size = Vector3d.Zero;

        public GLObject()
        {
        }

        public void SetLocation(Vector3d loccation)
        {
            this.location = loccation;
        }
        public void SetLocation(double x, double y, double z = 0.0)
        {
            this.location.X = x;
            this.location.Y = y;
            this.location.Z = z;
        }

        public void SetSize(Vector3d size)
        {
            this.size = size;
        }
        public void SetSize(double x, double y, double z = 0.0)
        {
            this.size.X = x;
            this.size.Y = y;
            this.size.Z = z;
        }

        public abstract void UpdateFrame();
        public abstract void RenderFrame();

        public class Type
        {
            public class Polygon
            {
                public static readonly string Rect2D = "Rect2D";
            }
        }
    }
}
