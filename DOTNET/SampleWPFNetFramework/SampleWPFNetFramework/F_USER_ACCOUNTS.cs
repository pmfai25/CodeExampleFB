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
    
    public partial class F_USER_ACCOUNTS
    {
        public int USER_ID { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public Nullable<System.DateTime> LockoutEndDateUTC { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public string UserName { get; set; }
        public string USER_FIRST_NAME { get; set; }
        public string USER_LAST_NAME { get; set; }
        public System.DateTime VALID_FROM { get; set; }
        public System.DateTime VALID_TO { get; set; }
    }
}
