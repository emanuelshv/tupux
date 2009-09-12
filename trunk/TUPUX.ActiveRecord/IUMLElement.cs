using System;
using System.Collections.Generic;
using System.Text;

namespace TUPUX.ActiveRecord
{
    public interface IUMLElement
    {
        List<IUMLElement> GetOwnedElements();
        string Guid { get; }
        string Name { get; set; }
        string PathName { get; set; }
        string Stereotype { get; set; }
        string Documentation { get; set; }
        int Visibility { get; set; }
        RecordState State { get; }
        IUMLElement Owner { get; set; }

        void Load();
        void LoadCurrent();
        void Load(object key);
        void Load(StarUML.IUMLModelElement model);
        bool IsKindOf(string className, string stereotype, bool strictCompare);
        bool IsKindOf(string className, string stereotype);

        void MarkDeleted();
        void MarkCreated();
        void MarkLoaded();
        void MarkModified();
    }
}
