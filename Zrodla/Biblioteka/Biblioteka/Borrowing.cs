//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Biblioteka
{
    using System;
    using System.Collections.Generic;
    
    public partial class Borrowing
    {
        public int Id { get; set; }
        public System.DateTime BorrowingDate { get; set; }
        public Nullable<System.DateTime> ReturnDate { get; set; }
        public System.DateTime ReturnTerm { get; set; }
        public int ResourceId { get; set; }
        public int ReaderId { get; set; }
        public int LibrarianId { get; set; }
    
        public virtual Resource Resource { get; set; }
        public virtual Reader Reader { get; set; }
        public virtual User User { get; set; }
    }
}
