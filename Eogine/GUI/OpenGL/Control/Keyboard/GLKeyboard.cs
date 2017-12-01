using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eogine
{
    public class GLKeyboard : GLEventControler
    {
        public GLKeyboard()
            : base(GLEventControler.TYPE.KEYBOARD)
        {

        }

        protected override void _Update()
        {
        }
    }
}
