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
    
    public partial class estimates
    {
        public estimates()
        {
            this.estimateslines = new HashSet<estimateslines>();
        }
    
        public int estimates_id { get; set; }
        public Nullable<int> doctors_id { get; set; }
        public Nullable<int> patients_id { get; set; }
        public Nullable<int> invoices_id { get; set; }
        public string estimates_number { get; set; }
        public System.DateTime estimates_date { get; set; }
        public string estimates_doctor { get; set; }
        public string estimates_patient { get; set; }
        public string estimates_payment { get; set; }
        public string estimates_footer { get; set; }
        public decimal estimates_total { get; set; }
        public decimal estimates_deductiontaxrate { get; set; }
    
        public virtual doctors doctors { get; set; }
        public virtual invoices invoices { get; set; }
        public virtual patients patients { get; set; }
        public virtual ICollection<estimateslines> estimateslines { get; set; }
    }
}