using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenTK;
using System.Windows.Forms;
using System.Collections;

namespace Eogine
{
    public class GLCamera : GLObject
    {
        /// <summary>
        /// 시야각
        /// </summary>
        private float fovy = MathHelper.PiOver4;
        /// <summary>
        /// 종횡비
        /// </summary>
        private float aspect = 1.0f;
        /// <summary>
        /// near
        /// </summary>
        private float zNear = 0.0001f;
        /// <summary>
        /// far
        /// </summary>
        private float zFar = 1000.0f;

        public GLCamera()
        {
            this.renderEnable = false;
        }
        
        #region Projection
        public Matrix4 GetProjection()
        {
            return Matrix4.CreatePerspectiveFieldOfView(this.fovy, this.aspect, this.zNear, this.zFar);
        }
        public void SetProjection(float fovy, float aspect, float zNear, float zFar)
        {
            this.fovy = fovy;
            this.aspect = aspect;
            this.zNear = zNear;
            this.zFar = zFar;
        }
        public void SetFovY(float degree)
        {
            this.fovy = MathHelper.DegreesToRadians(degree);
        }

        public void SetAspect(float width, float height)
        {
            this.aspect = width / height;
        }

        public void SetAspect(int width, int height)
        {
            SetAspect((float)width, (float)height);
        }

        public void SetNear(float near)
        {
            this.zNear = near;
        }

        public void SetFar(float far)
        {
            this.zFar = far;
        }

        public event EoDelegate.Void eventUpdateProjection;
        private void UpdateProjection()
        {
            if (eventUpdateProjection != null)
            {
                eventUpdateProjection();
            }
        }
        #endregion

        #region View
        public Matrix4 GetView()
        {
            UpdateVector();
            return Matrix4.LookAt(this.position, this.target, this.vUp);
        }

        public event EoDelegate.Void eventUpdateView;
        private void UpdateView()
        {
            if (eventUpdateView != null)
            {
                eventUpdateView();
            }
        }
        #endregion
    }
}
