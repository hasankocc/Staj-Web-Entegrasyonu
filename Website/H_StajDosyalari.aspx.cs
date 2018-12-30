using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Net;
using System.IO;

namespace Website
{
    public partial class H_StajDosyalari : System.Web.UI.Page
    {
        int staj_id;
        string dosyaAdresi;
        string ogr_no;
       // string tc_no;
        protected void Page_Load(object sender, EventArgs e)
        {
            object kullanici = Session["KullaniciAdi"];    
            if (kullanici == null)
            {
                Response.Write("<script>alert('Oturum Süreniz Geçmiş!');</script>");
                System.Threading.Thread.Sleep(1000);
                Server.Transfer("Login.aspx");
            }
            
            BLL.Staj blStaj = new BLL.Staj();
            if (!IsPostBack)
            {
                listStajDosyalari.DataSource = blStaj.ListeGetir();
                listStajDosyalari.DataBind();
            }
        }

        protected void btnStajDosyasi_Click(object sender, EventArgs e)
        {
            BLL.Dosya blDosya = new BLL.Dosya();
            BLL.Staj blStaj = new BLL.Staj();
            ListView lv = listStajDosyalari as ListView;
            lv.Items.Count.ToString();
            foreach (var item in lv.Items)
            {
                if (item.ItemType == ListViewItemType.DataItem)
                {

                    CheckBox checkBoxSec = item.FindControl("CheckHStaj") as CheckBox;
                    if (checkBoxSec.Checked)
                    {
                        staj_id = Convert.ToInt32(checkBoxSec.Text);
                        try
                        {
                            dosyaAdresi = blDosya.Getir(staj_id).dosya_adresi;
                            ogr_no = blStaj.ListeGetir2(staj_id).FirstOrDefault().Kullanici.ogrenci_no;
                        }
                        catch (Exception)
                        {
                            dosyaAdresi = null;
                            ogr_no = null;
                        }
                        if (dosyaAdresi != null)
                        {

                            string path = (dosyaAdresi); //serverdan dosya yolu alınıyor.
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

                            Response.AppendHeader("content-disposition", "attachment; filename=" +ogr_no +name);

                            if (type != "")//Dosyayı indirmek için pop veriliyor.
                                Response.ContentType = type;
                            Response.WriteFile(path);

                            Response.End(); 
                        }
                        else
                        {
                            Response.Write("<script>alert('Staj Dosyası yüklü değil!');</script>");
                            Server.Transfer("H_StajDosyalari.aspx");
                        }
                    }
                    else
                    {
                        //Response.Write("<script>alert('Herhangi bir seçim yapmadınız!');</script>");
                        
                    }
                }
            } 
        }
    }
}