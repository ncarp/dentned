//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DG.DentneD.Model.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class payments
    {
        public int payments_id { get; set; }
        public int patients_id { get; set; }
        public System.DateTime payments_date { get; set; }
        public decimal payments_amount { get; set; }
        public string payments_notes { get; set; }
    
        public virtual patients patients { get; set; }
    }
}