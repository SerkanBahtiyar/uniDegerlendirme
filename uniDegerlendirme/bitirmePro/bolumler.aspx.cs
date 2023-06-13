using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using bitirmePro.Entity;
namespace bitirmePro
{
    public partial class bolumler : System.Web.UI.Page
    {
        uniDegerlendirmeEntities1 sb = new uniDegerlendirmeEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["bolumid"]);
            var uniler = sb.uni.Where(s => s.uniBolum == id).ToList();
            Repeater5.DataSource = uniler;
            Repeater5.DataBind();

        }
    }
}