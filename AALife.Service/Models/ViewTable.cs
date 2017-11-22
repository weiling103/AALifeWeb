//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace AALife.Service.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ViewTable
    {
        public int ViewID { get; set; }
        public int PageID { get; set; }
        public int UserID { get; set; }
        public System.DateTime DateStart { get; set; }
        public System.DateTime DateEnd { get; set; }
        public string Portal { get; set; }
        public string Version { get; set; }
        public string Browser { get; set; }
        public Nullable<int> Width { get; set; }
        public Nullable<int> Height { get; set; }
        public string IP { get; set; }
        public byte Synchronize { get; set; }
        public string Remark { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string Network { get; set; }
    
        public virtual ViewPageTable ViewPageTable { get; set; }
        public virtual UserTable UserTable { get; set; }
    }
}