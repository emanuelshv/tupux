using System;
using System.Collections.Generic;
using System.Text;
using TUPUX.ActiveRecord;

namespace TUPUX.Entity
{
    /// <summary>
    /// Strongly-typed collection for the Model class.
    /// </summary>
    [Serializable]
    public class UMLModelCollection : ActiveList<UMLModel, UMLModelCollection>
    {
    }
}
