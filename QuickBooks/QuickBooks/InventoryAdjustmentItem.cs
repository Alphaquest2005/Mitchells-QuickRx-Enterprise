//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuickBooks
{
    using System;
    using System.Collections.Generic;
    
    public partial class InventoryAdjustmentItem
    {
        public int Id { get; set; }
        public string ItemListID { get; set; }
        public decimal NewQuantity { get; set; }
        public decimal OldQuantity { get; set; }
        public decimal QuantityDifference { get; set; }
        public int InventoryAdjustmentId { get; set; }
    
        public virtual InventoryAdjustment InventoryAdjustment { get; set; }
    }
}
