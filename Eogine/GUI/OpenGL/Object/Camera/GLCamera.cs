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
        private bool mControlEnable = false;
        public bool ControlEnable
        {
            get
            {
                return this.mControlEnable;
            }
            set
            {
                if(this.mControlEnable = value)
                {
                    if (CameraControl == null)
                    {
                        GLComponents.SetComponent(new GLMoveControl(this));
                        CameraControl.eventAfterUpdate += new EoDelegate.Void(UpdateView);
                    }
                    else
                    {
                        GLComponents.RemoveComponent(GLComponent.TYPE.MOVE_CONTROL);
                    }
                       
                }
            }
        }
        public GLComponent CameraControl
        {
            get { return GLComponents.GetComponent(GLComponent.TYPE.MOVE_CONTROL); }
        }

        public GLCamera()
        {
            InitCamera();
            
        }

        private void InitCamera()
        {
            InitProjection();
            
        }

        #region View
        public Matrix4 GetView()
        {
            UpdateVector();
            return Matrix4.LookAt(this.position, this.target, this.vUp);
        }
        public event EoDelegate.Void updateView;
        private void UpdateView()
        {
            if(updateView != null)
            {
                updateView();
            }
        }
        
        #endregion

        #region Projection       

        /// <summary>
        /// 시야각
        /// </summary>
        private float fovy;
        /// <summary>
        /// 종횡비
        /// </summary>
        private float aspect;
        /// <summary>
        /// near
        /// </summary>
        private float zNear;
        /// <summary>
        /// far
        /// </summary>
        private float zFar;

        private void InitProjection()
        {
            this.fovy = MathHelper.PiOver4;
            this.aspect = 1.0f;
            this.zNear = 0.0001f;
            this.zFar = 1000.0f;
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

        public Matrix4 GetProjection()
        {
            return Matrix4.CreatePerspectiveFieldOfView(this.fovy, this.aspect, this.zNear, this.zFar);
        }

        public event EoDelegate.Void updateProjection;
        private void UpdateProjection()
        {
            if(updateProjection != null)
            {
                updateProjection();
            }
        }

        #endregion
    }
}
