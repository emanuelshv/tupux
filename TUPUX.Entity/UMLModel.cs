using System;
using System.Collections.Generic;
using System.Text;
using TUPUX.ActiveRecord;

namespace TUPUX.Entity
{
    /// <summary>
    /// This is an ActiveRecord class which wraps the Model.
    /// </summary>
    [Serializable]
    [UMLClass("UMLModel")]
    [UMLRelation(UMLRelationType.Owned, typeof(UMLUseCase), typeof(UMLPhase), typeof(UMLIteration), typeof(UMLFile), typeof(UMLModel), typeof(UMLPackage), typeof(UMLSubsystem))]
    public class UMLModel : ActiveRecord<UMLModel>
    {
        public UMLPackageCollection GetUMLPackages()
        {
            return this.GetOwnedElements<UMLPackage, UMLPackageCollection>();
        }

        public UMLModelCollection GetUMLModels()
        {
            return this.GetOwnedElements<UMLModel, UMLModelCollection>();
        }

        public UMLSubsystemCollection GetUMLSubsystems()
        {
            return this.GetOwnedElements<UMLSubsystem, UMLSubsystemCollection>();
        }
    }
}
