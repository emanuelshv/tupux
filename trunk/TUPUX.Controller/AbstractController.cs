using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using TUPUX.ActiveRecord;

namespace TUPUX.Controller
{
    /// <summary>
    /// Base class for controller objects.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [System.ComponentModel.DataObject]
    public abstract class AbstractController<ItemType, ListType>
        where ItemType : ActiveRecord<ItemType>, new()
        where ListType : ActiveList<ItemType, ListType>, new()
    {
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public ListType FetchAll()
        {
            ListType list = new ListType();
            return list.Load();
            //return list.LoadProject();
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public ListType FetchByID(object ItemTypeID)
        {
            //ListType coll = new ListType().Where("ItemTypeID", ItemTypeID).Load();
            //return coll;


            throw new NotImplementedException();
        }

        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object ItemTypeID)
        {
            //return (ItemType.Delete(ItemTypeID) == 1);
            throw new NotImplementedException();
        }


        /// <summary>
        /// Inserts a record, can be used with the Object Data Source
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        //public void Insert(string ItemTypeName, int? SupplierID, int? CategoryID, string QuantityPerUnit, decimal? UnitPrice, short? UnitsInStock, short? UnitsOnOrder, short? ReorderLevel, bool Discontinued)
        public void Insert(ItemType item)
        {
            //ItemType item = new ItemType();

            //item.ItemTypeName = ItemTypeName;

            //item.SupplierID = SupplierID;

            //item.CategoryID = CategoryID;

            //item.QuantityPerUnit = QuantityPerUnit;

            //item.UnitPrice = UnitPrice;

            //item.UnitsInStock = UnitsInStock;

            //item.UnitsOnOrder = UnitsOnOrder;

            //item.ReorderLevel = ReorderLevel;

            //item.Discontinued = Discontinued;

            item.Save();
        }


        /// <summary>
        /// Updates a record, can be used with the Object Data Source
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
        //public void Update(int ItemTypeID, string ItemTypeName, int? SupplierID, int? CategoryID, string QuantityPerUnit, decimal? UnitPrice, short? UnitsInStock, short? UnitsOnOrder, short? ReorderLevel, bool Discontinued)
        public void Update(ItemType item)
        {
            //ItemType item = new ItemType();

            //item.ItemTypeID = ItemTypeID;

            //item.ItemTypeName = ItemTypeName;

            //item.SupplierID = SupplierID;

            //item.CategoryID = CategoryID;

            //item.QuantityPerUnit = QuantityPerUnit;

            //item.UnitPrice = UnitPrice;

            //item.UnitsInStock = UnitsInStock;

            //item.UnitsOnOrder = UnitsOnOrder;

            //item.ReorderLevel = ReorderLevel;

            //item.Discontinued = Discontinued;

            //item.MarkOld();
            item.MarkLoaded();
            item.Save();
        }

    }
}
