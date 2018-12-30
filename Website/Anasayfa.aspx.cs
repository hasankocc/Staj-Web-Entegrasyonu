using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Website
{
    public partial class Anasayfa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BLL.Staj blStaj = new BLL.Staj();
            BLL.Kullanici blkullanici = new BLL.Kullanici();
            lblTarihBilgisi.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm");
            object kullanici = Session["KullaniciAdi"];
            if (kullanici == null)
            {
                Response.Write("<script>alert('Oturum Süreniz Geçmiş!');</script>");
                System.Threading.Thread.Sleep(1000);
                Server.Transfer("Login.aspx");
            }
            string temp = Convert.ToString(kullanici);
            string tc_no;
            tc_no = blkullanici.Getir1(temp).tc_no;
            ListAnasayfa.DataSource = blStaj.ListeGetir1(tc_no);
            ListAnasayfa.DataBind();
        }

        protected void btnPdf_Click(object sender, EventArgs e)
        {
            Server.Transfer("Ek1.aspx");
        }
    }
}