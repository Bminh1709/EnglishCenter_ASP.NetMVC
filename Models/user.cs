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
    using System.ComponentModel.DataAnnotations;

    public partial class user
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public user()
        {
            this.orders = new HashSet<order>();
            this.user_cart = new HashSet<user_cart>();
            this.user_wait = new HashSet<user_wait>();
        }
    
        public int us_id { get; set; }
        [Required(ErrorMessage = "First name is required")]
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters")]
        public string us_firstname { get; set; }
        public string us_lastname { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        // [RegularExpression(@"/^[a-zA-Z]\w*(\w+)*\@\w+(\.\w{2,3})$/", ErrorMessage = "Invalid email address!")]
        public string us_gmail { get; set; }
        [StringLength(50, MinimumLength = 8, ErrorMessage = "Password length has to be from 8")]
        public string us_pass { get; set; }
        // [RegularExpression(@"^(\(0\d{1,3}\)\d{7})|(0\d{9,10})$",ErrorMessage = "Invalid phone number!")]
        [Phone(ErrorMessage = "Invalid phone number!")]
        public string us_phone { get; set; }
        public string us_gender { get; set; }
        public string us_img { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<order> orders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<user_cart> user_cart { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<user_wait> user_wait { get; set; }
    }
}
