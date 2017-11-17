using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Eogine
{
    public struct GLVertex
    {
        public Vector3 position;
        public Vector2 texCoord;
        public Vector4 color;

        public GLVertex(Vector3 position, Vector2 texCoord, Vector4 color)
        {
            this.position = position;
            this.texCoord = texCoord;
            this.color = color;
        }

        public GLVertex(Vector3 position, Vector2 texCoord, Color color)
        {
            this.position = position;
            this.texCoord = texCoord;
            this.color = new Vector4(color.R / 255.0f, color.G / 255.0f, color.B / 255.0f, color.A / 255.0f);
        }

        public Color Color
        {
            get
            {
                return Color.FromArgb((int)(color.W * 255), (int)(color.X * 255), (int)(color.Y * 255), (int)(color.Z * 255));
            }
            set
            {
                this.color = new Vector4(value.R / 255.0f, value.G / 255.0f, value.B / 255.0f, value.A / 255.0f);
            }
        }

        public static int SizeInBytes = Vector3.SizeInBytes + Vector2.SizeInBytes + Vector4.SizeInBytes;
    }
}
