//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EnglishCenter.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class user_cart
    {
        public int cart_id { get; set; }
        public string co_id { get; set; }
        public Nullable<int> us_id { get; set; }
    
        public virtual course cours { get; set; }
        public virtual user user { get; set; }
    }
}
