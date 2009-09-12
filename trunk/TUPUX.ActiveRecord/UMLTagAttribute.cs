using System;
using System.Collections.Generic;
using System.Text;

namespace TUPUX.ActiveRecord
{
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class UMLTagAttribute : Attribute
    {
        private string _tagDefinitionName;
        public string TagDefinitionName
        {
            get { return _tagDefinitionName; }
            set { _tagDefinitionName = value; }
        }

        private string _tagDefinitionSetName;
        public string TagDefinitionSetName
        {
            get { return _tagDefinitionSetName; }
            set { _tagDefinitionSetName = value; }
        }

        private string _profileName;
        public string ProfileName
        {
            get { return _profileName; }
            set { _profileName = value; }
        }

        public UMLTagAttribute(string profileName, string tagDefinitionSetName, string tagDefinitionName)
        {
            this.TagDefinitionName = tagDefinitionName;
            this.TagDefinitionSetName = tagDefinitionSetName;
            this.ProfileName = profileName;
        }
    }
}
