//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace prjDemoEF.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comment
    {
        public string maComment { get; set; }
        public string noiDung { get; set; }
        public Nullable<System.DateTime> ngayComment { get; set; }
        public string maBaiViet { get; set; }
        public string maTaiKhoan { get; set; }
    
        public virtual BaiViet BaiViet { get; set; }
        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}
