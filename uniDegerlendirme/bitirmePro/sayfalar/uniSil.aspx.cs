using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using bitirmePro.Entity;
namespace bitirmePro.sayfalar
{
    public partial class uniSil : System.Web.UI.Page
    {   uniDegerlendirmeEntities1 sb=new uniDegerlendirmeEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["uniID"]);
            var uni = sb.uni.Find(x);
            sb.uni.Remove(uni);
            sb.SaveChanges();
            Response.Redirect("uniler.Aspx");
        }
    }
}