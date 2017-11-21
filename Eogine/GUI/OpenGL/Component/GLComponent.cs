using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eogine
{
    public abstract class GLComponent
    {   
        public enum TYPE
        {
            MOVE,
        }
        private GLComponent.TYPE mComponentType;
        public GLComponent.TYPE ComponentType { get { return this.mComponentType; } }

        protected GLObject glObject = null;

        private bool isUpdate = false;
        
        public GLComponent(TYPE type, GLObject glObject)
        {
            this.mComponentType = type;
            this.glObject = glObject;
        }

        public event EoDelegate.Void eventBeforeUpdate;
        public event EoDelegate.Void eventAfterUpdate;
        protected abstract void _Update();
        public void Update()
        {
            if (this.isUpdate)
            {
                if (eventBeforeUpdate != null)
                {
                    eventBeforeUpdate();
                }
                _Update();
                if (eventAfterUpdate != null)
                {
                    eventAfterUpdate();
                }
            }
            
        }

        public void Start()
        {
            this.isUpdate = true;
        }

        public void Stop()
        {
            this.isUpdate = false;
        }
    }
}
