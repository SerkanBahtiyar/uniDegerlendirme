using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using bitirmePro.Entity;
namespace bitirmePro
{
    public partial class kategoriDetay : System.Web.UI.Page
    {    uniDegerlendirmeEntities1 sb=new uniDegerlendirmeEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["kategoriid"]);
            var uniler = sb.uni.Where(s=>s.uniKATEGORI==id).ToList();
            Repeater1.DataSource = uniler;
            Repeater1.DataBind();

            var uniler2 = sb.kategori.ToList();
            Repeater2.DataSource = uniler2;
            Repeater2.DataBind();
            var uniler3 = sb.uni.Take(5).ToList();

            Repeater3.DataSource = uniler3;
            Repeater3.DataBind();
        }
    }
}