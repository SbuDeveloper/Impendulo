//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Impendulo.Data.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class StudentDisability
    {
        public int StudentDisabilityID { get; set; }
        public int StudentID { get; set; }
        public int DisabilityID { get; set; }
        public string StudentDisabilityNotes { get; set; }
    
        public virtual LookupDisability LookupDisability { get; set; }
        public virtual Student Student { get; set; }
    }
}
