//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AmgularJsTest.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Item
    {
        public int id { get; set; }
        public string Des { get; set; }
        public Nullable<decimal> Measure { get; set; }
        public int UM { get; set; }
    
        public virtual UnitsOfMeasure UnitsOfMeasure { get; set; }
    }
}
