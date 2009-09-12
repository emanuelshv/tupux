using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace TUPUX.Controls
{
    public class RemoveEventArgs<T> : CancelEventArgs
    {
        private T _item;

        public T Item
        {
            get { return _item; }
            set { _item = value; }
        }

        public RemoveEventArgs(bool cancel, T item)
            : base(cancel)
        {
            this.Item = item;
        }
    }

    public delegate void RemoveEventHandler<T>(object sender, RemoveEventArgs<T> e);
}
