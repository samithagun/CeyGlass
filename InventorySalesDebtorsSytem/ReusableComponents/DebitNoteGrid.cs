using DBLayer;

namespace InventorySalesDebtorsSytem
{
    public class DebitNoteGrid
    {
        public DebitNoteGrid() { }

        public DebitNoteGrid(CusDebitNote dNote, decimal AloAmt, bool retrieveMode)
        {
            this.DNoteNo = dNote.ReferenceNo;
            this.ManualNo = dNote.ManualNo;
            this.Remarks = dNote.Remarks;
            this.TotAmt = dNote.TotalVal;
            if (retrieveMode)
            {
                this.BalAmt = dNote.TotalBalVal + AloAmt;
                this.AloAmt = AloAmt;
                this.NetBal = dNote.TotalBalVal;
            }
            else
            {
                this.BalAmt = dNote.TotalBalVal;
                this.AloAmt = AloAmt;
                this.NetBal = dNote.TotalBalVal - AloAmt;
            }
        }

        public string DNoteNo { get; set; }
        public string ManualNo { get; set; }
        public string Remarks { get; set; }
        public decimal TotAmt { get; set; }
        public decimal BalAmt { get; set; }
        public decimal AloAmt { get; set; }
        public decimal NetBal { get; set; }
    }
}
