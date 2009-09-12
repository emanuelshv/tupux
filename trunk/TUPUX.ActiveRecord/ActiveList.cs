using System;
using System.Data;
using log4net;

namespace TUPUX.ActiveRecord
{

    [Serializable]
    public class ActiveList<ItemType, ListType> : AbstractList<ItemType, ListType> 
        where ItemType : ActiveRecord<ItemType>, new()
        where ListType : AbstractList<ItemType, ListType>, new()
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(ListComparer<ItemType>));

        public ActiveList(){}

        public ActiveRecord<ItemType> Find(object primaryKeyValue) {
            //ActiveRecord<ItemType> result = null;
            //foreach (ItemType item in this) {
            //    if (item.GetPrimaryKeyValue().Equals(primaryKeyValue)) {
            //        result = item;
            //    }
            //}
            //return result;
            throw new NotImplementedException();
        }

        /// <summary>
        /// Saves all the records in a collection to the DB
        /// </summary>
        public void SaveAll() {
            foreach (ItemType item in this) 
            {
                try
                {
                    item.Save();
                }
                catch (Exception ex)
                {
                    log.Error("", ex);
                }
            }
        }

        /// <summary>
        /// Delete all items in a collection
        /// </summary>
        public void DeleteAll()
        {
            foreach (ItemType item in this)
            {
                try
                {
                    item.Delete();
                }
                catch (Exception ex)
                {
                    log.Error("", ex);
                }
            }
            this.Clear();
        }

        public ListType Clone()
        {
            ListType coll = new ListType();
            foreach(ItemType item in this)
            {
                try
                {
                    ItemType newItem = item.Clone();
                    coll.Add(newItem);
                }
                catch (Exception ex)
                {
                    log.Error("", ex);
                }
            }
            return coll;
        }
    }
}
