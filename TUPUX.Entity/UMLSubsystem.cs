using System;
using System.Collections.Generic;
using System.Text;
using TUPUX.ActiveRecord;

namespace TUPUX.Entity
{
    /// <summary>
    /// This is an ActiveRecord class which wraps the Subsystem.
    /// </summary>
    [Serializable]
    [UMLClass("UMLSubsystem")]
    [UMLRelation(UMLRelationType.Owned, typeof(UMLUseCase), typeof(UMLPhase), typeof(UMLIteration), typeof(UMLFile), typeof(UMLModel), typeof(UMLPackage), typeof(UMLSubsystem))]
    public class UMLSubsystem : ActiveRecord<UMLSubsystem>
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
