//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlogDizi.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Yorum
    {
        public int YORUMID { get; set; }
        public string KULLANICIAD { get; set; }
        public string MAIL { get; set; }
        public string YORUMICERIK { get; set; }
        public Nullable<int> YORUMBLOG { get; set; }
    
        public virtual Tbl_Blog Tbl_Blog { get; set; }
    }
}
