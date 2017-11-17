using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eogine
{
    public abstract class GLComponent
    {
        protected GLObject glObject = null;

        public enum TYPE
        {
            MOVE_CONTROL,
            COMPONENT
        }
        private GLComponent.TYPE mComponentType = TYPE.COMPONENT;
        public GLComponent.TYPE ComponentType { get { return this.mComponentType; } }

        private EoEventControler mEventController = null;
        public EoEventControler EventController 
        {
            get 
            {
                if (this.mEventController == null)
                {
                    this.mEventController = new EoEventControler();
                }
                return this.mEventController; 
            } 
        }

        public GLComponent(TYPE type, GLObject glObject)
        {
            this.glObject = glObject;
            this.mComponentType = type;
        }

        public event EoDelegate.Void eventBeforeUpdate;
        public event EoDelegate.Void eventAfterUpdate;
        public void Update()
        {
            if (eventBeforeUpdate != null)
            {
                eventBeforeUpdate();
            }
            if (mEventController != null)
            {
                mEventController.UpdateEvent();
            }
            if (eventAfterUpdate != null)
            {
                eventAfterUpdate();
            }
        }
    }
}
