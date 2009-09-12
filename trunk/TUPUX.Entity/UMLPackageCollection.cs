using System;
using System.Collections.Generic;
using System.Text;
using TUPUX.ActiveRecord;

namespace TUPUX.Entity
{
    /// <summary>
    /// Strongly-typed collection for the Package class.
    /// </summary>
    [Serializable]
    public class UMLPackageCollection : ActiveList<UMLPackage, UMLPackageCollection>
    {
    }
}
