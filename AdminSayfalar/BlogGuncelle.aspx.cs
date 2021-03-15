using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BlogDizi.Entity;
namespace BlogDizi.AdminSayfalar
{
    public partial class BlogGuncelle : System.Web.UI.Page
    {
        BlogDiziEntities db = new BlogDiziEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["BLOGID"]);
            if (Page.IsPostBack == false)
            {


                var turler = (from x in db.Tbl_Tur
                              select new
                              {
                                  x.TURAD,
                                  x.TURID
                              }).ToList();
                DropDownList1.DataSource = turler;
                DropDownList1.DataBind();

                var kategoriler = (from y in db.Tbl_Kategori
                                   select new
                                   {
                                       y.KATEGORIAD,
                                       y.KATEGORIID

                                   }).ToList();
                DropDownList2.DataSource = kategoriler;
                DropDownList2.DataBind();

                var deger = db.Tbl_Blog.Find(id);
                TxtBaslik.Text = deger.BLOGBASLIK;
                TxtTarih.Text = deger.BLOGTARIH.ToString();
                TxtGorsel.Text = deger.BLOGGORSEL;
                TxtIcerik.Text = deger.BLOGICERIK;
                DropDownList1.SelectedValue = deger.BLOGTUR.ToString();
                DropDownList2.SelectedValue = deger.BLOGKATEGORI.ToString();

            }
        }

        protected void BtnKaydet_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["BLOGID"]);
            var blog = db.Tbl_Blog.Find(id);
            blog.BLOGBASLIK = TxtBaslik.Text;
            blog.BLOGGORSEL = TxtGorsel.Text;
            blog.BLOGICERIK = TxtIcerik.Text;
            blog.BLOGTARIH = DateTime.Parse(TxtTarih.Text);
            blog.BLOGTUR = byte.Parse(DropDownList1.SelectedValue);
            blog.BLOGKATEGORI = byte.Parse(DropDownList2.SelectedValue);
            db.SaveChanges();
            Response.Redirect("Bloglar.aspx");
        }
    }
}
    
