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
    
    public partial class F_AnalysisData
    {
        public int AnalysisId { get; set; }
        public string Symbol { get; set; }
        public Nullable<decimal> AnalysisValue { get; set; }
        public System.DateTime Market_Timestamp { get; set; }
        public System.DateTime ValidFrom { get; set; }
        public System.DateTime ValidTo { get; set; }
        public Nullable<System.DateTime> ITS { get; set; }
        public Nullable<System.DateTime> UTS { get; set; }
        public string Status { get; set; }
    }
}
