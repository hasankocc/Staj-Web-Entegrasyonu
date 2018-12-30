﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Website
{
    public partial class H_AnaMaster : System.Web.UI.MasterPage
    {
        string temp;
        protected void Page_Load(object sender, EventArgs e)
        {
            BLL.Kullanici blkullanici = new BLL.Kullanici();
            object kullanici = Session["KullaniciAdi"];
            temp = Convert.ToString(kullanici);

            hKllnici.Text = blkullanici.Getir1(temp).ad + blkullanici.Getir1(temp).soyad;
            hKullanici.Text = blkullanici.Getir1(temp).ad + blkullanici.Getir1(temp).soyad;
        }

        protected void cikisClick(object sender, EventArgs e)
        {
            Session.Abandon();
            System.Threading.Thread.Sleep(1000);
            Server.Transfer("Login.aspx");
        }

        protected void lognClick(object sender, EventArgs e)
        {
            Session.Abandon();
            System.Threading.Thread.Sleep(1000);
            Server.Transfer("Login.aspx");
        }
    
    }

}