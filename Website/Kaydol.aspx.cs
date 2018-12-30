using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Website
{
    public partial class Kaydol : System.Web.UI.Page
    {
        string mailkontrol;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnKaydol_Click(object sender, EventArgs e)
        {
            //Ön Kontrolleri Yap..

            //Yeni Kullanici Olustur.
            DAL.Kullanici yeniK = new DAL.Kullanici();
            BLL.Kullanici blKullanici = new BLL.Kullanici();
            string tempKullanici;

            yeniK.ogrenci_no = txtOgrencino.Text;
            yeniK.tc_no = txtTckimlikno.Text;
            yeniK.ad = txtAd.Text;
            yeniK.soyad = txtSoyad.Text;
            yeniK.sifre = Kontrol.getSHA1Hash(txtSifre.Text);
            tempKullanici=txtEposta.Text;
            yeniK.eposta = tempKullanici;
            try 
            {
                mailkontrol = blKullanici.Getir1(tempKullanici).eposta;
            }
            catch
            {
                mailkontrol = null;
            }

            if (mailkontrol == tempKullanici)
                Response.Write("<script>alert('Kayıt Olma işlemi Başarısız!Eposta Mevcut');</script>");
            
            else
            {
                yeniK.grup_id = 1;
                yeniK.bolum_id = DDBolum.SelectedIndex + 1;
                yeniK.kayit_durumu = false;
                yeniK.kayit_tarihi = DateTime.Now;

                if (blKullanici.Ekle(yeniK))
                {

                    Response.Write("<script>alert('Kayıt Olma işlemi Başarılı!');</script>");
                    System.Threading.Thread.Sleep(1000);
                    Server.Transfer("Login.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Kayıt Olma işlemi başarısız!');</script>");
                }
            }
            

        }

        }
    }

