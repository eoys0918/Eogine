using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Eogine
{
    public class EoKeyEvent
    {
        public EoContainer<bool> SettingKey = null;

        private event EoDelegate.VoidKeyEvent eventKeyUp;
        private event EoDelegate.VoidKeyEvent eventKeyDown;
        private event EoDelegate.VoidKeyEvent eventKeyPress;
        private event EoDelegate.VoidKeyEvent eventPreviewKeyDown;

        public EoKeyEvent()
        {
            this.SettingKey = new EoContainer<bool>();
        }
        
        public void KeyUp(object sender, KeyEventArgs e)
        {
            if(eventKeyUp != null)
            {
                eventKeyUp(sender, e);
            }
        }
        public void KeyDown(object sender, KeyEventArgs e)
        {
            if (eventKeyDown != null)
            {
                eventKeyDown(sender, e);
            }
        }
        public void KeyPress(object sender, KeyEventArgs e)
        {
            if (eventKeyPress != null)
            {
                eventKeyPress(sender, e);
            }
        }
        public void PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (eventPreviewKeyDown != null)
            {
                eventPreviewKeyDown(sender, e);
            }
        }

        public void Update()
        {

        }
    }
}
