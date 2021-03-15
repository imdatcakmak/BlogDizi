using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BlogDizi.Entity;
namespace BlogDizi
{
    public partial class BlogDetay : System.Web.UI.Page
    {
        BlogDiziEntities db = new BlogDiziEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["BLOGID"]);
            var blog = db.Tbl_Blog.Where(x => x.BLOGID == id).ToList();
            Repeater1.DataSource = blog;
            Repeater1.DataBind();

            var yorumlar = db.Tbl_Yorum.Where(x => x.YORUMBLOG == id).ToList();
            Repeater2.DataSource = yorumlar;
            Repeater2.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["BLOGID"]);
            Tbl_Yorum t = new Tbl_Yorum();
            t.KULLANICIAD = TextBox1.Text;
            t.MAIL = TextBox2.Text;
            t.YORUMICERIK = TextBox3.Text;
            t.YORUMBLOG = id;
            db.Tbl_Yorum.Add(t);
            db.SaveChanges();
            Response.Redirect("BlogDetay.aspx?BLOGID=" + id);

        }
    }
}