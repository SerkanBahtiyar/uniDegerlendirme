using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using bitirmePro.Entity;
namespace bitirmePro
{
    public partial class uniDetay : System.Web.UI.Page
    {    uniDegerlendirmeEntities1 sb=new uniDegerlendirmeEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["uniID"]);
            var uni1 = sb.uni.Where(x => x.uniID == id).ToList();
            Repeater1.DataSource = uni1;
            Repeater1.DataBind();

            var yorumlar = sb.yorumIicerik.Where(x => x.yorumUni == id).ToList();
            Repeater2.DataSource = yorumlar;
            Repeater2.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["uniID"]);
            yorumIicerik s = new yorumIicerik();
            s.kisiAd = TextBox1.Text;
            s.kisiMail = TextBox2.Text;
            s.yorum = TextBox3.Text;
            s.yorumUni = id;
            sb.yorumIicerik.Add(s);
            sb.SaveChanges();
            Response.Redirect("uniDetay.Aspx?uniID=" + id);
        }
        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //    int id = Convert.ToInt32(Request.QueryString["uniID"]);
        //    yorumIicerik s = new yorumIicerik();
        //    s.kisiAd = TextBox1.Text;
        //    s.kisiMail = TextBox2.Text;
        //    s.yorum= TextBox3.Text;
        //    s.yorumUni= id;
        //    sb.yorumIicerik.Add(s);
        //    sb.SaveChanges();
        //    Response.Redirect("uniDetay.Aspx?uniID=" + id);
        //}
    }
}