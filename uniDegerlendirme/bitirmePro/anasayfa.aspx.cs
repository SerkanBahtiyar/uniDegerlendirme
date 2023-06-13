using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using bitirmePro.Entity;
namespace bitirmePro
{
    public partial class WebForm1 : System.Web.UI.Page
    {    uniDegerlendirmeEntities1 sb=new uniDegerlendirmeEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            var uniler = sb.uni.ToList();
            Repeater1.DataSource= uniler;
            Repeater1.DataBind();

            var uniler2 = sb.kategori.ToList();
            Repeater2.DataSource = uniler2;
            Repeater2.DataBind();

            var uniler3 = sb.uni.Take(5).ToList();
            Repeater3.DataSource = uniler3;
            Repeater3.DataBind();

            var uniler4 = sb.yorumIicerik.Take(3).ToList();
            Repeater4.DataSource = uniler4;
            Repeater4.DataBind();
        }
    }
}