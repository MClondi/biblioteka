//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Biblioteka.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Publisher
    {
        public Publisher()
        {
            this.BookEdition = new HashSet<BookEdition>();
            this.Magazine = new HashSet<Magazine>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<BookEdition> BookEdition { get; set; }
        public virtual ICollection<Magazine> Magazine { get; set; }
    }
}
