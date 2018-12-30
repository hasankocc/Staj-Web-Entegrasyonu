using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Website
{
    public partial class H_StajBasvurulari : System.Web.UI.Page
    {
        int chck_id=0;
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
                listBasvurular.DataSource = blStaj.ListeGetir();
                listBasvurular.DataBind();
            }

        }
        
        protected void btnNotVer_Click(object sender, EventArgs e)
        {
            ListView lv = listBasvurular as ListView;
            lv.Items.Count.ToString();
            foreach (var item in lv.Items)
            {
                if (item.ItemType == ListViewItemType.DataItem)
                {
   
                    CheckBox checkBoxSec = item.FindControl("CheckHStaj") as CheckBox;
                   
                    if (checkBoxSec.Checked)
                    {
                        string chk = checkBoxSec.Text;
                        Session["stj_id"] = chk;
                        Server.Transfer("~/H_StajSonucu.aspx");
                    }
                    else
                    {
                     // Response.Write("<script>alert('Herhangi bir !');</script>");
                    }
                }
            } 
        }

        protected void btnSil_Click(object sender, EventArgs e)
        {
            ListView lv = listBasvurular as ListView;
            lv.Items.Count.ToString();
            foreach (var item in lv.Items)
            {
                if (item.ItemType == ListViewItemType.DataItem)
                {
                    CheckBox checkBoxSec = item.FindControl("CheckHStaj") as CheckBox;
                    if (checkBoxSec.Checked)
                    {
                        string chk = checkBoxSec.Text;
                        DAL.Staj silinecek = new DAL.Staj();
                        BLL.Staj blsilinecek = new BLL.Staj();
                        silinecek=blsilinecek.ListeGetir2(Convert.ToInt32(chk)).FirstOrDefault();
                        blsilinecek.Sil(silinecek);
                        Server.Transfer("~/H_StajBasvurulari.aspx");
                    }
                }
            } 
        }
   

    }
}

