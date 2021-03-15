using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BlogDizi.Entity;
namespace BlogDizi
{
    public partial class KategoriDetay : System.Web.UI.Page
    {
        BlogDiziEntities db = new BlogDiziEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["KATEGORIID"]);
            var bloglar = db.Tbl_Blog.Where(x => x.BLOGKATEGORI == id).ToList();
            Repeater1.DataSource = bloglar;
            Repeater1.DataBind();

            var kategoriler = db.Tbl_Kategori.ToList();
            Repeater2.DataSource = kategoriler;
            Repeater2.DataBind();

            var bloglar2 = db.Tbl_Blog.ToList();
            Repeater3.DataSource = bloglar2;
            Repeater3.DataBind();
        }
    }
}