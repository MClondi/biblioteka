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
    
    public partial class Magazine
    {
        public Magazine()
        {
            this.MagazineNumber = new HashSet<MagazineNumber>();
        }
    
        public int Id { get; set; }
        public string Title { get; set; }
        public int GenreId { get; set; }
        public int PublisherId { get; set; }
    
        public virtual Genre Genre { get; set; }
        public virtual Publisher Publisher { get; set; }
        public virtual ICollection<MagazineNumber> MagazineNumber { get; set; }
    }
}
