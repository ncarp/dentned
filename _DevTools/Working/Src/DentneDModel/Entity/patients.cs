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
    
    public partial class patients
    {
        public patients()
        {
            this.appointments = new HashSet<appointments>();
            this.estimates = new HashSet<estimates>();
            this.invoices = new HashSet<invoices>();
            this.patientsaddresses = new HashSet<patientsaddresses>();
            this.patientsattachments = new HashSet<patientsattachments>();
            this.patientsattributes = new HashSet<patientsattributes>();
            this.patientscontacts = new HashSet<patientscontacts>();
            this.patientsmedicalrecords = new HashSet<patientsmedicalrecords>();
            this.patientsnotes = new HashSet<patientsnotes>();
            this.patientstreatments = new HashSet<patientstreatments>();
            this.payments = new HashSet<payments>();
        }
    
        public int patients_id { get; set; }
        public Nullable<int> treatmentspriceslists_id { get; set; }
        public string patients_name { get; set; }
        public string patients_surname { get; set; }
        public string patients_sex { get; set; }
        public System.DateTime patients_birthdate { get; set; }
        public string patients_birthcity { get; set; }
        public string patients_doctext { get; set; }
        public string patients_notes { get; set; }
        public bool patients_isarchived { get; set; }
        public string patients_username { get; set; }
        public string patients_password { get; set; }
        public string patients_token { get; set; }
        public Nullable<System.DateTime> patients_lastlogin { get; set; }
    
        public virtual ICollection<appointments> appointments { get; set; }
        public virtual ICollection<estimates> estimates { get; set; }
        public virtual ICollection<invoices> invoices { get; set; }
        public virtual treatmentspriceslists treatmentspriceslists { get; set; }
        public virtual ICollection<patientsaddresses> patientsaddresses { get; set; }
        public virtual ICollection<patientsattachments> patientsattachments { get; set; }
        public virtual ICollection<patientsattributes> patientsattributes { get; set; }
        public virtual ICollection<patientscontacts> patientscontacts { get; set; }
        public virtual ICollection<patientsmedicalrecords> patientsmedicalrecords { get; set; }
        public virtual ICollection<patientsnotes> patientsnotes { get; set; }
        public virtual ICollection<patientstreatments> patientstreatments { get; set; }
        public virtual ICollection<payments> payments { get; set; }
    }
}