using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using bitirmePro.Entity;
namespace bitirmePro.sayfalar
{
    public partial class istatistik : System.Web.UI.Page
    {   uniDegerlendirmeEntities1 sb=new uniDegerlendirmeEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = sb.uni.Count().ToString();
            Label2.Text = sb.yorumIicerik.Count().ToString();
            Label3.Text = sb.uni.Where(s=>s.uniTUR==2).Count().ToString();
            Label5.Text = sb.uni.Where(s => s.uniKATEGORI == 3).Count().ToString();
            Label4.Text = sb.uni.Where(s => s.tur.turAd== "Karadeniz Bölgesi").Count().ToString();
            Label7.Text = sb.uni.Where(s => s.tur.turAd == "Marmara Bölgesi").Count().ToString();
            Label8.Text = sb.uni.Where(s => s.tur.turAd == "İç Anadolu Bölgesi").Count().ToString();
            Label6.Text =sb.uni.Where(a=>a.uniID==( sb.yorumIicerik.GroupBy(s => s.yorumUni).OrderByDescending(s => s.Count()).Select(b=>b.Key).FirstOrDefault())).Select(o=>o.uniGBASLIK).FirstOrDefault();

        }
    }
}