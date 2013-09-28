using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InventorySalesDebtorsSytem
{
    public partial class MultipleSelectorBar : UserControl
    {
        private IEnumerable<object> _UnselectedVarList;
        public IEnumerable<object> UnselectedVarList
        {
            get { return _UnselectedVarList; }
            set
            {
                _UnselectedVarList = value;
                txtCode.varList = _UnselectedVarList;
            }
        }
        public DataTable dtSelected { get; set; }
        public string PrimaryKey { get; set; }

        public string Title
        {
            get { return lblTitle.Text.Substring(0, lblTitle.Text.Length - 1); }
            set { lblTitle.Text = value + ":"; }
        }

        public int TextBoxLeft
        {
            get { return txtCode.Left; }
            set { txtCode.Left = value; }
        }

        public int ButtonLeft
        {
            get { return btnSelect.Left; }
            set { btnSelect.Left = value; }
        }

        public string CodeText
        {
            get { return txtCode.Text; }
        }

        public MultipleSelectorBar()
        {
            InitializeComponent();
        }

        private void MultipleSelectorBar_Load(object sender, EventArgs e)
        {
            if (this.ParentForm != null)
            {
                txtCode.varList = UnselectedVarList;
                txtCode.codeFieldName = PrimaryKey;
                ToggleSelected();
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            dtSelected = new MultipleSelector().ShowSelector(lblTitle.Text.Substring(0, lblTitle.Text.Length - 1), PrimaryKey, UnselectedVarList, dtSelected);

            ToggleSelected();
        }

        private void ToggleSelected()
        {
            if (dtSelected != null && dtSelected.Rows.Count > 0)
                if (UnselectedVarList.Count() > dtSelected.Rows.Count)
                    btnSelect.ImageAlign = ContentAlignment.BottomCenter;
                else
                    btnSelect.ImageAlign = ContentAlignment.TopCenter;
            else
                btnSelect.ImageAlign = ContentAlignment.MiddleCenter;
        }

        public void PrintClick()
        {
            if (dtSelected == null)
                dtSelected = new MultipleSelector().SelectAll(lblTitle.Text.Substring(0, lblTitle.Text.Length - 1), PrimaryKey, UnselectedVarList);

            ToggleSelected();
        }
    }
}
