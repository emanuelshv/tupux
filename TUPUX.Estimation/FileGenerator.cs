using System;
using System.Collections.Generic;
using System.Text;
using TUPUX.Entity;
using TUPUX.ActiveRecord;
using TUPUX.Estimation.RelationshipAnalyzer;
using System.Collections;

namespace TUPUX.Estimation
{
    public class FileGenerator
    {
        //CONSTANTS
        #region Constants
        public const string DEFAULTPACKAGENAME = "_Auto Generated Files";
        public const string DEFAULTPACKAGEROOT = "Analysis Model";
        public const string DEFAULTACTIONFILEPATH = "DFPRules.cfg";
        #endregion

        //ATTRIBUTES
        #region Attributes
        private IRelationshipAnalyzer analyzer;
        private string _packageRoot;
        private string _packageName;
        #endregion

        //CONSTRUCTORS
        #region Constructors

        public FileGenerator()
        {
            this._packageName = FileGenerator.DEFAULTPACKAGENAME;
            this._packageRoot = FileGenerator.DEFAULTPACKAGEROOT;
            this.analyzer = new DefaultRelationshipAnalyzer(FileGenerator.DEFAULTACTIONFILEPATH);
        }

        public FileGenerator(string packageName, string packageRoot)
        {
            this._packageName = packageName;
            this._packageRoot = packageRoot;
            this.analyzer = new DefaultRelationshipAnalyzer(FileGenerator.DEFAULTACTIONFILEPATH);
        }

        public FileGenerator(string packageName, string packageRoot, string actionfilepath)
        {
            this._packageName = packageName;
            this._packageRoot = packageRoot;
            this.analyzer = new DefaultRelationshipAnalyzer(actionfilepath);
        }
        #endregion

        //PROPERTIES
        #region Properties

        public string PackageRoot
        {
            get
            {
                if (this._packageRoot == null)
                {
                    this._packageRoot = FileGenerator.DEFAULTPACKAGEROOT;
                }
                return this._packageRoot;
            }
            set { this._packageRoot = value; }
        }

        public string PackageName
        {
            get
            {
                if (this._packageName == null)
                {
                    this._packageName = FileGenerator.DEFAULTPACKAGENAME;
                }
                return this._packageName;
            }
            set { this._packageName = value; }
        }

        #endregion

        //METHODS
        #region Methods

        /*
         * This method has the responsbility of ensuring that all the file generation is completed
         * successfully.
         */
        public void CreateFiles(object observer)
        {
            List<UMLFile> files;
            List<IUMLElement> rootItems;
            UMLPackage package;
            bool obsValid = false;

            if (observer != null) 
            {
                if (observer is IGenerationStageObserver)
                {
                    obsValid = true;
                }
            }

            //1. Setup the environment
            UMLModelCollection models = UMLProject.GetInstance().GetUMLModels();

            //find if package-root already exists
            UMLModel pkgRoot = models.Find(FindPackageRoot);
            if (pkgRoot == null)
            {
                pkgRoot = new UMLModel();
                pkgRoot.Name = this._packageRoot;
                pkgRoot.Owner = UMLProject.GetInstance();  
                pkgRoot.Save();
            }

            //find if package already exists
            rootItems = pkgRoot.GetOwnedElements();
            package = (UMLPackage)(rootItems.Find(FindPackage));
            if (package != null)
            {
                package.Delete();
            }
            package = new UMLPackage();
            package.Owner = pkgRoot;
            package.Name = this._packageName;
            package.Save();

            if (obsValid == true)
            {
                ((IGenerationStageObserver)observer).setStage(1);
            }

            //2. Analyze the model
            UMLClassCollection classes = UMLProject.GetInstance().GetUMLClasses();
            IDictionary relationships = HelperRelationships.GetRelationships((UMLClassCollection)classes);
            files = analyzer.CreateFiles(relationships);

            if (obsValid == true)
            {
                ((IGenerationStageObserver)observer).setStage(2);
            }


            //3. Save the files to StarUML
            foreach (UMLFile file in files)
            {
                file.Owner = package;
                file.Stereotype = TUPUX.Entity.Constants.UMLFile.STEREOTYPE;
                file.Save();
                foreach (UMLAttribute a in file.Attributes)
                {
                    a.Owner = file;
                    a.Save();
                }
            }

            if (obsValid == true)
            {
                ((IGenerationStageObserver)observer).setStage(3);
            }

        }

        private bool FindPackageRoot(UMLModel model)
        {
            if (model.Name == this._packageRoot)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private bool FindPackage(IUMLElement package)
        {
            if (package.Name.Equals(this._packageName) && package is UMLPackage)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool RemoveFiles(IUMLElement element)
        {
            if (element is UMLFile)
            {
                (element as UMLFile).Delete();

                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion
    }
}
