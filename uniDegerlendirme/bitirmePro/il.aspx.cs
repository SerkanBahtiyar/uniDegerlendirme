using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using bitirmePro.Entity;
namespace bitirmePro
{
    public partial class il : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
         uniDegerlendirmeEntities1 sb=new uniDegerlendirmeEntities1();
        protected void Button1_Click(object sender, EventArgs e)
        {
            iletisim o=new iletisim();
            o.adSoyad = TextBox1.Text;
            o.konu = TextBox2.Text;
            o.mail= TextBox3.Text;
            o.telefon = TextBox4.Text;
            o.mesaj= TextBox5.Text;
            sb.iletisim.Add(o);
            sb.SaveChanges();
        }
    }
}