using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BlogDizi.Entity;
namespace BlogDizi.AdminSayfalar
{
    public partial class Bloglar : System.Web.UI.Page
    {
        BlogDiziEntities db = new BlogDiziEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Write(Session["KULLANICI"].ToString());
            if (Session["KULLANICI"] == null)
            {
                Response.Redirect("~/Login.aspx");
            }
            else
            {
                Response.Write("Hoşgeldiniz :" + Session["KULLANICI"].ToString());
            }
            Repeater1.DataSource = db.Tbl_Blog.ToList();
            Repeater1.DataBind();
        }
    }
}