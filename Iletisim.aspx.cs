using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BlogDizi.Entity;
namespace BlogDizi
{
    public partial class Iletisim : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        BlogDiziEntities db = new BlogDiziEntities();
        protected void Button1_Click(object sender, EventArgs e)
        {
            Tbl_Iletisim t = new Tbl_Iletisim();
            t.ADSOYAD = TextBox1.Text;
            t.MAIL = TextBox2.Text;
            t.TELEFON = TextBox3.Text;
            t.KONU = TextBox4.Text;
            t.MESAJ = TextBox5.Text;
            db.Tbl_Iletisim.Add(t);
            db.SaveChanges();
        }
    }
}