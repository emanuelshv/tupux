using System;
using System.Collections.Generic;
using System.Text;
using TUPUX.ActiveRecord;

namespace TUPUX.Entity
{
    /// <summary>
    /// Strongly-typed collection for the StepFlow class.
    /// </summary>
    [Serializable]
    public class UMLStepFlowCollection : ActiveList<UMLStepFlow, UMLStepFlowCollection>
    {
    }
}
