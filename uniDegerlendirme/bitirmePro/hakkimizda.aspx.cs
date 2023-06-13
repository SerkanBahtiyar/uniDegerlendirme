using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using bitirmePro.Entity;
namespace bitirmePro
{
    public partial class hakkimizda : System.Web.UI.Page
    {   uniDegerlendirmeEntities1 sb=new uniDegerlendirmeEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = sb.hakkimizda.ToList();
            Repeater1.DataBind();
        }
    }
}