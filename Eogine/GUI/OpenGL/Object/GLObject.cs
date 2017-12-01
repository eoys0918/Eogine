using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Eogine
{
    public abstract class GLObject
    {
        public bool Enabled = true;
        public bool RenderEnabled = true;

        public Vector3 position = Vector3.Zero;
        public Vector3 target = Vector3.Zero;

        public Vector3 vDir;
        public Vector3 vRight;
        public Vector3 vUp;

        public Vector3 size = Vector3.Zero;

        protected EoContainer<GLObject> childs = null;
        protected EoContainer<GLComponent> components = null;
        protected EoContainer<GLControl> controls = null;

        public GLObject()
        {
            RenderType = PrimitiveType.Triangles;
            UpdateVector();
            components = new EoContainer<GLComponent>();
        }

        #region vector
        protected void UpdateVector()
        {
            this.vDir = this.target - this.position;
            this.vDir.Normalize();
            this.vRight = Vector3.Cross(Vector3.UnitY, this.vDir);
            this.vRight.Normalize();
            this.vUp = Vector3.Cross(this.vDir, this.vRight);
        }

        #endregion

        #region size
        public void SetSize(Vector3 size)
        {
            this.size = size;
        }
        public void SetSize(float x, float y, float z = 0.0f)
        {
            this.size.X = x;
            this.size.Y = y;
            this.size.Z = z;
        }
        #endregion

        #region Components
        
        #endregion

        #region render
        private int VBO = -1;
        private int IBO = -1;

        protected GLVertex[] verticies = null;

        protected uint[] indexes = null;
        protected GLTexture texture;
        protected PrimitiveType RenderType { get; set; }

        protected bool updateVertices = false;

        protected event EoDelegate.Void eventUpdateBeforeRender;
        protected event EoDelegate.Void eventUpdateAfterRender;
        public void Update()
        {
            if (this.Enabled)
            {
                if (eventUpdateBeforeRender != null)
                {
                    eventUpdateBeforeRender();
                }
                Render();
                if (eventUpdateAfterRender != null)
                {
                    eventUpdateAfterRender();
                }
            }
        }
        private void Render()
        {
            if (!this.RenderEnabled) return;
            try
            {
                if (updateVertices)
                {
                    if (VBO == -1) VBO = GL.GenBuffer();
                    if (IBO == -1) IBO = GL.GenBuffer();
                    GL.BindBuffer(BufferTarget.ArrayBuffer, VBO);
                    GL.BufferData<GLVertex>(BufferTarget.ArrayBuffer, (IntPtr)(GLVertex.SizeInBytes * verticies.Length), verticies, BufferUsageHint.StaticDraw);
                    GL.BindBuffer(BufferTarget.ElementArrayBuffer, IBO);
                    GL.BufferData<uint>(BufferTarget.ElementArrayBuffer, (IntPtr)(sizeof(uint) * indexes.Length), indexes, BufferUsageHint.StaticDraw);
                    updateVertices = false;
                }

                if (texture != null)
                {
                    texture.Bind();
                }

                GL.EnableClientState(ArrayCap.VertexArray);
                GL.EnableClientState(ArrayCap.TextureCoordArray);
                GL.EnableClientState(ArrayCap.ColorArray);
                GL.EnableClientState(ArrayCap.IndexArray);

                GL.VertexPointer(3, VertexPointerType.Float, GLVertex.SizeInBytes, IntPtr.Zero);
                GL.TexCoordPointer(2, TexCoordPointerType.Float, GLVertex.SizeInBytes, Vector3.SizeInBytes);
                GL.ColorPointer(4, ColorPointerType.Float, GLVertex.SizeInBytes, Vector3.SizeInBytes + Vector2.SizeInBytes);

                GL.BindBuffer(BufferTarget.ArrayBuffer, VBO);
                GL.BindBuffer(BufferTarget.ElementArrayBuffer, IBO);

                GL.DrawElements(RenderType, indexes.Length, DrawElementsType.UnsignedInt, 0);
            }
            catch (System.Exception ex)
            {

            }
        }
        #endregion
    }
}
