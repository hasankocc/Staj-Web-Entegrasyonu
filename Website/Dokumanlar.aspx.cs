using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;
namespace Website
{
    public partial class Dokumanlar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            object kullanici = Session["KullaniciAdi"];
            if (kullanici == null)
            {
                Response.Write("<script>alert('Oturum Süreniz Geçmiş!');</script>");
                System.Threading.Thread.Sleep(1000);
                Server.Transfer("Login.aspx");
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

            string path = (@"C:\Users\HASAN.KOC\Desktop\server\Ek1.pdf"); //serverdan dosya yolu alınıyor.
            string name = Path.GetFileName(path); //dosya ismi alınıyor.
            string ext = Path.GetExtension(path); //dosya uzantısı alınıyor.
            string type = "";

            // dosyanın uzantısı set ediliyor.
            if (ext != null)
            {
                switch (ext.ToLower())
                {

                    case ".pdf":
                        type = "Application/pdf";
                        break;

                    case ".doc":
                    case ".rtf":
                        type = "Application/msword";
                        break;
                }
            }

            Response.AppendHeader("content-disposition", "attachment; filename=" + name);

            if (type != "")//Dosyayı indirmek için pop veriliyor.
                Response.ContentType = type;
            Response.WriteFile(path);

            Response.End(); 
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {

            string path = (@"C:\Users\HASAN.KOC\Desktop\server\Ek2.doc"); //serverdan dosya yolu alınıyor.
            string name = Path.GetFileName(path); //dosya ismi alınıyor.
            string ext = Path.GetExtension(path); //dosya uzantısı alınıyor.
            string type = "";

            // dosyanın uzantısı set ediliyor.
            if (ext != null)
            {
                switch (ext.ToLower())
                {

                    case ".pdf":
                        type = "Application/pdf";
                        break;

                    case ".doc":
                    case ".rtf":
                        type = "Application/msword";
                        break;
                }
            }

            Response.AppendHeader("content-disposition", "attachment; filename=" + name);

            if (type != "")//Dosyayı indirmek için pop veriliyor.
                Response.ContentType = type;
            Response.WriteFile(path);

            Response.End(); 
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {


            string path = (@"C:\Users\HASAN.KOC\Desktop\server\Ek3.doc"); //serverdan dosya yolu alınıyor.
            string name = Path.GetFileName(path); //dosya ismi alınıyor.
            string ext = Path.GetExtension(path); //dosya uzantısı alınıyor.
            string type = "";

            // dosyanın uzantısı set ediliyor.
            if (ext != null)
            {
                switch (ext.ToLower())
                {

                    case ".pdf":
                        type = "Application/pdf";
                        break;

                    case ".doc":
                    case ".rtf":
                        type = "Application/msword";
                        break;
                }
            }

            Response.AppendHeader("content-disposition", "attachment; filename=" + name);

            if (type != "")//Dosyayı indirmek için pop veriliyor.
                Response.ContentType = type;
            Response.WriteFile(path);

            Response.End(); 
        }
    }
}