using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace TUPUX.Forms.Validation
{
    public static class Grid
    {

        public static void ValidateRequiredGridCells(IWin32Window owner,
                                                ref DataGridView gridview,
                                                ref string msg,
                                                ref DataGridViewCellValidatingEventArgs e,
                                                bool showMessageBox)
        {
            DataGridViewRow row = gridview.Rows[e.RowIndex];

            if (row.DataGridView.IsCurrentRowDirty)
            {
                #region Validate each cell in row
                foreach (DataGridViewCell cell in row.Cells)
                {
                    bool isNotValid;
                    if (e.ColumnIndex == cell.ColumnIndex)
                    {
                        isNotValid = e.FormattedValue.Equals(string.Empty);
                    }
                    else
                    {
                        isNotValid = cell.FormattedValue.Equals(string.Empty);
                    }

                    if (isNotValid)
                    {
                        cell.ErrorText = "Can't be Empty";

                        string column = gridview.Columns[cell.ColumnIndex].HeaderText;
                        if (msg.Length == 0)
                        {
                            msg += "- " + column + ": " + cell.ErrorText;
                        }
                        else
                        {
                            msg += "\n- " + column + ": " + cell.ErrorText;
                        }
                    }
                    else
                    {
                        cell.ErrorText = string.Empty;
                    }
                }
                #endregion

                if (showMessageBox && msg.Length > 0)
                {
                    e.Cancel = true;
                    MessageBox.Show(owner, msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.ErrorText = String.Empty;
                }
            }
        }

        public static void ValidateRequiredGridCells(IWin32Window owner, 
                                                ref DataGridView gridview,
                                                ref string msg,
                                                ref DataGridViewCellCancelEventArgs e,
                                                bool showMessageBox)
        {
            DataGridViewRow row = gridview.Rows[e.RowIndex];

            if (row.DataGridView.IsCurrentRowDirty)
            {
                #region Validate each cell in row
                foreach (DataGridViewCell cell in row.Cells)
                {
                    bool isNotValid;
                    isNotValid = cell.FormattedValue.Equals(string.Empty);

                    if (isNotValid)
                    {
                        cell.ErrorText = "Can't be Empty";

                        string column = gridview.Columns[cell.ColumnIndex].HeaderText;
                        if (msg.Length == 0)
                        {
                            msg += "- " + column + ": " + cell.ErrorText;
                        }
                        else
                        {
                            msg += "\n- " + column + ": " + cell.ErrorText;
                        }
                    }
                    else
                    {
                        cell.ErrorText = string.Empty;
                    }
                }
                #endregion

                if (showMessageBox && msg.Length > 0)
                {
                    e.Cancel = true;
                    MessageBox.Show(owner, msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.ErrorText = String.Empty;
                }
            }
        }
    }
}
