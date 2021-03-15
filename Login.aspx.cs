using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BlogDizi.Entity;
namespace BlogDizi
{
    public partial class Login : System.Web.UI.Page
    {
        BlogDiziEntities db = new BlogDiziEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var sorgu = from x in db.Tbl_Admin where x.KULLANICI == TextBox1.Text && x.SIFRE == TextBox2.Text select x;
            if (sorgu.Any())
            {
                Session.Add("KULLANICI", TextBox1.Text);
                Response.Redirect("/AdminSayfalar/Bloglar.aspx");
            }
            else
            {
                Response.Write("Hatalı giriş..");
            }
        }
    }
}