using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BlogDizi.Entity;
namespace BlogDizi.AdminSayfalar
{
    public partial class YorumGuncelle : System.Web.UI.Page
    {
        BlogDiziEntities db = new BlogDiziEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["YORUMID"]);
            if (Page.IsPostBack == false)
            {
                var deger = db.Tbl_Yorum.Find(id);
                TxtBaslik.Text = deger.Tbl_Blog.BLOGBASLIK;
                TxtKullanici.Text = deger.KULLANICIAD;
                TxtIcerik.Text = deger.YORUMICERIK;
            }
        }

        protected void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["YORUMID"]);
            var yorum = db.Tbl_Yorum.Find(id);
            yorum.YORUMICERIK= TxtIcerik.Text;
            yorum.KULLANICIAD = TxtKullanici.Text;
            db.SaveChanges();
            Response.Redirect("Yorumlar.aspx");
        }
    }
}