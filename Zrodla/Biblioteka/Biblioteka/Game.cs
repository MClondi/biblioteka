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
    
    public partial class Game : Position
    {
        public string Name { get; set; }
        public string Producer { get; set; }
        public string Edition { get; set; }
        public int GenreId { get; set; }
    
        public virtual Genre Genre { get; set; }
    }
}
