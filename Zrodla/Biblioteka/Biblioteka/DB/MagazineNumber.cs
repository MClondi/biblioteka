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
    
    public partial class MagazineNumber : Position
    {
        public Nullable<System.DateTime> PublicationDate { get; set; }
        public int Number { get; set; }
        public int MagazineId { get; set; }
    
        public virtual Magazine Magazine { get; set; }
    }
}
