//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayerFlipkartdemo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer1()
        {
            this.Products = new HashSet<Product>();
        }
    
        public int CustId { get; set; }
        public string CustName { get; set; }
        public int CustAddress_StreetNo { get; set; }
        public string CustAddress_StreetName { get; set; }
        public int CustAddress_BldgNo { get; set; }
        public string CustAddress_SocietyName { get; set; }
        public string CustAddress_City { get; set; }
        public string CustAddress_State { get; set; }
        public string CustAddress_Country { get; set; }
        public string CustAddress_Pincode { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
    }
}