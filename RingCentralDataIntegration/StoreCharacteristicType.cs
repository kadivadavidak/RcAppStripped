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
    
    public partial class StoreCharacteristicType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StoreCharacteristicType()
        {
            this.StoreCharacteristics = new HashSet<StoreCharacteristic>();
        }
    
        public int StoreCharacteristicTypeID { get; set; }
        public string StoreCharacteristicType1 { get; set; }
        public string StoreCharacteristicClass { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StoreCharacteristic> StoreCharacteristics { get; set; }
    }
}
