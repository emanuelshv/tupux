using System;
using System.Collections.Generic;
using System.Text;
using log4net;

namespace TUPUX.Access
{

    /// <summary>
    /// This class provide the access to the object COM from StarUML
    /// </summary>
    public class DataAccess
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(DataAccess));

        private StarUML.StarUMLApplicationClass app = new StarUML.StarUMLApplicationClass();

        /// <summary>
        /// Gets a StarUML element using GUID
        /// </summary>
        /// <param name="guid">Element Key</param>
        /// <returns>Element found</returns>
        public StarUML.IUMLModelElement FindModel(string guid)
        {
            //return app.FindByPathname(pathname) as StarUML.IUMLModelElement;
            try
            {
                return app.MetaModel.FindInstanceByGuid(guid) as StarUML.IUMLModelElement;
            }
            catch (Exception ex)
            {
                log.Error("", ex);
            }

            return null;
        }

        public StarUML.IUMLModelElement FindModelByPathName(string pathName)
        {
            //return app.FindByPathname(pathname) as StarUML.IUMLModelElement;
            try
            {
                return app.FindByPathname(pathName) as StarUML.IUMLModelElement;
            }
            catch (Exception ex)
            {
                log.Error("", ex);
            }

            return null;
        }

        public StarUML.IUMLFactory Factory
        {
            get
            {
                try
                {
                    return app.UMLFactory;
                }
                catch (Exception ex)
                {
                    log.Error("", ex);
                }

                return null;
            }
        }

        /// <summary>
        /// Includes a profile in the StarUML application
        /// </summary>
        /// <param name="name">Profile name</param>
        public void IncludeProfile(string name)
        {
            try
            {
                app.ExtensionManager.IncludeProfile(name);
            }
            catch (Exception ex)
            {
                log.Error("", ex);
            }
        }

        /// <summary>
        /// Excludes a profile from the StarUML application
        /// </summary>
        /// <param name="name">Profile Name</param>
        public void ExcludeProfile(string name)
        {
            try
            {
                app.ExtensionManager.ExcludeProfile(name);
            }
            catch (Exception ex)
            {
                log.Error("", ex);
            }
        }


        public void BeginUpdate()
        {
            try
            {
                app.BeginUpdate();

            }
            catch (Exception ex)
            {
                log.Error("", ex);
            }
        }

        public void EndUpdate()
        {
            try
            {
                app.EndUpdate2(true, true);
            }
            catch (Exception ex)
            {
                log.Error("", ex);
            }
        }

        

        /// <summary>
        /// Gets the current project
        /// </summary>
        /// <returns>Current project open</returns>
        public StarUML.IUMLProject GetCurrentProject()
        {
            try
            {
                return app.GetProject();
            }
            catch (Exception ex)
            {
                log.Error("", ex);
            }

            return null;
        }

        /// <summary>
        /// Opens a project
        /// </summary>
        /// <param name="name">Project name</param>
        public void OpenProject(string name)
        {
            try
            {
                app.ProjectManager.CloseProject();
                app.ProjectManager.OpenProject(name);
            }
            catch (Exception ex)
            {
                log.Error("", ex);
            }
        }

        /// <summary>
        /// Imports a model fragment in a determined package
        /// </summary>
        /// <param name="name">File Name (ModelFragment)</param>
        /// <param name="pac">Package owner to Model Fragment</param>
        /// <param name="diagramName">Diagram name included in the ModelFragment</param>
        /// <returns></returns>
        public StarUML.IDiagram ImportModelFragment(string name, StarUML.IUMLPackage pac, string diagramName)
        {
            StarUML.IUMLPackage model = null;
            StarUML.IDiagram diagram = null;            
            try
            {
                app.ProjectManager.ImportModelFragment(pac, name);
                model = pac.FindByName("Autogenerate") as StarUML.IUMLPackage;
                if (model != null)
                {
                    diagram = model.FindByName(diagramName) as StarUML.IDiagram;
                }

            }
            catch (Exception ex)
            {
                log.Error("", ex);
            }            

            return diagram;
        }

        /// <summary>
        /// Delete Model using GUID
        /// </summary>
        /// <param name="guid">Element Key</param>
        public void DeleteModel(string guid)
        {
            try
            {
                StarUML.IElement element = app.MetaModel.FindInstanceByGuid(guid);
                StarUML.IModel model = element as StarUML.IModel;
                if (model != null) app.DeleteModel(model);
            }
            catch (Exception ex)
            {
                log.Error("", ex);
            }
        }

        /// <summary>
        /// Gets a default file in the project, if this element doesn't exist, this element will be created
        /// </summary>
        /// <param name="key">Element key for the model</param>
        /// <returns>Defaul file element</returns>
        public StarUML.IUMLClass GetAuxFile(string key)
        {
            //StarUML.IUMLNamespace model = ((StarUML.IUMLCollaboration)FindModel(key)).RepresentedClassifier.Namespace;
            StarUML.IUMLNamespace model = ((StarUML.IUMLCollaboration)FindModel(key));
            StarUML.IUMLClass e = null;

            if (model != null)
            {
                try
                {
                    e = (StarUML.IUMLClass)model.FindByName("DETAUX");
                    if (e == null)
                    {
                        e = app.UMLFactory.CreateClass(model);
                        e.Name = "DETAUX";
                        e.SetStereotype("File");
                    }

                }
                catch (Exception ex)
                {
                    log.Error("", ex);
                }
            }

            return e;

        }

        /// <summary>
        /// Gets the selected element in the StarUML application
        /// </summary>
        /// <returns>Current Element Selected</returns>
        public StarUML.IUMLModelElement GetCurrentModel()
        {
            try
            {
                return (StarUML.IUMLModelElement)app.SelectionManager.GetSelectedModelAt(0);
            }
            catch
            {
                return null;
            }
        }

        public StarUML.IUMLUseCase InsertUseCase(StarUML.IUMLClassifier owner, String useCaseName)
        {
            {
                StarUML.IUMLUseCase model = app.UMLFactory.CreateUseCase(owner);
                if (!String.IsNullOrEmpty(useCaseName))
                    model.Name = useCaseName;

                return model;
            }
        }

        #region Function GetModelElements

        public List<StarUML.IUMLModelElement> GetModelElements(StarUML.IUMLClassifier root)
        {
            List<StarUML.IUMLModelElement> list = new List<StarUML.IUMLModelElement>();

            for (int i = 0; i < root.GetOwnedElementCount(); i++)
            {
                StarUML.IUMLModelElement model = root.GetOwnedElementAt(i);
                list.Add(model);
            }
            return list;
        }

        public List<StarUML.IUMLModelElement> GetModelElements(StarUML.IUMLClassifier root, params Type[] types)
        {
            List<StarUML.IUMLModelElement> list = new List<StarUML.IUMLModelElement>();

            for (int i = 0; i < root.GetOwnedElementCount(); i++)
            {
                StarUML.IUMLModelElement model = root.GetOwnedElementAt(i);

                foreach (Type type in types)
                {
                    if (model.GetType() == type)
                    {
                        list.Add(model);
                    }
                }
            }
            return list;
        }

        public List<StarUML.IUMLModelElement> GetModelElements(StarUML.IUMLClassifier root, String stereotype, Type type)
        {
            List<StarUML.IUMLModelElement> list = new List<StarUML.IUMLModelElement>();

            for (int i = 0; i < root.GetOwnedElementCount(); i++)
            {
                StarUML.IUMLModelElement model = root.GetOwnedElementAt(i);

                if ((model.GetType() == type) && (model.StereotypeName.Equals(stereotype)))
                {
                    list.Add(model);
                }
            }
            return list;
        }

        public List<StarUML.IUMLModelElement> GetModelElements(StarUML.IUMLClassifier root, String stereotype, params Type[] types)
        {
            List<StarUML.IUMLModelElement> list = new List<StarUML.IUMLModelElement>();

            for (int i = 0; i < root.GetOwnedElementCount(); i++)
            {
                StarUML.IUMLModelElement model = root.GetOwnedElementAt(i);

                foreach (Type type in types)
                {
                    if ((model.GetType() == type) && (model.StereotypeName.Equals(stereotype)))
                    {
                        list.Add(model);
                    }
                }
            }
            return list;
        }
        #endregion
    }
}
