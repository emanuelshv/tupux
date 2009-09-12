using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using TUPUX.Entity;

namespace TUPUX.Estimation.RelationshipAnalyzer
{
    /*
    * Implements the Bridge Pattern along with AbstractClassesAnalyzer and
    * ConcreteClassesAnalyzer
    */
    interface IRelationshipAnalyzer
    {
        List<UMLFile> CreateFiles(IDictionary relationships);
    }
}
