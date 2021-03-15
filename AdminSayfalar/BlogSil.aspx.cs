using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BlogDizi.Entity;
namespace BlogDizi.AdminSayfalar
{
    public partial class BlogSil : System.Web.UI.Page
    {
        BlogDiziEntities db = new BlogDiziEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["BLOGID"]);
            var blog = db.Tbl_Blog.Find(x);
            db.Tbl_Blog.Remove(blog);
            db.SaveChanges();
            Response.Redirect("Bloglar.aspx");
        }
    }
}