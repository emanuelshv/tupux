using System;
using System.Collections.Generic;
using System.Text;

namespace TUPUX.Entity
{
    public class AbstractModel
    {
        private string _guid;
        public string Guid
        {
            get { return _guid; }
            set { _guid = value; }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _pathName;
        public string PathName
        {
            get { return _pathName; }
            set { _pathName = value; }
        }
    }
}
