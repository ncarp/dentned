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
    
    public partial class computedlines
    {
        public int computedlines_id { get; set; }
        public Nullable<int> taxes_id { get; set; }
        public string computedlines_code { get; set; }
        public string computedlines_name { get; set; }
        public decimal computedlines_rate { get; set; }
    
        public virtual taxes taxes { get; set; }
    }
}