using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
namespace Website
{
    public partial class H_StajSonucu : System.Web.UI.Page
    {
        DAL.Staj yeniS = new DAL.Staj();
        DAL.Staj eskiS = new DAL.Staj();
        object kullanici;
        int bolum_id;
        int staj_id;
        string ogrenci;
        protected void Page_Load(object sender, EventArgs e)
        {
            kullanici = Session["KullaniciAdi"];
            if (kullanici == null)
            {
                Response.Write("<script>alert('Oturum Süreniz Geçmiş!');</script>");
                System.Threading.Thread.Sleep(1000);
                Server.Transfer("Login.aspx");
            }
            staj_id = Convert.ToInt32(Session["stj_id"]);
            BLL.Kullanici blkullanici = new BLL.Kullanici();
            BLL.Staj blstaj = new BLL.Staj();
            BLL.Bolum blbolum = new BLL.Bolum();
            ogrenci = blstaj.ListeGetir2(staj_id).FirstOrDefault().tc_no;
            string temp = ogrenci;
            LabelOgrNo.Text = blkullanici.Getir(temp).ogrenci_no;
            bolum_id = blkullanici.Getir(temp).bolum_id;
            LabelBolum.Text = blbolum.Getir(bolum_id).bolum_adi;
            LabelAdsoy.Text = blkullanici.Getir(temp).ad + blkullanici.Getir(temp).soyad;
        }

        protected void btnNotVer_Click(object sender, EventArgs e)
        {
            Staj blStaj = new Staj();
            eskiS = blStaj.ListeGetir2(staj_id).FirstOrDefault();
            yeniS = blStaj.ListeGetir2(staj_id).FirstOrDefault();
            yeniS.staj_sonuc = Convert.ToInt16(finalnotu.Text);
            yeniS.staj_yorum = yorum.Text;
            if (blStaj.Duzenle(eskiS, yeniS))
            {
                Response.Write("<script>alert('Not verme işlemi Başarılı!');</script>");
                System.Threading.Thread.Sleep(1000);
                Server.Transfer("H_StajBasvurulari.aspx");
            }
            else
            {
                Response.Write("<script>alert('Not verme işlemi başarısız!');</script>");
            }
            
            //Response.Write("<script>alert('"+staj_id+"');</script>");
        }

        protected void btnIptalEt_Click(object sender, EventArgs e)
        {
            Server.Transfer("H_StajBasvurulari.aspx");
        }
    }
}