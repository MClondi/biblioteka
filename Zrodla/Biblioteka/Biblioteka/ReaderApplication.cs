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
    
    public partial class ReaderApplication
    {
        public ReaderApplication()
        {
            this.Status = "N";
            this.ApplicationData = new HashSet<ReaderApplicationData>();
        }
    
        public int Id { get; set; }
        public System.DateTime ApplicationDate { get; set; }
        public string Status { get; set; }
        public int ReaderId { get; set; }
    
        public virtual Reader Reader { get; set; }
        public virtual ICollection<ReaderApplicationData> ApplicationData { get; set; }
    }
}
