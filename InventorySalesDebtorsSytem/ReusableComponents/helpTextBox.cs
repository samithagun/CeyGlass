using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DBLayer;

namespace InventorySalesDebtorsSytems
{
    public partial class helpTextBox : UserControl
    {
        public string codeFieldName;
        public object codeField;
        public IEnumerable<object> varList;
        public List<Control> controlList;
        public List<string> fieldList;
        //public override string Text
        //{
        //    get 
        //    { 
        //        Text = txtMasterData.Text;
        //        return Text; 
        //    }
        //    set 
        //    { 
        //        Text = value; 
        //        txtMasterData.Text = Text;
        //    }
        //}

        public helpTextBox()
        {
            InitializeComponent();
        }

        private void SearchData()
        {
            txtMasterData.Text = new helpSearchData().SearchAndReturnRow(varList, codeFieldName)[codeFieldName].ToString();
        }

        private void MasterFileSearch_DoubleClick(object sender, EventArgs e)
        {
            SearchData();
        }

        private void txtMasterData_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 112)
                SearchData();
        }

        private void txtMasterData_DoubleClick(object sender, EventArgs e)
        {
            SearchData();
        }

        private void txtMasterData_Leave(object sender, EventArgs e)
        {
            FillData();
        }

        private void FillData()
        {
            DataTable dt = Helpers.LINQToDataTable(varList);
            DataColumn[] dcA = new DataColumn[1];
            dcA[0] = dt.Columns[0];
            foreach (DataColumn dc in dt.Columns)
                if (dc.ColumnName == codeFieldName)
                    dcA[0] = dc;
            dt.PrimaryKey = dcA;
            DataRow dr = dt.Rows.Find(txtMasterData.Text);
            int count = (controlList.Count < fieldList.Count) ? controlList.Count : fieldList.Count;
            for (int i = 0; i < count; i++)
            {
                if (controlList[i].GetType().ToString() == "System.Windows.Forms.TextBox")
                    controlList[i].Text = dr[fieldList[i]].ToString();
            }
        }
    }
}
