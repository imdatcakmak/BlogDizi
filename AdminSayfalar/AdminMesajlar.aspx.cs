using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BlogDizi.Entity;
namespace BlogDizi.AdminSayfalar
{
    public partial class Adminiletisim : System.Web.UI.Page
    {
        BlogDiziEntities db = new BlogDiziEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var mesajlar = db.Tbl_Iletisim.ToList();
            Repeater1.DataSource = mesajlar;
            Repeater1.DataBind();
        }
    }
}