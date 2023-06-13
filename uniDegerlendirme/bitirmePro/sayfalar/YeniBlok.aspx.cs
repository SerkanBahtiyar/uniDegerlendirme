using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using bitirmePro.Entity;
namespace bitirmePro.sayfalar
{
    public partial class YeniBlok : System.Web.UI.Page
    {    uniDegerlendirmeEntities1 sb=new uniDegerlendirmeEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                var turler = (from x in sb.tur
                              select new
                              {
                                  x.turAd,
                                  x.turid
                              }).ToList();
                DropDownList1.DataSource = turler;
                DropDownList1.DataBind();

                var kategoriler = (from x in sb.kategori
                                   select new
                                   {
                                       x.kategoriAd,
                                       x.kategoriid
                                   }).ToList();
                DropDownList2.DataSource = kategoriler;
                DropDownList2.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            uni s = new uni();
            s.uniGBASLIK = TextBox1.Text;
            s.uniGORSEL = TextBox3.Text;
            s.uniICERIK= TextBox4.Text;
            s.uniTARIH = DateTime.Parse(TextBox2.Text);
            s.uniTUR = byte.Parse(DropDownList1.SelectedValue);
            s.uniKATEGORI = byte.Parse(DropDownList2.SelectedValue);
            sb.uni.Add(s);
            sb.SaveChanges();
            Response.Redirect("uniler.Aspx");
        }
    }
}