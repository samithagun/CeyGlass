using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DBLayer;

namespace InventorySalesDebtorsSytem
{
    public partial class MultipleSelectorBarCustomers : UserControl
    {
        public InventorySalesDebtorsSystemEntities DataBaseEntity { get; set; }
        public DataTable dtSelectedType, dtSelectedGroup, dtSelectedCustomer;
        public List<Customer> SelectedCustomers
        {
            get { return GetCustomerList(); }
        }
        public List<string> SelectedCustomerCodes
        {
            get { return GetCustomerCodeList(); }
        }

        public MultipleSelectorBarCustomers()
        {
            InitializeComponent();
        }

        private void MultipleSelectorBarCustomers_Load(object sender, EventArgs e)
        {
            if (DataBaseEntity != null)
            {
                multipleSelectorBarType.UnselectedVarList = from t in DataBaseEntity.CustomerTypes select new { t.TypeCode, t.TypeName };
                multipleSelectorBarGroup.UnselectedVarList = from g in DataBaseEntity.CustomerGroups select new { g.GroupCode, g.GroupName };
                multipleSelectorBarCustomer.UnselectedVarList = from c in DataBaseEntity.Customers select new { c.CustomerCode, c.CustomerName, c.CustomerGroup.GroupName, c.CustomerType.TypeName, c.CustomerAddress1, c.CustomerAddress2, c.CustomerAddress3, c.EmailAddress, c.Status };
            }
        }

        public List<Customer> GetCustomerList()
        {
            List<Customer> SelectedCustomers = new List<Customer>();

            dtSelectedType = multipleSelectorBarType.dtSelected;
            dtSelectedGroup = multipleSelectorBarGroup.dtSelected;
            dtSelectedCustomer = multipleSelectorBarCustomer.dtSelected;
            
            if (DataBaseEntity != null && dtSelectedCustomer != null && dtSelectedGroup != null && dtSelectedType != null)
            {
                var customers = DataBaseEntity.Customers.ToList();
                foreach (var customer in customers)
                {
                    if ((dtSelectedType.Select("TypeCode = '" + customer.TypeCode + "'").Count() > 0)
                        && (dtSelectedGroup.Select("GroupCode = '" + customer.GroupCode + "'").Count() > 0)
                        && (dtSelectedCustomer.Select("CustomerCode = '" + customer.CustomerCode + "'").Count() > 0))
                    {
                        if (chkActive.Checked && customer.Status == "Active")
                            SelectedCustomers.Add(customer);
                        else
                            if (chkInactive.Checked && customer.Status == "Inactive")
                                SelectedCustomers.Add(customer);
                            else
                                if (chkBlacklist.Checked && customer.Status == "Blacklist")
                                    SelectedCustomers.Add(customer);
                    }
                }
            }

            return SelectedCustomers;
        }

        public List<string> GetCustomerCodeList()
        {
            List<string> SelectedCustomerCodes = new List<string>();

            dtSelectedType = multipleSelectorBarType.dtSelected;
            dtSelectedGroup = multipleSelectorBarGroup.dtSelected;
            dtSelectedCustomer = multipleSelectorBarCustomer.dtSelected;
            
            if (DataBaseEntity != null && dtSelectedCustomer != null && dtSelectedGroup != null && dtSelectedType != null)
            {
                var customers = DataBaseEntity.Customers.ToList();
                foreach (var customer in customers)
                {
                    if ((dtSelectedType.Select("TypeCode = '" + customer.TypeCode + "'").Count() > 0)
                        && (dtSelectedGroup.Select("GroupCode = '" + customer.GroupCode + "'").Count() > 0)
                        && (dtSelectedCustomer.Select("CustomerCode = '" + customer.CustomerCode + "'").Count() > 0))
                    {
                        if (chkActive.Checked && customer.Status == "Active")
                            SelectedCustomerCodes.Add(customer.CustomerCode);
                        else
                            if (chkInactive.Checked && customer.Status == "Inactive")
                                SelectedCustomerCodes.Add(customer.CustomerCode);
                            else
                                if (chkBlacklist.Checked && customer.Status == "Blacklist")
                                    SelectedCustomerCodes.Add(customer.CustomerCode);
                    }
                }
            }

            return SelectedCustomerCodes;
        }

        public void PrintClick()
        {
            multipleSelectorBarType.PrintClick();
            multipleSelectorBarGroup.PrintClick();
            multipleSelectorBarCustomer.PrintClick();
        }
    }
}
