using System;
using System.Collections.Generic;
using System.Text;
using TUPUX.ActiveRecord;

namespace TUPUX.Entity
{
    /// <summary>
    /// Strongly-typed collection for the Requeriment class.
    /// </summary>
    [Serializable]
    public class UMLRequerimentCollection : ActiveList<UMLRequeriment, UMLRequerimentCollection>
    {
    }
}
