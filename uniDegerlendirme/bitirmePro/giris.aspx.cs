using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using bitirmePro.Entity;
namespace bitirmePro
{
    public partial class giris : System.Web.UI.Page
    {   uniDegerlendirmeEntities1 sb=new uniDegerlendirmeEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var sorgu = from x in sb.kullanici
                        where
                       x.kullanıci == TextBox1.Text && x.sifre == TextBox2.Text
                        select x;
            if (sorgu.Any())
            {
                Session.Add("kullanici", TextBox1.Text);
                Response.Redirect("/sayfalar/uniler.Aspx");
            }
            else
            {
                Response.Write("Hata");
            }
        }
    }
}