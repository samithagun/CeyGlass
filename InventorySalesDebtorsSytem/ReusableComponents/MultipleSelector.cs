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
    public partial class MultipleSelector : Form
    {
        public IEnumerable<object> UnselectedVarList { get; set; }
        public IEnumerable<object> SelectedVarList { get; set; }
        public DataTable dtUnselected { get; set; }
        public DataTable dtSelected { get; set; }
        public string PrimaryKey { get; set; }

        public MultipleSelector()
        {
            InitializeComponent();
        }

        public DataTable ShowSelector(string Title, string PrimaryKey, IEnumerable<object> VarList, DataTable dtSelected)
        {
            this.PrimaryKey = PrimaryKey;
            this.UnselectedVarList = VarList;
            this.dtUnselected = Helpers.AllStrDataTable(Helpers.LINQToDataTable(this.UnselectedVarList));
            DataColumn[] dcU = new DataColumn[1];
            dcU[0] = dtUnselected.Columns[PrimaryKey];
            this.dtUnselected.PrimaryKey = dcU;
            this.dtSelected = dtSelected == null ? dtUnselected.Clone() : dtSelected;
            DataColumn[] dcS = new DataColumn[1];
            dcS[0] = this.dtSelected.Columns[PrimaryKey];
            this.dtSelected.PrimaryKey = dcS;
            this.dataGridViewUnselected.AutoGenerateColumns = true;
            this.dataGridViewUnselected.DataSource = dtUnselected;
            this.dataGridViewUnselected.AutoGenerateColumns = false;
            this.dataGridViewSelected.AutoGenerateColumns = true;
            this.dataGridViewSelected.DataSource = this.dtSelected;
            this.dataGridViewSelected.AutoGenerateColumns = false;

            this.Text = Title;

            foreach (DataRow dr in this.dtSelected.Rows)
            {
                DataRow[] drs = this.dtUnselected.Select(this.PrimaryKey + " = '" + dr[PrimaryKey].ToString() + "'");
                this.dtUnselected.Rows.Remove(drs[0]);
            }

            this.ShowDialog();

            return this.dtSelected;
        }

        public DataTable SelectAll(string Title, string PrimaryKey, IEnumerable<object> VarList)
        {
            this.UnselectedVarList = VarList;
            return Helpers.AllStrDataTable(Helpers.LINQToDataTable(this.UnselectedVarList));
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            SelectSingle();
        }

        private void SelectSingle()
        {
            foreach (DataGridViewRow dr in this.dataGridViewUnselected.SelectedRows)
            {
                DataRow[] drs = this.dtUnselected.Select(this.PrimaryKey + " = '" + dr.Cells[PrimaryKey].Value.ToString() + "'");
                this.dtSelected.ImportRow(drs[0]);
                this.dtUnselected.Rows.Remove(drs[0]);
            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            SelectAll();
        }

        private void SelectAll()
        {
            foreach (DataGridViewRow dr in this.dataGridViewUnselected.Rows)
            {
                DataRow[] drs = this.dtUnselected.Select(this.PrimaryKey + " = '" + dr.Cells[PrimaryKey].Value.ToString() + "'");
                this.dtSelected.ImportRow(drs[0]);
                //this.dtUnselected.Rows.Remove(drs[0]);
            }
            //this.dtSelected = this.dtUnselected.Copy();
            this.dtUnselected.Rows.Clear();
        }

        private void btnUnselect_Click(object sender, EventArgs e)
        {
            UnselectSingle();
        }

        private void UnselectSingle()
        {
            foreach (DataGridViewRow dr in this.dataGridViewSelected.SelectedRows)
            {
                DataRow[] drs = this.dtSelected.Select(this.PrimaryKey + " = '" + dr.Cells[PrimaryKey].Value.ToString() + "'");
                this.dtUnselected.ImportRow(drs[0]);
                this.dtSelected.Rows.Remove(drs[0]);
            }
        }

        private void btnUnselectAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in this.dataGridViewSelected.Rows)
            {
                DataRow[] drs = this.dtSelected.Select(this.PrimaryKey + " = '" + dr.Cells[PrimaryKey].Value.ToString() + "'");
                this.dtUnselected.ImportRow(drs[0]);
                //this.dtSelected.Rows.Remove(drs[0]);
            }
            //this.dtUnselected = this.dtSelected.Copy();
            this.dtSelected.Rows.Clear();
        }

        private void dataGridViewUnselected_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectSingle();
        }

        private void dataGridViewSelected_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UnselectSingle();
        }

    }
}
