//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Xe.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ListXe
    {
        public int ma { get; set; }
        public string ten { get; set; }
        public Nullable<int> namsx { get; set; }
        public Nullable<double> gia { get; set; }
        public string hinhanh { get; set; }
        public string loai { get; set; }
    
        public virtual LoaiXe LoaiXe { get; set; }
    }
}
