//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarRental
{
    using System;
    using System.Collections.Generic;
    
    public partial class Users
    {
        public decimal id { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public decimal role_id { get; set; }
    
        public virtual Roles Roles { get; set; }
    }
}