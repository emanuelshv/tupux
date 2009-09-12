using System;
using System.Collections.Generic;
using System.Text;
using TUPUX.ActiveRecord;

namespace TUPUX.Entity
{
    /// <summary>
    /// This is an ActiveRecord class which wraps the Project.
    /// </summary>
    [Serializable]
    [UMLClass("UMLProject")]
    [UMLRelation(UMLRelationType.Owned, typeof(UMLModel), typeof(UMLPackage), typeof(UMLSubsystem))]
    public class UMLProject : ActiveRecord<UMLProject>
    {
        private string _title;
        [UMLProperty("Title")]
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        private static UMLProject _project;

        public static UMLProject GetInstance()
        {
            if (_project == null)
                _project = Helper.GetProject<UMLProject>(); ;
            return _project;
        }

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

        public UMLFileCollection GetUMLFiles()
        {
            return this.GetOwnedElementsByKeyRecursive<UMLFile, UMLFileCollection>(this.GetKey().ToString());
        }

        public UMLPhaseCollection GetUMLPhases()
        {
            return this.GetOwnedElementsByKeyRecursive<UMLPhase, UMLPhaseCollection>(this.GetKey().ToString());
        }

        public ListType GetUMLElements<ItemType, ListType>()
            where ItemType : ActiveRecord<ItemType>, new()
            where ListType : ActiveList<ItemType, ListType>, new()
        {
            return this.GetOwnedElementsByKeyRecursive<ItemType, ListType>(this.GetKey().ToString());
        }

        public UMLClassCollection GetUMLClasses()
        {
            return this.GetOwnedElementsByKeyRecursive<UMLClass, UMLClassCollection>(this.GetKey().ToString());
        }
    }
}
