using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using TUPUX.Entity;
using TUPUX.ActiveRecord;

namespace TUPUX.Forms
{
    public class FormsFactory
    {
        private static Dictionary<string, Form> dictionary =  new Dictionary<string, Form>();

        public static FormEdit GetCurrent()
        {
            IUMLElement element = SelectionManager.GetCurrent();
            if (element == null) return null;
            return GetFormEdit(element);
        }

        public static FormEdit GetFormEdit(IUMLElement element)
        {
            element.Load();
            FormEdit form = null;

            if (dictionary.ContainsKey(element.Guid))
            {
                form = dictionary[element.Guid] as FormEdit;
            }
            else
	        {
                #region Create the form
                if (element is UMLUseCase)
                {
                    form = new UseCaseEdit(element as UMLUseCase);
                }
                else if (element is UMLFlow)
                {
                    form = new FlowEdit(element as UMLFlow);
                }
                else if (element is UMLIteration)
                {
                    form = new IterationEdit(element as UMLIteration);
                }
                else if (element is UMLPhase)
                {
                    form = new PhaseEdit(element as UMLPhase);
                }
                else if (element is UMLCollaboration)
                {
                    form = new CollaborationEdit(element as UMLCollaboration);
                }
                else if (element is UMLFile)
                {
                    form = new FileEdit(element as UMLFile);
                }
                #endregion

                #region Add to the dictionary
                if (form != null)
                {
                    if (String.IsNullOrEmpty(element.Guid))
                    {
                        dictionary.Add(Guid.NewGuid().ToString(), form);
                    }
                    else
                    {
                        dictionary.Add(element.Guid, form);
                    }
                }
                #endregion
	        }

            return form;
        }

        public static void Remove(IUMLElement element)
        {
            dictionary.Remove(element.Guid);
        }
    }
}
