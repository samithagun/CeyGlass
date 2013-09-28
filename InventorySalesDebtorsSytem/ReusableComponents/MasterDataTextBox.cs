using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace InventorySalesDebtorsSytem
{
    public partial class MasterDataTextBox : TextBox
    {
        public string codeFieldName { get; set; }
        public IEnumerable<object> varList { get; set; }
        public List<Control> controlList = new List<Control>();
        public List<string> fieldList = new List<string>();
        public string filterCondition { get; set; }
        public string sortOrder { get; set; } 
        private bool _valid;
        public bool valid
        {
            get
            {
                FillData();
                if (this.Text == "")
                    _valid = false;
                else
                    _valid = true;
                return _valid;
            }
            set
            {
                _valid = value;
            }
        }

        public void Validate()
        {
            FillData();
        }

        public MasterDataTextBox()
        {
            InitializeComponent();
        }

        private void SearchData()
        {
            DataRow dr = new helpSearchData().SearchAndReturnRow(varList, sortOrder == null ? codeFieldName : sortOrder);
            if (dr == null)
                this.Text = "";
            else
                this.Text = dr[codeFieldName].ToString();
            foreach (Binding binding in this.DataBindings)
                binding.WriteValue();
            FillData();
        }

        private void MasterDataTextBox_DoubleClick(object sender, EventArgs e)
        {
            SearchData();
        }

        private void MasterDataTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 112)
                SearchData();
        }

        public void FillData()
        {
            if (varList == null)
                return;
            try
            {
                DataTable dt = Helpers.LINQToDataTable(varList);
                DataColumn[] dcA = new DataColumn[1]; // To get the Primary Key
                dcA[0] = dt.Columns[codeFieldName];
                dt.PrimaryKey = dcA;
                DataRow dr = dt.Rows.Find(this.Text);
                if (dr != null)
                {
                    this.Text = dr[codeFieldName].ToString();
                    int count = (controlList.Count < fieldList.Count) ? controlList.Count : fieldList.Count;
                    for (int i = 0; i < count; i++)
                    {
                        if (controlList[i].GetType().Name == "TextBox")
                        {
                            try
                            {
                                controlList[i].Text = dr[fieldList[i]].ToString();
                                foreach (Binding binding in controlList[i].DataBindings)
                                    binding.WriteValue();
                            }
                            catch (Exception ex) { Helpers.WriteException(ex); }
                        }
                        if (controlList[i].GetType().Name == "NumericUpDown")
                        {
                            try
                            {
                                ((NumericUpDown)controlList[i]).Value = Convert.ToDecimal(dr[fieldList[i]]);
                                foreach (Binding binding in controlList[i].DataBindings)
                                    binding.WriteValue();
                            }
                            catch (Exception ex) { Helpers.WriteException(ex); }
                        }
                        if (controlList[i].GetType().Name == "MasterDataTextBox") 
                        {
                            try
                            {
                                ((MasterDataTextBox)controlList[i]).Text = dr[fieldList[i]].ToString();
                                ((MasterDataTextBox)controlList[i]).Validate();
                                foreach (Binding binding in controlList[i].DataBindings)
                                    binding.WriteValue();
                            }
                            catch (Exception ex) { Helpers.WriteException(ex); }
                        }
                    }
                }
                else
                {
                    this.Text = "";
                    int count = (controlList.Count < fieldList.Count) ? controlList.Count : fieldList.Count;
                    for (int i = 0; i < count; i++)
                    {
                        if (controlList[i].GetType().Name == "TextBox")
                        {
                            controlList[i].Text = "";
                            foreach (Binding binding in controlList[i].DataBindings)
                                binding.WriteValue();
                        }
                        if (controlList[i].GetType().Name == "NumericUpDown")
                        {
                            ((NumericUpDown)controlList[i]).Value = 0.00m;
                            foreach (Binding binding in controlList[i].DataBindings)
                                binding.WriteValue();
                        }
                        if (controlList[i].GetType().Name == "MasterDataTextBox")
                        {
                            controlList[i].Text = "";
                            ((MasterDataTextBox)controlList[i]).Validate();
                            foreach (Binding binding in controlList[i].DataBindings)
                                binding.WriteValue();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Helpers.WriteException(ex);
                int count = (controlList.Count < fieldList.Count) ? controlList.Count : fieldList.Count;
                for (int i = 0; i < count; i++)
                {
                    if (controlList[i].GetType().Name == "TextBox")
                    {
                        controlList[i].Text = "";
                        foreach (Binding binding in controlList[i].DataBindings)
                            binding.WriteValue();
                    }
                    if (controlList[i].GetType().Name == "NumericUpDown")
                    {
                        ((NumericUpDown)controlList[i]).Value = 0.00m;
                        foreach (Binding binding in controlList[i].DataBindings)
                            binding.WriteValue();
                    }
                    if (controlList[i].GetType().Name == "MasterDataTextBox")
                    {
                        controlList[i].Text = "";
                        ((MasterDataTextBox)controlList[i]).Validate();
                        foreach (Binding binding in controlList[i].DataBindings)
                            binding.WriteValue();
                    }
                }
            }
        }

        private void MasterDataTextBox_Leave(object sender, EventArgs e)
        {
            FillData();
        }
    }
}
