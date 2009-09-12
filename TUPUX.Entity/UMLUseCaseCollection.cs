using System;
using System.Collections.Generic;
using System.Text;
using TUPUX.ActiveRecord;

namespace TUPUX.Entity
{
    /// <summary>
    /// Strongly-typed collection for the UseCase class.
    /// </summary>
    [Serializable]
    public class UMLUseCaseCollection : ActiveList<UMLUseCase, UMLUseCaseCollection>
    {
    }
}
