using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BlogDizi.Entity;
namespace BlogDizi.AdminSayfalar
{
    public partial class Istatistik : System.Web.UI.Page
    {
        BlogDiziEntities db = new BlogDiziEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = db.Tbl_Blog.Count().ToString();
            Label2.Text = db.Tbl_Yorum.Count().ToString();
            Label3.Text = db.Tbl_Blog.Where(x => x.BLOGTUR == 2).Count().ToString();
            Label4.Text = db.Tbl_Blog.Where(x => x.BLOGTUR == 1).Count().ToString();
            Label5.Text = db.Tbl_Blog.Where(x => x.BLOGTUR == 3).Count().ToString();
            Label6.Text = db.Tbl_Blog.Where(y=>y.BLOGID== (db.Tbl_Yorum.GroupBy(x => x.YORUMBLOG).OrderByDescending(x =>x.Count()).Select(z => z.Key).FirstOrDefault())).Select(k=>k.BLOGBASLIK).FirstOrDefault();
        }
    }
}