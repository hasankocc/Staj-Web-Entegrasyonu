using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;
//using System.Net.Mail.MailMessage;

namespace Website
{
    public partial class SifremiUnuttum : System.Web.UI.Page
    {
        SmtpClient sc = new SmtpClient();
        protected void Page_Load(object sender, EventArgs e)
        {

            sc.Port = 587;
            sc.Host = "smtp.gmail.com";
            sc.EnableSsl = false;
            sc.Credentials = new NetworkCredential("postkbu@gmail.com", "R.d35789630");
   
        }

        public string CreatePassword()
        {
            int length = 8;
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        protected void btnSifremiUnuttum_Click(object sender, EventArgs e)
        {
            string sifre;
            string temp;
            DAL.Kullanici VeriCek = new DAL.Kullanici();
            BLL.Kullanici   VrCk = new BLL.Kullanici();
            string tcNo = txtTCNo.Text;
            VeriCek = VrCk.Getir(tcNo);
            if (VeriCek != null)
            {
                try
                {
                    temp = CreatePassword();
                    sifre = Kontrol.getSHA1Hash(temp);

                    VeriCek.sifre = sifre;


                    MailMessage mail = new MailMessage();

                    mail.From = new MailAddress("postkbu@gmail.com", "Karabük Üniversitesi");

                    mail.To.Add(VeriCek.eposta);

                    mail.Subject = "Yeni Şifre";
                    mail.IsBodyHtml = true;
                    mail.Body = "Şifre:" + VeriCek.sifre;


                    sc.Send(mail);
                    Response.Write("<script>alert('Kayıt Olma işlemi Başarılı!');</script>");
                    System.Threading.Thread.Sleep(1000);
                    Server.Transfer("Login.aspx");
                }
                catch (Exception ex)
                {
                    System.Threading.Thread.Sleep(1000);
                    Server.Transfer("hata.aspx");
                }
            }
            else
            {              
                lblUyari.Text = "TC Kimlik Numarası Hatalı.";
            }
           

            
        }

    }
}