//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BussPassManagement.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class destination
    {
        public int DestinationID { get; set; }
        public Nullable<int> Starting_loc { get; set; }
        public Nullable<int> Ending_loc { get; set; }
    
        public virtual location location { get; set; }
    }
}