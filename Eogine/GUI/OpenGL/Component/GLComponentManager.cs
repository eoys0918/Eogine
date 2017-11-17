using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Eogine
{
    public class GLComponentManager
    {
        private Hashtable mComponents = null;

        public GLComponentManager()
        {
            mComponents = new Hashtable();
        }

        public void SetComponent(GLComponent component)
        {
            if (component != null)
            {
                if (mComponents.ContainsKey(component.ComponentType))
                {
                    this.mComponents[component.ComponentType] = component;
                }
                else
                {
                    this.mComponents.Add(component.ComponentType, component);
                }
            }
        }
        public GLComponent GetComponent(GLComponent.TYPE componentType)
        {
            return (GLComponent)this.mComponents[componentType];
        }

        public void UpdateComponents()
        {
            foreach (DictionaryEntry entry in mComponents)
            {
                GLComponent component = (GLComponent)entry.Value;
                component.Update();
            }
        }

        public void RemoveComponent(GLComponent.TYPE type)
        {
            if (mComponents.ContainsKey(type))
            {
                this.mComponents.Remove(type);
            }
        }
    }
}
