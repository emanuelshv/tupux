using System;
using System.Collections.Generic;
using System.Text;

namespace TUPUX.ActiveRecord
{
    [Flags]
    public enum RecordState
    {
        Created = 1,
        Loaded = 2,
        Modified = 4,
        Deleted = 8
    }
}
