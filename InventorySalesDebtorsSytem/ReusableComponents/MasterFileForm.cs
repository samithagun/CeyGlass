namespace InventorySalesDebtorsSytem
{
    public class MasterFileForm : System.Windows.Forms.Form
    {
        public virtual bool BeforeDataSave() { return true; }

        public virtual bool AfterDataSave() { return true; }

        public virtual bool BeforeDataDelete() { return true; }

        public virtual bool AfterDataDelete() { return true; }

        public virtual void PrintData() { }

        public virtual void EnableControls(bool enable) { }

        private void InitializeComponent()
        {
            //this.VIBlendTheme = InventorySalesDebtorsSytem.Properties.Settings.Default.VIBlendTheme;
        }

    }
}
