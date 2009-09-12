using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using TUPUX.Entity;
using System.Text.RegularExpressions;
using TUPUX.Estimation.Action.Gallery;

namespace TUPUX.Estimation.Action
{
    /*
     * The purpose of this class is to allow the mapping of the action-events defined in the text file
     * to the actions to be executed upon their occurences. Every Action is identified by an ActionKey
     * so that the Action class name in the Gallery must match the name used in the text file in order to 
     * be found.
     */
    public class ActionMap
    {
        //ATTRIBUTES
        #region Attributes
        public IDictionary<ActionKey, AbstractAction> map;
        #endregion

        //CONSTRUCTORS
        #region Constructors
        internal ActionMap()
        {
            this.map = new Dictionary<ActionKey, AbstractAction>(new ActionKeyComparer());
        }
        #endregion

        //INDEXERS
        #region Indexers
        private AbstractAction this[ActionKey key]
        {
            get
            {
                if (map.ContainsKey(key))
                {
                    return map[key];
                }
                else
                {
                    return null;
                }
            }
        }
        #endregion

        //METHODS
        #region Methods
        public void Add(ActionKey key, AbstractAction action)
        {
            map.Add(key, action);
        }

        public AbstractAction GetAction(ActionKey key)
        {
            AbstractAction action;

            try
            {
                action = map[key];
                action.IsAlternate = false;
            }
            catch (KeyNotFoundException e1)
            {
                try
                {
                    action = map[key.AlternateKey];
                    action.IsAlternate = true;
                }
                catch (KeyNotFoundException e2)
                {
                    return null;
                }
            }
            return action;
        }
        #endregion

        //NESTED CLASS ACTIONKEYCOMPARER
        #region Nested Class ActionKeyComparer
        protected class ActionKeyComparer : IEqualityComparer<ActionKey>
        {
            bool IEqualityComparer<ActionKey>.Equals(ActionKey keyA, ActionKey keyB)
            {
                if (keyA.Key.Equals(keyB.Key))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            int IEqualityComparer<ActionKey>.GetHashCode(ActionKey key)
            {
                return base.GetHashCode();
            }

            private String GetAlternateKey(String key)
            {
                char[] array;
                char temp;

                array = key.ToCharArray();
                temp = array[0];
                array[0] = array[1];
                array[1] = temp;

                temp = array[2];
                array[2] = array[3];
                array[3] = temp;

                return new String(array);
            }
        }
        #endregion
    }
}
