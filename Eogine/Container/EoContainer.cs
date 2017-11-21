using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Eogine
{
    public class EoContainer<T>
    {
        private Hashtable mContainer = null;

        public EoContainer()
        {
            this.mContainer = new Hashtable();
        }

        public void Add(object key, T value)
        {
            if (this.mContainer.ContainsKey(key))
            {
                this.mContainer[key] = value;
            }
            else
            {
                this.mContainer.Add(key, value);
            }
        }

        public T Get(object key)
        {
            return (T)this.mContainer[key];
        }

        public bool ContainsKey(object key)
        {
            return this.mContainer.ContainsKey(key);
        }

        public event EoDelegate.Void<T> eventUpdate;
        public void Update()
        {
            if (eventUpdate != null)
            {
                foreach (DictionaryEntry entry in this.mContainer)
                {
                    eventUpdate((T)entry.Value);
                }
            }
        }
    }
}
