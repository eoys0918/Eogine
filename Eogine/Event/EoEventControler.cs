using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Eogine
{
    public class EoEventControler
    {
        #region Key 이벤트
        private Hashtable keySetting = null;
        private Hashtable keyEvents = null;

        public EoEventControler()
        {
            keySetting = new Hashtable();
            keyEvents = new Hashtable();
        }

        public void SetKey(object keyName, Keys keyValue)
        {
            if (keySetting.ContainsKey(keyName))
            {
                keySetting[keyName] = keyValue;
                keyEvents[keyName] = false;
            }
            else
            {
                keySetting.Add(keyName, keyValue);
                keyEvents.Add(keyName, false);
            }
        }
        public Keys GetKey(object keyName)
        {
            return (Keys)keySetting[keyName];
        }
        public void ResetKey()
        {
            keySetting.Clear();
            keyEvents.Clear();
        }

        public void KeyDown(object sender, KeyEventArgs e)
        {
            foreach (DictionaryEntry entry in keySetting)
            {
                Keys key = (Keys)entry.Value;
                if (e.KeyCode == key)
                {
                    keyEvents[entry.Key] = true;
                }
            }
        }
        public void KeyUp(object sender, KeyEventArgs e)
        {
            foreach (DictionaryEntry entry in keySetting)
            {
                Keys key = (Keys)entry.Value;
                if (e.KeyCode == key)
                {
                    keyEvents[entry.Key] = false;
                }
            }
        }

        public event EoDelegate.VoidObject updateKeyEvent;
        public void UpdateEvent()
        {
            foreach (DictionaryEntry entry in keyEvents)
            {
                bool keyEvent = (bool)entry.Value;
                if (keyEvent && updateKeyEvent != null)
                {
                    updateKeyEvent(entry.Key);
                }
            }
        }
        #endregion

        
    }
}
