//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Account
    {
        public int accountid { get; set; }
        public double balance { get; set; }
        public double debit { get; set; }
        public double credit { get; set; }
        public string paytype { get; set; }
        public string transferdetails { get; set; }
        public string status { get; set; }
        public System.DateTime createdat { get; set; }
        public int userid { get; set; }
    
        public virtual User User { get; set; }
    }
}
