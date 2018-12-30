using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Globalization;

namespace Website
{
    public partial class H_Anasayfa : System.Web.UI.Page
    {

        DAL.Tarih yeniTarih = new DAL.Tarih();
        protected void Page_Load(object sender, EventArgs e)
        {
            object kullanici = Session["KullaniciAdi"];
            if (kullanici == null)
            {
                Response.Write("<script>alert('Oturum Süreniz Geçmiş!');</script>");
                System.Threading.Thread.Sleep(1000);
                Server.Transfer("Login.aspx");
            }

                BLL.Tarih bltarih = new BLL.Tarih();
                ListView1.DataSource = bltarih.ListeGetir();
                ListView1.DataBind();
         
        }

        protected void btnTamamla_Click(object sender, EventArgs e)
        { 
                     
           BLL.Tarih blTarih = new Tarih();
           yeniTarih.tarih1 = Calendar1.SelectedDate;
           if (blTarih.Ekle(yeniTarih))
           {
               Response.Write("<script>alert('Ekleme işlemi başarılı!');</script>");
               Server.Transfer("H_Anasayfa.aspx");
           }
           else
               Response.Write("<script>alert('Ekleme işlemi başarısız!');</script>");
               Server.Transfer("H_Anasayfa.aspx");
        }

        protected void btnSil_Click(object sender, EventArgs e)
        {
            BLL.Tarih blTarih = new Tarih();
            yeniTarih=blTarih.Getir(Calendar1.SelectedDate);
            if (blTarih.Sil(yeniTarih))
            {
                Response.Write("<script>alert('Silme işlemi başarılı!');</script>");
                Server.Transfer("H_Anasayfa.aspx");
            }
            else
                Response.Write("<script>alert('Silme işlemi başarısız!Geçerli Tarihi Seçiniz');</script>");
                Server.Transfer("H_Anasayfa.aspx");

        }

        //protected void Calendar1_DayRender1(object sender, DayRenderEventArgs e)
        //{
        //    if (e.Day.IsSelected == true)
        //    {
        //        trh = e.Day.Date;
        //    }
        //}

    /*    protected void Calendar1_SelectionChanged1(object sender, EventArgs e)
        {
            if (Session["SelectedDates"] != null)
            {
                List<DateTime> newList = (List<DateTime>)Session["SelectedDates"];
                foreach (DateTime dt in newList)
                {
                    Calendar1.SelectedDates.Add(dt);
                }
                //list.Clear();
            }
    }*/


    }
}