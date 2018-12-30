using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Website
{
    public partial class StajBasvurularim : System.Web.UI.Page
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
            BLL.Staj blStaj = new BLL.Staj();
            BLL.Kullanici blkullanici = new BLL.Kullanici();
            string temp = Convert.ToString(kullanici);
            string tc_no;
            tc_no = blkullanici.Getir1(temp).tc_no;
            if (!IsPostBack)
            {

                ListStajBasvurularim.DataSource = blStaj.ListeGetir1(tc_no);
                ListStajBasvurularim.DataBind(); 
            }        
        }

        protected void btnStajDosyasiEkle_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnSDuzenle_Click(object sender, EventArgs e)
        {
            ListView lv = ListStajBasvurularim;
            lv.Items.Count.ToString();
            foreach (var item in lv.Items)
            {
                if (item.ItemType == ListViewItemType.DataItem)
                {
                    CheckBox checkBoxSec = item.FindControl("CheckStajBasvurularim") as CheckBox;
                    if (checkBoxSec.Checked)
                    {

                        string chk = checkBoxSec.Text;
                        Session["stj_id"] = chk;
                        Server.Transfer("~/BasvuruSayfasi.aspx");

                    }
                    else
                        Response.Write("<script>alert('Herhangi bir seçim yapmadınız!');</script>"); 
                }
            } 




        }
    }
}