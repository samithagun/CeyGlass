namespace InventorySalesDebtorsSytem
{
    public class TransactionForm : System.Windows.Forms.Form
    {
        private void InitializeComponent()
        {
            
        }

        /// <summary>
        /// This method will be called after the DB transaction has begun and after the Reference No has been generated but before the Header and Details tables are saved to the DB.
        /// </summary>
        /// <returns>Successfully saved or not</returns>
        public virtual bool BeforeDataSave() { return true; }

        /// <summary>
        /// This method will be called after the DB transaction has begun and after the Reference No has been generated and also after the Header and Details tables are saved to the DB.
        /// </summary>
        /// <returns>Successfully saved or not</returns>
        public virtual bool AfterDataSave() { return true; }

        /// <summary>
        /// This method will be called before the data is deleted from the Header and Detail tables.
        /// </summary>
        /// <returns>Successfully deleted or not</returns>
        public virtual bool BeforeDataDelete() { return true; }

        /// <summary>
        /// This method will be called after the data is deleted from the Header and Detail tables.
        /// </summary>
        /// <returns>Successfully deleted or not</returns>
        public virtual bool AfterDataDelete() { return true; }

        /// <summary>
        /// This method will be called when the user needs to search and select a Reference No to continue (Edit, Delete, Print).
        /// </summary>
        /// <param name="mode">The option the user selected (Edit, Delete, Print)</param>
        /// <returns>A DataRow containing the user selected values</returns>
        public virtual System.Data.DataRow SearchReferences(string mode)
        {
            return null;
        }

        /// <summary>
        /// This method will be called before the data is saved and before the trnasaction is begun to validate the user entered data.
        /// </summary>
        /// <param name="mode"></param>
        /// <returns>Data is valid or not</returns>
        public virtual bool ValidateOnSave(string mode)
        {
            return true;
        }

        /// <summary>
        /// This method is called before the user is allowed to change a record to check whether it's changable or not (Edit, Delete).
        /// </summary>
        /// <param name="mode">The option the user selected (Edit, Delete)</param>
        /// <returns>Valid to change or not</returns>
        public virtual bool ValidateOnChange(string mode)
        {
            return true;
        }

        public virtual void AddClick() { }

        public virtual void EditClick() { }

        public virtual void DeleteClick() { }

        public virtual void UndoClick() { }

        public virtual void SaveClick() { }

        public virtual void ViewClick() { }

        public virtual void ClearData() { }

        public virtual void LoadData() { }

        public virtual void PrintData() { }

        public virtual void EnableControls(bool enable) { }

    }
}
