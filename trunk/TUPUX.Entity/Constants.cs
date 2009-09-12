using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace TUPUX.Entity.Constants
{
    public static class Specification
    {
        public const string PROFILE = "PES";
        public const string TDS_USECASE = "Specification - UseCase";
        public const string TDS_FLOW = "Specification - Flow";
        public const string TDS_STEPFLOW = "Specification - StepFlow";
    }

    public static class UMLUseCase
    {
        public const string CLASS = "UMLUseCase";
        public const string STEREOTYPE = "";
        public const string TDS_ESTIMATION = "Use Case Estimation Values";
    }

    public static class UMLBasicFlow
    {
        public const string CLASS = "UMLClass";
        public const string STEREOTYPE = "Basic Flow";
    }

    public static class UMLAlternativeFlow
    {
        public const string CLASS = "UMLClass";
        public const string STEREOTYPE = "Alternative Flow";
    }

    public static class UMLExceptionalFlow
    {
        public const string CLASS = "UMLClass";
        public const string STEREOTYPE = "Exceptional Flow";
    }

    public static class UMLFlow
    {
        public const string CLASS = "UMLClass";
        public const string STEREOTYPE = "Flow";
        //public const string STEREOTYPE_BASIC = "Basic Flow";
        //public const string STEREOTYPE_ALTERNATIVE = "Alternative Flow";
        //public const string STEREOTYPE_EXCEPTIONAL = "Exceptional Flow";
    }

    public static class UMLRequeriment
    {
        public const string CLASS = "UMLClass";
        public const string STEREOTYPE = "Requeriment";
    }

    public static class UMLStepFlow
    {
        public const string CLASS = "UMLAttribute";
        public const string STEREOTYPE = "Step";
    }


    public static class UMLAttribute
    {
        public const string CLASS = "UMLAttribute";        
    }

    public static class UMLMethod
    {
        public const string CLASS = "UMLOperation";
    }

    public static class UMLParameter
    {
        public const string CLASS = "UMLParameter";
    }    
    
    public static class UMLFile
    {
        public const string CLASS = "UMLClass";
        public const string STEREOTYPE = "File";
        public const string TDS_ESTIMATION = "File";
        public const string STEREOTYPEDEPENDENCYFILE = "DependencyFile";
    }

    public static class UMLPhase
    {
        public const string CLASS = "UMLPackage";
        public const string STEREOTYPE = "Phase";
        public const string TDS_ESTIMATION = "Phase Estimation Values";
    }

    public static class UMLIteration
    {
        public const string CLASS = "UMLClass";
        public const string STEREOTYPE = "Iteration";
        public const string TDS_ESTIMATION = "Iteration Estimation Values";
        public const string TDS_FATORS = "Factors";
        public const string TDS_HISTORYVALUES = "Previus Values";
        public const string STEREOTYPEITERATIONPRECEDENCE = "IterationPrecedence";
    }


    public static class UMLCollaboration
    {
        public const string CLASS = "UMLCollaboration";
        public const string TDS_ESTIMATION = "Collaboration Action";
    }

    public class UMLProfile
    {
        public const string ESTIMATION = "Estimation";
        public const string FILE = "File";
    }

    public class UMLClass
    {
        public const string CLASS = "UMLClass";        
    }

    public class UMLEnumeration
    {
        public const string CLASS = "UMLEnumeration";
    }

    public class UMLEnumerationLiteral
    {
        public const string CLASS = "UMLEnumerationLiteral";
    }

    public class UMLInterface
    {
        public const string CLASS = "UMLInterface";
    }

    public static class AppPath
    { 
        private static string _path = "";
        public static string Path
        {
            get
            {
                if (String.IsNullOrEmpty(_path))
                {
                    _path = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                }

                return _path;
            }
        }
    }

    public static class Visibility
    {
        public const int Public = 0;
        public const int Protected = 1;
        public const int Private = 2;
        public const int Package = 3;
    }

    public static class Direction
    {
        public const int IN = 0;
        public const int INOUT = 1;
        public const int OUT = 2;
        public const int RETURN = 3;
    }

    public static class UMLAssociation
    {
        public const string PROFILE = "File";
        public const string TDS_DEPENDENCY = "Dependency";
    }
}
