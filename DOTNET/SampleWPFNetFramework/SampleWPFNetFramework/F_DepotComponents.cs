//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SampleWPFNetFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class F_DepotComponents
    {
        public int DepotComponentId { get; set; }
        public int DepotId { get; set; }
        public string USerHK { get; set; }
        public string Symbol { get; set; }
        public Nullable<decimal> MarketValue { get; set; }
        public Nullable<System.DateTime> ValidFrom { get; set; }
        public Nullable<System.DateTime> ValidTo { get; set; }
        public Nullable<int> Quantity { get; set; }
    
        public virtual D_UserDepot D_UserDepot { get; set; }
    }
}
