//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication15
{
    using System;
    using System.Collections.Generic;
    
    public partial class Patient_History
    {
        public int id { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public string BP { get; set; }
        public int Pulse { get; set; }
        public string indications { get; set; }
    
        public virtual Register Register { get; set; }
    }
}
