using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using bitirmePro.Entity;
namespace bitirmePro.sayfalar
{
    public partial class yorumSil : System.Web.UI.Page
    {    uniDegerlendirmeEntities1 sb=new uniDegerlendirmeEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(Request.QueryString["yorumid"]);
            var yorum = sb.yorumIicerik.Find(s);
            sb.yorumIicerik.Remove(yorum);
            sb.SaveChanges();
            Response.Redirect("yorum.Aspx");
        }
    }
}