using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;


namespace Website
{
    public partial class Login : System.Web.UI.Page
    {
        protected void btnGirisYap_Click(object sender, EventArgs e)
        {
            string sifre = txtSifre.Text;
            sifre = Kontrol.getSHA1Hash(sifre);
            string eposta = txtEposta.Text;
            //Ön Kontroller.
            
            //Giriş Kontrol
            Kullanici blKullanici = new Kullanici();

            if (blKullanici.GirisKontrol(eposta, sifre))
            {
                //Log tut.
                if (blKullanici.Getir1(eposta).grup_id != 2)
                {
                    Session.Timeout = 20;
                    Session.Add("KullaniciAdi", txtEposta.Text);

                    Server.Transfer("Anasayfa.aspx");
                }
                else if (blKullanici.Getir1(eposta).grup_id == 2) 
                {
                    Session.Timeout = 20;
                    Session.Add("KullaniciAdi", txtEposta.Text);
                    Server.Transfer("H_Anasayfa.aspx");     
                }
            }
            else
            {
                Response.Write("<script>alert('Kullanıcı Adı veya Şifre Yanlış!')</script>");
            }
            

        }
    }
}