using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace TUPUX.Estimation.Action
{
    public abstract class ActionReader
    {
        //METHODS
        #region Methods
        public static ActionMap ReadFile(string filepath)
        {
            StreamReader sr = new StreamReader(filepath);
            String line;
            String[] tokens;
            ActionKey actionKey;
            ActionMap map = new ActionMap();
            Type actionType;
            String actionKeyString;
            int linecounter = 0;

            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                linecounter++;
                tokens = line.Split('/');
                //tokens[0] = entry-type
                //tokens[1] = parameters
                actionKeyString = EncodeEntryType(tokens[0],linecounter);

                tokens = tokens[1].Split(':');

                //verify action format is valid
                switch (actionKeyString[0].ToString())
                {
                    case ActionKey.EntryType.ASSOCIATION:
                        actionKeyString += EncodeParametersAssociation(tokens, linecounter);
                        break;
                    case ActionKey.EntryType.ASSOCIATIONCLASS:
                        actionKeyString += EncodeParametersAssociationClass(tokens, linecounter);
                        break;
                    case ActionKey.EntryType.GENERALIZATION:
                        actionKeyString += EncodeParametersGeneralization(tokens, linecounter);
                        break;
                    case ActionKey.EntryType.REALIZATION:
                        actionKeyString += EncodeParametersRealization(tokens, linecounter);
                        break;
                }

                if (Regex.IsMatch(tokens[tokens.Length - 1], @"^[A-Za-z0-9]*$"))
                {
                    actionKey = new ActionKey(actionKeyString);

                    //add the value-pair if no equal action-key exists
                    if (map.GetAction(actionKey) == null)
                    {
                        //create/validate action object
                        actionType = Type.GetType(ActionKey.ACTIONNAMESPACE + tokens[tokens.Length - 1]);
                        //add the map entry
                        map.Add(actionKey, (AbstractAction)Activator.CreateInstance(actionType));
                    }
                    else
                    {
                        throw new InvalidOperationException("An equivalent ActionKey already exists in the ActionMap at line: " + linecounter);
                    }
                }
                else
                {
                    throw new ArgumentException("The action-name contains some invalid characters at line: " + linecounter);
                }
            }

            return map;
        }

        private static String EncodeEntryType(string entry, int linecounter)
        {
            switch (entry)
            {
                case "association": return ActionKey.EntryType.ASSOCIATION;
                case "generalization": return ActionKey.EntryType.GENERALIZATION;
                case "realization": return ActionKey.EntryType.REALIZATION;
                case "associationclass": return ActionKey.EntryType.ASSOCIATIONCLASS;
                default: throw new ArgumentException("Invalid entry-type specification at line: " + linecounter, "entry-type");
            }
        }

        private static String EncodeParametersAssociation(string[] tokens, int linecounter)
        {
            string end1type;
            string end2type;
            string end1mult;
            string end2mult;
            string dependent;

            if (tokens.Length == 6)
            {
                //1st token: 1st end-type
                switch (tokens[0])
                {
                    case "none": end1type = ActionKey.EndType.NONE; break;
                    case "aggregation": end1type = ActionKey.EndType.AGGREGATION; break;
                    case "composition": end1type = ActionKey.EndType.COMPOSITION; break;
                    default: throw new ArgumentException("Invalid relationship end type at line: " + linecounter, "end1 type");
                }

                //2nd token: 2nd end-type
                switch (tokens[1])
                {
                    case "none": end2type = ActionKey.EndType.NONE; break;
                    case "aggregation": end2type = ActionKey.EndType.AGGREGATION; break;
                    case "composition": end2type = ActionKey.EndType.COMPOSITION; break;
                    default: throw new ArgumentException("Invalid relationship end type at line: " + linecounter, "end2 type");
                }

                if (end1type != ActionKey.EndType.NONE && end2type != ActionKey.EndType.NONE)
                {
                    //In this case a critical error has occured
                    throw new ArgumentException("Invalid relationship ends, at least one of them must be of type none at line: " + linecounter);
                }
                else
                {
                    //relationship is an association

                    //3rd token: 1st multiplicity
                    switch (tokens[2])
                    {
                        case "*": end1mult = ActionKey.MultiplicityType.MANY; break;
                        case "1": end1mult = ActionKey.MultiplicityType.ONE; break;
                        case "1..*": end1mult = ActionKey.MultiplicityType.ONETOMANY; break;
                        case "0..*": end1mult = ActionKey.MultiplicityType.ZEROTOMANY; break;
                        case "0..1": end1mult = ActionKey.MultiplicityType.ZEROTOONE; break;
                        default: throw new ArgumentException("Invalid multiplicity specification at line: " + linecounter, "end1 multiplicity");
                    }

                    //4th token: 2nd multiplicity
                    switch (tokens[3])
                    {
                        case "*": end2mult = ActionKey.MultiplicityType.MANY; break;
                        case "1": end2mult = ActionKey.MultiplicityType.ONE; break;
                        case "1..*": end2mult = ActionKey.MultiplicityType.ONETOMANY; break;
                        case "0..*": end2mult = ActionKey.MultiplicityType.ZEROTOMANY; break;
                        case "0..1": end2mult = ActionKey.MultiplicityType.ZEROTOONE; break;
                        default: throw new ArgumentException("Invalid multiplicity specification at line: " + linecounter, "end2 multiplicity");
                    }

                    //5th token: dependent or independent?
                    switch (tokens[4])
                    {
                        case "D": dependent = ActionKey.DependencyType.DEPENDENT; break;
                        case "I": dependent = ActionKey.DependencyType.INDEPENDENT; break;
                        //default: dependent = ActionKey.DependencyType.DEPENDENT; break;
                        default: throw new ArgumentException("Invalid dependent/independent specification at line: " + linecounter, "dependent/independent");
                    }

                    return end1type + end2type + end1mult + end2mult + dependent;
                }
            }
            else
            {
                throw new ArgumentException("Exactly 6 arguments are necessary in an association-type relationship specification at line: " + linecounter);
            }
        }

        private static String EncodeParametersAssociationClass(string[] tokens, int linecounter)
        {
            if (tokens.Length == 1)
            {
                return "";
            }
            else
            {
                throw new ArgumentException("Action name specification contains some invalid characters at line: " + linecounter, "action-name");
            }
        }

        private static String EncodeParametersGeneralization(string[] tokens, int linecounter)
        {
            string end1type;
            string end2type;

            if (tokens.Length == 3)
            {
                //1st token: 1st end-type
                switch (tokens[0])
                {
                    case "none": end1type = ActionKey.EndType.NONE; break;
                    case "generalization": end1type = ActionKey.EndType.GENERALIZATION; break;
                    default: throw new ArgumentException("Invalid relationship end type at line: " + linecounter, "end1 type");
                }

                //2nd token: 2nd end-type
                switch (tokens[1])
                {
                    case "none": end2type = ActionKey.EndType.NONE; break;
                    case "generalization": end2type = ActionKey.EndType.GENERALIZATION; break;
                    default: throw new ArgumentException("Invalid relationship end type at line: " + linecounter, "end2 type");
                }

                if (end1type != ActionKey.EndType.NONE && end2type != ActionKey.EndType.NONE)
                {
                    //In this case a critical error has occured
                    throw new ArgumentException("Invalid relationship ends, at least one of them must be of type none at line: " + linecounter);
                }
                else
                {
                    //relationship is a generalization
                    return end1type + end2type;
                }
            }
            else
            {
                throw new ArgumentException("Exactly 3 arguments are necessary in a generalization-type relationship specification at line: " + linecounter);
            }
        }

        private static String EncodeParametersRealization(string[] tokens, int linecounter)
        {
            string end1type;
            string end2type;

            if (tokens.Length == 3)
            {
                //1st token: 1st end-type
                switch (tokens[0])
                {
                    case "none": end1type = ActionKey.EndType.NONE; break;
                    case "realization": end1type = ActionKey.EndType.REALIZATION; break;
                    default: throw new ArgumentException("Invalid relationship end type at line: " + linecounter, "end1 type");
                }

                //2nd token: 2nd end-type
                switch (tokens[1])
                {
                    case "none": end2type = ActionKey.EndType.NONE; break;
                    case "realization": end2type = ActionKey.EndType.REALIZATION; break;
                    default: throw new ArgumentException("Invalid relationship end type at line: " + linecounter, "end2 type");
                }

                if (end1type != ActionKey.EndType.NONE && end2type != ActionKey.EndType.NONE)
                {
                    //In this case a critical error has occured
                    throw new ArgumentException("Invalid relationship ends, at least one of them must be of type none at line: " + linecounter);
                }
                else
                {
                    //relationship is a generalization
                    return end1type + end2type;
                }
            }
            else
            {
                throw new ArgumentException("Exactly 3 arguments are necessary in a realization-type relationship specification at line: " + linecounter);
            }
        }
        #endregion
    }
}
