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
    
    public partial class Reservation
    {
        public int Id { get; set; }
        public System.DateTime RealizationDate { get; set; }
        public int ResourceId { get; set; }
        public int ReaderId { get; set; }
    
        public virtual Resource Resource { get; set; }
        public virtual Reader Reader { get; set; }
    }
}
