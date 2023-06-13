using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using bitirmePro.Entity;
namespace bitirmePro.sayfalar
{
    public partial class uniler : System.Web.UI.Page
    {    uniDegerlendirmeEntities1 sb=new uniDegerlendirmeEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["kullanici"]==null)
            {
                Response.Redirect("~/giris.aspx");
            }
            else
            {
                Response.Write(Session["kullanici"].ToString());
            }
            //Response.Write(Session["kullanici"].ToString());
            Repeater1.DataSource = sb.uni.ToList();
            Repeater1.DataBind();
        }
    }
}