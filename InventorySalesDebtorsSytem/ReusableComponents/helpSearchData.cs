using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InventorySalesDebtorsSytem
{
    public partial class helpSearchData : Form
    {
        private DataTable dtSearch, dtResult;
        private DataRow[] drResult;
        private String sortOrder;
        private String[] columnNames;
        private bool[] isNumeric;
        private int noOfColumns;

        public helpSearchData()
        {
            InitializeComponent();
        }

        public DataRow SearchAndReturnRow<T>(IEnumerable<T> varlist, String sortOrder)
        {
            dtSearch = Helpers.LINQToDataTable(varlist);
            dtSearch = Helpers.AllStrDataTable(dtSearch);
            if (dtSearch.Rows.Count <= 0)
            {
                MessageBox.Show("No Data to Search", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            this.sortOrder = sortOrder;
            this.dtResult = this.dtSearch.Clone();
            noOfColumns = dtSearch.Columns.Count;
            columnNames = new String[noOfColumns];
            isNumeric = new bool[noOfColumns];
            for (int i = 0; i < noOfColumns; i++)
            {
                columnNames[i] = dtSearch.Columns[i].ColumnName;
                if (dtSearch.Columns[i].DataType.Name == "Decimal")
                    isNumeric[i] = true;
                else
                    isNumeric[i] = false;
            }
            dataGridSearch.DataSource = this.dtResult;
            SearchString();
            txtSearchStr.Focus();
            this.ShowDialog();
            if (dataGridSearch.SelectedRows.Count > 0)
                return dtResult.Rows[dataGridSearch.SelectedRows[0].Index];
            else
                return null;
        }

        public DataRow SearchAndReturnRow(DataTable dtSearch, String sortOrder)
        {
            if (dtSearch.Rows.Count <= 0)
            {
                MessageBox.Show("No Data to Search", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            this.dtSearch = dtSearch;
            this.sortOrder = sortOrder;
            this.dtResult = this.dtSearch.Clone();
            noOfColumns = dtSearch.Columns.Count;
            columnNames = new String[noOfColumns];
            for (int i = 0; i < noOfColumns; i++)
            {
                columnNames[i] = dtSearch.Columns[i].ColumnName;
            }
            dataGridSearch.DataSource = this.dtResult;
            SearchString();
            txtSearchStr.Focus();
            this.ShowDialog();
            if (dataGridSearch.SelectedRows.Count > 0)
                return dtResult.Rows[dataGridSearch.SelectedRows[0].Index];
            else
                return null;
        }

        private void txtSearchStr_TextChanged(object sender, EventArgs e)
        {
            SearchString();
        }

        private void SearchString()
        {
            String SearchString = "";
            txtSearchStr.Text = txtSearchStr.Text.Replace("'", "`");
            txtSearchStr.Text = txtSearchStr.Text.Replace("[", "");
            txtSearchStr.Text = txtSearchStr.Text.Replace("]", "");
            if (txtSearchStr.Text != "")
            {
                SearchString = columnNames[0] + " LIKE '%" + txtSearchStr.Text + "%'";
                for (int i = 1; i < noOfColumns; i++)
                {
                    SearchString = SearchString + " OR " + columnNames[i] + " LIKE '" + "%" + txtSearchStr.Text + "%'";
                }
            }
            drResult = dtSearch.Select(SearchString, sortOrder);
            dtResult.Rows.Clear();
            foreach (DataRow dr in drResult)
                dtResult.ImportRow(dr);
            dataGridSearch.Refresh();
        }

        private void dataGridSearch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridSearch.SelectedRows.Count > 0)
                this.Close();
        }

        private void txtSearchStr_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                if (dataGridSearch.Rows.Count > 0 && dataGridSearch.SelectedRows.Count > 0)
                    this.Close();
        }

        private void dataGridSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                if (dataGridSearch.Rows.Count > 0 && dataGridSearch.SelectedRows.Count > 0)
                {
                    e.Handled = true;
                    this.Close();
                }
        }

    }
}
