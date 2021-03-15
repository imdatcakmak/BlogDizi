using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BlogDizi.Entity;
namespace BlogDizi.AdminSayfalar
{
    public partial class YorumSil : System.Web.UI.Page
    {
        BlogDiziEntities db = new BlogDiziEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["YORUMID"]);
            var yorum = db.Tbl_Yorum.Find(x);
            db.Tbl_Yorum.Remove(yorum);
            db.SaveChanges();
            Response.Redirect("Yorumlar.aspx");
        }
    }
}