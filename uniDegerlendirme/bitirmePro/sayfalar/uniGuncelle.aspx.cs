using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using bitirmePro.Entity;
namespace bitirmePro.sayfalar
{
    public partial class uniGuncelle : System.Web.UI.Page
    {    uniDegerlendirmeEntities1 sb=new uniDegerlendirmeEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            int s = int.Parse(Request.QueryString["UniID"]);
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
                var deger = sb.uni.Find(s);
                TextBox1.Text = deger.uniGBASLIK;
                TextBox2.Text = deger.uniTARIH.ToString();
                TextBox3.Text = deger.uniGORSEL;
                TextBox4.Text = deger.uniICERIK;
                DropDownList1.SelectedValue = deger.uniTUR.ToString();
                DropDownList2.SelectedValue = deger.uniKATEGORI.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int s = int.Parse(Request.QueryString["UniID"]);
            var uni = sb.uni.Find(s);
            uni.uniGBASLIK = TextBox1.Text;
            uni.uniTARIH = DateTime.Parse(TextBox2.Text);
            uni.uniGORSEL = TextBox3.Text;
            uni.uniICERIK = TextBox4.Text;
            uni.uniTUR = byte.Parse(DropDownList1.SelectedValue);
            uni.uniKATEGORI = byte.Parse(DropDownList2.SelectedValue);
            sb.SaveChanges();
            Response.Redirect("uniler.Aspx");
        }
    }
}