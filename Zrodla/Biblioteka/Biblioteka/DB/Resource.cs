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
    
    public partial class Resource
    {
        public Resource()
        {
            this.Borrowing = new HashSet<Borrowing>();
            this.Reservation = new HashSet<Reservation>();
        }
    
        public int Id { get; set; }
        public int Amount { get; set; }
        public string Category { get; set; }
        public int PositionId { get; set; }
    
        public virtual ICollection<Borrowing> Borrowing { get; set; }
        public virtual ICollection<Reservation> Reservation { get; set; }
        public virtual Position Position { get; set; }
    }
}