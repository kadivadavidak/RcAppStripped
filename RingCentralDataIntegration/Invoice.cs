//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RingCentralDataIntegration
{
    using System;
    using System.Collections.Generic;
    
    public partial class Invoice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Invoice()
        {
            this.InvoiceActivities = new HashSet<InvoiceActivity>();
            this.InvoiceAdjustments = new HashSet<InvoiceAdjustment>();
        }
    
        public int InvoiceID { get; set; }
        public string InvoiceNumber { get; set; }
        public Nullable<int> CustomerTimelineID { get; set; }
        public int DivisionID { get; set; }
    
        public virtual CustomerTimeline CustomerTimeline { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceActivity> InvoiceActivities { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceAdjustment> InvoiceAdjustments { get; set; }
    }
}
