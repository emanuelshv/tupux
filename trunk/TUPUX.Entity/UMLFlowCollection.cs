using System;
using System.Collections.Generic;
using System.Text;
using TUPUX.ActiveRecord;

namespace TUPUX.Entity
{
    /// <summary>
    /// Strongly-typed collection for the Flow class.
    /// </summary>
    [Serializable]
    public class UMLFlowCollection : ActiveList<UMLFlow, UMLFlowCollection>
    {
    }
}
