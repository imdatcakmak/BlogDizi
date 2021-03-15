using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BlogDizi.Entity;
namespace BlogDizi.AdminSayfalar
{
    public partial class Yorumlar : System.Web.UI.Page
    {
        BlogDiziEntities db = new BlogDiziEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var yorumlar = (from x in db.Tbl_Yorum select new
            {
                x.YORUMID,
                x.KULLANICIAD,
                x.Tbl_Blog.BLOGBASLIK
            }).ToList();
            Repeater1.DataSource = yorumlar;
            Repeater1.DataBind();
        }
    }
}