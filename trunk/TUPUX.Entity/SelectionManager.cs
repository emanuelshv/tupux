using System;
using System.Collections.Generic;
using System.Text;
using TUPUX.ActiveRecord;
using System.Reflection;

namespace TUPUX.Entity
{
    public static class SelectionManager
    {

        public static IUMLElement GetCurrent()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            foreach (Type type in assembly.GetTypes())
            {
                if (!type.ContainsGenericParameters && !type.IsAbstract)
                {
                    ConstructorInfo consInfo = type.GetConstructor(Type.EmptyTypes);
                    if (consInfo != null)
                    {
                        object obj1 = Activator.CreateInstance(type);

                        if (obj1 is IUMLElement)
                        {
                            IUMLElement element = (IUMLElement)obj1;
                            element.LoadCurrent();
                            if (element.State == RecordState.Loaded)
                                return element;
                        }
                    }
                }
            }

            return null;
        }

    }
}
