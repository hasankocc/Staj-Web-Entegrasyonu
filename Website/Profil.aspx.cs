using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Website
{
    public partial class Profil : System.Web.UI.Page
    {
        object kullanici;
        protected void Page_Load(object sender, EventArgs e)
        {
           int bolum_id; 
           kullanici = Session["KullaniciAdi"];
           if (kullanici == null)
           {
               Response.Write("<script>alert('Oturum Süreniz Geçmiş!');</script>");
               System.Threading.Thread.Sleep(1000);
               Server.Transfer("Login.aspx");
           }
           BLL.Kullanici blkullanici = new BLL.Kullanici();
           BLL.Bolum blbolum = new BLL.Bolum();
           string temp = kullanici.ToString();
           labelOgrno.Text = blkullanici.Getir1(temp).ogrenci_no;
           bolum_id  = blkullanici.Getir1(temp).bolum_id;
           labelEposta.Text = blkullanici.Getir1(temp).eposta;
           labelBolum.Text = blbolum.Getir(bolum_id).bolum_adi;
           Labeladsoy.Text = blkullanici.Getir1(temp).ad + blkullanici.Getir1(temp).soyad;
        }

        protected void btnDuzenle_Click(object sender, EventArgs e)
        {
           
        }

        protected void btnDegistir_Click(object sender, EventArgs e)
        {
            DAL.Kullanici yeniK = new DAL.Kullanici();
            DAL.Kullanici eskiK = new DAL.Kullanici();
            Kullanici blKullanici = new Kullanici();
            string yenisifre;
            string confirm;
            string sifre = eskiSifre.Text;
            sifre = Kontrol.getSHA1Hash(sifre);
            string eposta = kullanici.ToString();

            if (blKullanici.GirisKontrol(eposta, sifre)) 
            {
                yenisifre = yeniSifre.Text;
                confirm = sifreDogrula.Text;
                if (yenisifre == confirm) 
                {
                   eskiK=blKullanici.Getir1(eposta);
                   yeniK.sifre=Kontrol.getSHA1Hash(yenisifre);
                   if(blKullanici.Duzenle(eskiK,yeniK))
                   {
                     Response.Write("<script>alert('Şifre değiştirme işlemi Başarılı!');</script>");
                     System.Threading.Thread.Sleep(1000);
                   }
                   else
                   {
                     Response.Write("<script>alert('Şifre değiştirme işlemi başarısız!');</script>");
                   }
                
                }
                else
                   Response.Write("<script>alert('Şifre Doğrulanmadı!')</script>");
            }     
                else
                   Response.Write("<script>alert('Eski Şifreniz Yanlış!Giriş sayfasındaki Şifre Unuttum linkinden yeni şifre alabilirsiniz')</script>");
            }
        }
    }
