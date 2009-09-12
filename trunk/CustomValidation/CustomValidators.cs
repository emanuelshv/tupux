using System;
using System.ComponentModel;
using System.Collections;
using System.ComponentModel.Design;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace CustomValidation
{
    #region ValidationSummaryDisplayMode
    public enum ValidationSummaryDisplayMode
    {
        List,            // Simple list
        BulletList,      // Bulleted list
        SingleParagraph, // No line-breaks
        Simple,          // Plain MessageBox
    }
    #endregion

    #region ValidationDataType
    public enum ValidationDataType
    {
        Currency,
        Date,
        Double,
        Integer,
        String
    }
    #endregion

    #region ValidationCompareOperator
    public enum ValidationCompareOperator
    {
        DataTypeCheck,
        Equal,
        GreaterThan,
        GreaterThanEqual,
        LessThan,
        LessThanEqual,
        NotEqual
    }
    #endregion

    #region ValidationDepth
    public enum ValidationDepth
    {
        ContainerOnly,
        All
    }
    #endregion

    #region SummarizeEventHandler
    public delegate void SummarizeEventHandler(object sender, SummarizeEventArgs e);
    #endregion

   
}