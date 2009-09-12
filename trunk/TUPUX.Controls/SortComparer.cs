using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace TUPUX.Controls
{
   class SortComparer<T> : IComparer<T>
   {
      private ListSortDescriptionCollection m_SortCollection = null;
      private PropertyDescriptor m_PropDesc = null;
      private ListSortDirection m_Direction = ListSortDirection.Ascending;

      public SortComparer(PropertyDescriptor propDesc, ListSortDirection direction)
      {
         m_PropDesc = propDesc;
         m_Direction = direction;
      }

      public SortComparer(ListSortDescriptionCollection sortCollection)
      {
         m_SortCollection = sortCollection;
      }

      #region IComparer<T> Members

      int IComparer<T>.Compare(T x, T y)
      {
         if (m_PropDesc != null) // Simple sort 
         {
            object xValue = m_PropDesc.GetValue(x);
            object yValue = m_PropDesc.GetValue(y);
            return CompareValues(xValue, yValue, m_Direction);
         }
         else if (m_SortCollection != null && m_SortCollection.Count > 0)
         {
            return RecursiveCompareInternal(x,y, 0);
         }
         else return 0;
      }
      #endregion

      private int CompareValues(object xValue, object yValue, ListSortDirection direction)
      {

         int retValue = 0;
         if (xValue is IComparable) // Can ask the x value
         {
            retValue = ((IComparable)xValue).CompareTo(yValue);
         }
         else if (yValue is IComparable) //Can ask the y value
         {
            retValue = ((IComparable)yValue).CompareTo(xValue);
         }
         else if (!xValue.Equals(yValue)) // not comparable, compare String representations
         {
            retValue = xValue.ToString().CompareTo(yValue.ToString());
         }
         if (direction == ListSortDirection.Ascending)
         {
            return retValue;
         }
         else
         {
            return retValue * -1;
         }
      }

      private int RecursiveCompareInternal(T x, T y, int index)
      {
         if (index >= m_SortCollection.Count)
            return 0; // termination condition

         ListSortDescription listSortDesc = m_SortCollection[index];
         object xValue = listSortDesc.PropertyDescriptor.GetValue(x);
         object yValue = listSortDesc.PropertyDescriptor.GetValue(y);

         int retValue = CompareValues(xValue, yValue,listSortDesc.SortDirection);
         if (retValue == 0)
         {
            return RecursiveCompareInternal(x,y,++index);
         }
         else
         {
            return retValue;
         }
      }

   }
}
