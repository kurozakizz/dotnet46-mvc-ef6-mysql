//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mvc_entity.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    public partial class monster
    {
        public int id { get; set; }
        [DisplayName("Code")]
        public string code { get; set; }
        [DisplayName("Pokemon Name")]
        public string name { get; set; }
        [DisplayName("Element")]
        public string element { get; set; }
        [DisplayName("Weight")]
        public decimal weight { get; set; }
    }
}
