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
    
    public partial class F_ANALYSIS
    {
        public int CalculationId { get; set; }
        public decimal Parameter { get; set; }
        public string SymbolId { get; set; }
        public System.DateTime MarketTimestamp { get; set; }
        public Nullable<decimal> AnalysisValue { get; set; }
        public System.DateTime ValidFrom { get; set; }
        public System.DateTime ValidTo { get; set; }
        public Nullable<System.DateTime> ITS { get; set; }
        public Nullable<System.DateTime> UTS { get; set; }
    }
}
