using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eogine
{
    public abstract class GLEventControler
    {
        public enum TYPE
        {
            KEYBOARD,
            MOUSE,
        }

        private TYPE glControlType;

        public bool ControlEnabled { get; set; }

        public GLEventControler(TYPE type)
        {
            this.glControlType = type;
        }

        protected abstract void _Update();
        public void Update()
        {
            if(ControlEnabled)
            {
                _Update();
            }
        }
    }
}
