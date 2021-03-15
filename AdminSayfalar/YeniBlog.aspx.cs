using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BlogDizi.Entity;
namespace BlogDizi.AdminSayfalar
{
    public partial class YeniBlog : System.Web.UI.Page
    {
        BlogDiziEntities db = new BlogDiziEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
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
        }
        }
        protected void BtnKaydet_Click(object sender, EventArgs e)
        {
            Tbl_Blog t = new Tbl_Blog();
            t.BLOGBASLIK = TxtBaslik.Text;
            t.BLOGGORSEL = TxtGorsel.Text;
            t.BLOGICERIK = TxtIcerik.Text;
            t.BLOGTARIH = DateTime.Parse(TxtTarih.Text);
            t.BLOGTUR = byte.Parse(DropDownList1.SelectedValue);
            t.BLOGKATEGORI = byte.Parse(DropDownList2.SelectedValue);
            db.Tbl_Blog.Add(t);
            db.SaveChanges();
            Response.Redirect("Bloglar.aspx");
        }
    }
}