using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using bitirmePro.Entity;
namespace bitirmePro.sayfalar
{
    public partial class yorumGuncelle : System.Web.UI.Page
    {
        uniDegerlendirmeEntities1 sb = new uniDegerlendirmeEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            int s = int.Parse(Request.QueryString["yorumid"]);
            if (Page.IsPostBack == false)
            {
               
               
                var yorum = sb.yorumIicerik.Find(s);
                TextBox1.Text = yorum.uni.uniGBASLIK;
                TextBox2.Text = yorum.kisiAd;
                TextBox4.Text = yorum.yorum;
         
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int s = int.Parse(Request.QueryString["yorumid"]);
            var yorum = sb.yorumIicerik.Find(s);
            yorum.kisiMail = TextBox1.Text;
            yorum.yorum = TextBox4.Text;
          
            sb.SaveChanges();
            Response.Redirect("yorum.Aspx");
        }
    }
}