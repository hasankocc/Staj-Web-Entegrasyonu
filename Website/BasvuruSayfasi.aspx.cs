using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Website
{
    public partial class BasvuruSayfasi : System.Web.UI.Page
    {
        DateTime baslangic_tarihi;
        DateTime bitis_tarihi;
        string staj_id;
        string tc_no;
        string stajkodu;
        int firm_id;
        int yet_id;
        int drm_id;
        DAL.Staj yeniStaj = new DAL.Staj();
        DAL.Firma yeniFirma = new DAL.Firma();
        DAL.Yetkili yeniYetkili = new DAL.Yetkili();
        DAL.Staj yniStaj = new DAL.Staj();
        DAL.Firma yniFirma = new DAL.Firma();
        DAL.Yetkili yniYetkili = new DAL.Yetkili();
        DAL.Staj eskiStaj = new DAL.Staj();
        DAL.Firma eskiFirma = new DAL.Firma();
        DAL.Yetkili eskiYetkili = new DAL.Yetkili();
        int trhsnc = 0;
        DateTime baslangicTarihi;
        protected void Page_Load(object sender, EventArgs e)
        {

                object kullanici = Session["KullaniciAdi"];
                if (kullanici == null)
                {
                    Response.Write("<script>alert('Oturum Süreniz Geçmiş!');</script>");
                    System.Threading.Thread.Sleep(1000);
                    Server.Transfer("Login.aspx");
                }
                string temp = Convert.ToString(kullanici);
                BLL.Kullanici blkullanici = new BLL.Kullanici();
                BLL.Firma blfirma = new BLL.Firma();
                BLL.Yetkili blyetkili = new BLL.Yetkili();
                BLL.Staj blstaj = new BLL.Staj();
                tc_no = blkullanici.Getir1(temp).tc_no;

                try
                {
                    staj_id = Session["stj_id"].ToString();
                }
                catch (Exception ex) 
                {
                    staj_id = null;
                }
                if (staj_id != null) 
                {
                    firm_id = blstaj.ListeGetir2(Convert.ToInt32(staj_id)).FirstOrDefault().firma_id;
                    yet_id = blstaj.ListeGetir2(Convert.ToInt32(staj_id)).FirstOrDefault().yetkili_id;
                    drm_id = blstaj.ListeGetir2(Convert.ToInt32(staj_id)).FirstOrDefault().durum_id;
                    if (!IsPostBack)
                    {
                        calisanelemansayisi.Text = Convert.ToString(blstaj.ListeGetir2(Convert.ToInt32(staj_id)).FirstOrDefault().calisan_eleman_sayisi);
                        lisanspersonelsayisi.Text = Convert.ToString(blstaj.ListeGetir2(Convert.ToInt32(staj_id)).FirstOrDefault().lisans_mezunu_personel_sayisi);
                        muhendissayisi.Text = Convert.ToString(blstaj.ListeGetir2(Convert.ToInt32(staj_id)).FirstOrDefault().bolumde_calisan_muhendis_sayisi);
                        stajkontenjani.Text = Convert.ToString(blstaj.ListeGetir2(Convert.ToInt32(staj_id)).FirstOrDefault().staj_ogrencisi_kontenjani);
                        makineparki.Text = Convert.ToString(blstaj.ListeGetir2(Convert.ToInt32(staj_id)).FirstOrDefault().makine_parki);
                        sosyalhizmetler.Text = Convert.ToString(blstaj.ListeGetir2(Convert.ToInt32(staj_id)).FirstOrDefault().sosyal_hizmetler);
                        eklemekistedikleriniz.Text = Convert.ToString(blstaj.ListeGetir2(Convert.ToInt32(staj_id)).FirstOrDefault().eklemek_istedikleriniz);
                        cmrtesidahildir.Checked = Convert.ToBoolean(blstaj.ListeGetir2(Convert.ToInt32(staj_id)).FirstOrDefault().staj_ctesi);
                        firmadi.Text = blfirma.Getir(firm_id).adi;
                        tel.Text = blfirma.Getir(firm_id).tel;
                        adres.Text = blfirma.Getir(firm_id).adresi;
                        yetkiliadsoy.Text = blyetkili.Getir(yet_id).ad_soyad;
                        yetkilimevki.Text = blyetkili.Getir(yet_id).gorev;
                        email.Text = blyetkili.Getir(yet_id).yetkili_eposta;

                    }

                    eskiStaj = blstaj.ListeGetir2(Convert.ToInt32(staj_id)).FirstOrDefault();
                    eskiFirma = blfirma.Getir(firm_id);
                    eskiYetkili = blyetkili.Getir(yet_id);
                }
                try
                {             
                    stajkodu = blstaj.ListeGetir1(tc_no).FirstOrDefault().staj_kodu;
                }
                catch (Exception ex)
                {
                    stajkodu = null;
                }
         }
        

        protected void btnBasvuruTamamla_Click(object sender, EventArgs e)
        {
           
            if (staj_id != null)
            {
                if (drm_id == 5)
                {
                    BLL.Firma bllFirma = new BLL.Firma();
                    BLL.Yetkili bllYetkili = new BLL.Yetkili();
                    BLL.Staj bllStaj = new BLL.Staj();
                    BLL.Tarih bllTarih = new BLL.Tarih();


                    yniFirma.adi = firmadi.Text;
                    yniFirma.tel = tel.Text;
                    yniFirma.adresi = adres.Text;
                    // blFirma.Ekle(yeniFirma);


                    yniYetkili.ad_soyad = yetkiliadsoy.Text;
                    yniYetkili.gorev = yetkilimevki.Text;
                    yniYetkili.yetkili_eposta = email.Text;
                    //  yeniYetkili.firma_id = blFirma.Getir1(firmadi.Text).firma_id;
                    // blYetkili.Ekle(yeniYetkili);


                    try { yniStaj.calisan_eleman_sayisi = short.Parse(calisanelemansayisi.Text); }
                    catch { yniStaj.calisan_eleman_sayisi = 0; }
                    try { yniStaj.lisans_mezunu_personel_sayisi = short.Parse(lisanspersonelsayisi.Text); }
                    catch { yniStaj.lisans_mezunu_personel_sayisi = 0; }
                    try { yniStaj.bolumde_calisan_muhendis_sayisi = short.Parse(muhendissayisi.Text); }
                    catch { yniStaj.bolumde_calisan_muhendis_sayisi = 0; }
                    try { yniStaj.staj_ogrencisi_kontenjani = short.Parse(stajkontenjani.Text); }
                    catch { yniStaj.staj_ogrencisi_kontenjani = 0; }
                    try { yniStaj.makine_parki = short.Parse(makineparki.Text); }
                    catch { yniStaj.makine_parki = 0; }
                    yniStaj.sosyal_hizmetler = sosyalhizmetler.Text;
                    yniStaj.eklemek_istedikleriniz = eklemekistedikleriniz.Text;
                    baslangic_tarihi = calBaslangic.SelectedDate;
                    bitis_tarihi = calBitis.SelectedDate;
                    yniStaj.staj_baslangic = baslangic_tarihi;
                    yniStaj.staj_bitis = bitis_tarihi;
                    yniStaj.tc_no = tc_no;
                    yniStaj.durum_id = 1;
                    yniStaj.staj_kodu = tc_no.Substring(8);
                    yniStaj.staj_sonuc = 0;

                    if (cmrtesidahildir.Checked)
                    {
                        trhsnc = bllTarih.TarihHesapla1(baslangic_tarihi, bitis_tarihi);
                        yniStaj.staj_ctesi = true;
                        if (trhsnc == 20 && bllStaj.Duzenle(eskiStaj, yniStaj) && bllFirma.Duzenle(eskiFirma, yniFirma) && bllYetkili.Duzenle(eskiYetkili, yniYetkili))
                        {
                            Response.Write("<script>alert('Düzeltme işlemi Başarılı!');</script>");
                            System.Threading.Thread.Sleep(1000);
                            Server.Transfer("Anasayfa.aspx");
                        }
                        else
                        {
                            Response.Write("<script>alert('Düzeltme işlemi başarısız!Tarihleri kontrol ediniz');</script>");
                            //      blYetkili.Sil(yeniYetkili);
                            //    blFirma.Sil(yeniFirma);

                        }
                    }
                    else
                    {
                        trhsnc = bllTarih.TarihHesapla(baslangic_tarihi, bitis_tarihi);
                        yniStaj.staj_ctesi = false;
                        if (trhsnc == 20 && bllStaj.Duzenle(eskiStaj, yniStaj) && bllFirma.Duzenle(eskiFirma, yniFirma) && bllYetkili.Duzenle(eskiYetkili, yniYetkili))
                        {
                            Response.Write("<script>alert('Düzeltme işlemi Başarılı!');</script>");
                            System.Threading.Thread.Sleep(1000);
                            Server.Transfer("Anasayfa.aspx");
                        }
                        else
                        {
                            Response.Write("<script>alert('Düzeltme işlemi başarısız!Tarihler kontrol ediniz');</script>");
                            //      blYetkili.Sil(yeniYetkili);
                            //    blFirma.Sil(yeniFirma);

                        }
                    }
                    

                }
                else
                    Response.Write("<script>alert('Başvurunuz Tamamlanmıştır.Değişiklik yapamazsınız!');</script>");
            
                
            }

            else if(stajkodu == null)
            {

            BLL.Firma blFirma = new BLL.Firma();
            BLL.Yetkili blYetkili = new BLL.Yetkili();
            BLL.Tarih blTarih = new BLL.Tarih();
            BLL.Staj blStaj = new BLL.Staj();

            yeniFirma.adi = firmadi.Text;
            yeniFirma.tel = tel.Text;
            yeniFirma.adresi = adres.Text;
            blFirma.Ekle(yeniFirma);

            
            yeniYetkili.ad_soyad = yetkiliadsoy.Text;
            yeniYetkili.gorev = yetkilimevki.Text;
            yeniYetkili.yetkili_eposta = email.Text;
            yeniYetkili.firma_id = blFirma.Getir1(firmadi.Text).firma_id;
            blYetkili.Ekle(yeniYetkili);

            try { yeniStaj.calisan_eleman_sayisi = short.Parse(calisanelemansayisi.Text); }
            catch { yeniStaj.calisan_eleman_sayisi = 0; }
            try { yeniStaj.lisans_mezunu_personel_sayisi = short.Parse(lisanspersonelsayisi.Text); }
            catch { yeniStaj.lisans_mezunu_personel_sayisi = 0; }
            try { yeniStaj.bolumde_calisan_muhendis_sayisi = short.Parse(muhendissayisi.Text); }
            catch { yeniStaj.bolumde_calisan_muhendis_sayisi = 0; }
            try { yeniStaj.staj_ogrencisi_kontenjani = short.Parse(stajkontenjani.Text); }
            catch { yeniStaj.staj_ogrencisi_kontenjani = 0; }
            try { yeniStaj.makine_parki = short.Parse(makineparki.Text); }
            catch { yeniStaj.makine_parki = 0; }
            yeniStaj.sosyal_hizmetler = sosyalhizmetler.Text;
            yeniStaj.eklemek_istedikleriniz = eklemekistedikleriniz.Text;
            baslangic_tarihi = calBaslangic.SelectedDate;
            bitis_tarihi = calBitis.SelectedDate;
            yeniStaj.staj_baslangic = baslangic_tarihi;
            yeniStaj.staj_bitis = bitis_tarihi;
            yeniStaj.yetkili_id = blYetkili.Getir1(yeniYetkili.firma_id).yetkili_id; ;
            yeniStaj.tc_no = tc_no;
            yeniStaj.firma_id = yeniYetkili.firma_id;
            yeniStaj.durum_id = 1;
            yeniStaj.staj_kodu = tc_no.Substring(8);
            yeniStaj.staj_sonuc = 0;

            if (cmrtesidahildir.Checked)
            {
                trhsnc = blTarih.TarihHesapla1(baslangic_tarihi, bitis_tarihi);
                yeniStaj.staj_ctesi = true;
                if (trhsnc == 20 && blStaj.Ekle(yeniStaj))
                {
                    Response.Write("<script>alert('Kayıt işlemi Başarılı!');</script>");
                    System.Threading.Thread.Sleep(1000);
                    Server.Transfer("Anasayfa.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Kayıt işlemi başarısız!Tarihleri kontrol ediniz');</script>");
                    blYetkili.Sil(yeniYetkili);
                    blFirma.Sil(yeniFirma);

                }
            }
            else
            {
                trhsnc = blTarih.TarihHesapla(baslangic_tarihi, bitis_tarihi);
                yeniStaj.staj_ctesi = false;
                if (trhsnc == 20 && blStaj.Ekle(yeniStaj) )
                {
                    Response.Write("<script>alert('Kayıt işlemi Başarılı!');</script>");
                    System.Threading.Thread.Sleep(1000);
                    Server.Transfer("Anasayfa.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Kayıt işlemi başarısız!Tarihleri kontrol ediniz');</script>");
                    blYetkili.Sil(yeniYetkili);
                    blFirma.Sil(yeniFirma);

                }
            }
            }
            else 
                Response.Write("<script>alert('Daha önce Kayıt işlemi yapılmıştır!');</script>");

        }
        protected void btnTaslakKaydet_Click(object sender, EventArgs e)
        {
            
            if (staj_id != null)
            {
                if (drm_id == 5)
                {
                    BLL.Firma bllFirma = new BLL.Firma();
                    BLL.Yetkili bllYetkili = new BLL.Yetkili();
                    BLL.Staj bllStaj = new BLL.Staj();
                    BLL.Tarih bllTarih = new BLL.Tarih();
                    
                    yniFirma.adi = firmadi.Text;
                    yniFirma.tel = tel.Text;
                    yniFirma.adresi = adres.Text;
                    // blFirma.Ekle(yeniFirma);


                    yniYetkili.ad_soyad = yetkiliadsoy.Text;
                    yniYetkili.gorev = yetkilimevki.Text;
                    yniYetkili.yetkili_eposta = email.Text;
                    //  yeniYetkili.firma_id = blFirma.Getir1(firmadi.Text).firma_id;
                    // blYetkili.Ekle(yeniYetkili);


                    try { yniStaj.calisan_eleman_sayisi = short.Parse(calisanelemansayisi.Text); }
                    catch { yniStaj.calisan_eleman_sayisi = 0; }
                    try { yniStaj.lisans_mezunu_personel_sayisi = short.Parse(lisanspersonelsayisi.Text); }
                    catch { yniStaj.lisans_mezunu_personel_sayisi = 0; }
                    try { yniStaj.bolumde_calisan_muhendis_sayisi = short.Parse(muhendissayisi.Text); }
                    catch { yniStaj.bolumde_calisan_muhendis_sayisi = 0; }
                    try { yniStaj.staj_ogrencisi_kontenjani = short.Parse(stajkontenjani.Text); }
                    catch { yniStaj.staj_ogrencisi_kontenjani = 0; }
                    try { yniStaj.makine_parki = short.Parse(makineparki.Text); }
                    catch { yniStaj.makine_parki = 0; }
                    yniStaj.sosyal_hizmetler = sosyalhizmetler.Text;
                    yniStaj.eklemek_istedikleriniz = eklemekistedikleriniz.Text;
                    baslangic_tarihi = calBaslangic.SelectedDate;
                    bitis_tarihi = calBitis.SelectedDate;
                    yniStaj.staj_baslangic = baslangic_tarihi;
                    yniStaj.staj_bitis = bitis_tarihi;
                    yniStaj.tc_no = tc_no;
                    yniStaj.durum_id = 5;
                    yniStaj.staj_kodu = tc_no.Substring(8);
                    yniStaj.staj_sonuc = 0;

                    if (cmrtesidahildir.Checked)
                    {
                        trhsnc = bllTarih.TarihHesapla1(baslangic_tarihi, bitis_tarihi);
                        yniStaj.staj_ctesi = true;
                        if (trhsnc == 20 && bllStaj.Duzenle(eskiStaj, yniStaj) && bllFirma.Duzenle(eskiFirma, yniFirma) && bllYetkili.Duzenle(eskiYetkili, yniYetkili))
                        {
                            Response.Write("<script>alert('Düzeltme işlemi Başarılı!');</script>");
                            System.Threading.Thread.Sleep(1000);
                            Server.Transfer("Anasayfa.aspx");
                        }
                        else
                        {
                            Response.Write("<script>alert('Düzeltme işlemi başarısız!Tarihleri kontrol ediniz');</script>");
                            //      blYetkili.Sil(yeniYetkili);
                            //    blFirma.Sil(yeniFirma);

                        }
                    }
                    else
                    {
                        yniStaj.staj_ctesi = false;
                        trhsnc = bllTarih.TarihHesapla(baslangic_tarihi, bitis_tarihi);
                        if (trhsnc == 20 && bllStaj.Duzenle(eskiStaj, yniStaj) && bllFirma.Duzenle(eskiFirma, yniFirma) && bllYetkili.Duzenle(eskiYetkili, yniYetkili) )
                        {
                            Response.Write("<script>alert('Düzeltme işlemi Başarılı!');</script>");
                            System.Threading.Thread.Sleep(1000);
                            Server.Transfer("Anasayfa.aspx");
                        }
                        else
                        {
                            Response.Write("<script>alert('Düzeltme işlemi başarısız!Tarihleri kontrol ediniz');</script>");
                            //      blYetkili.Sil(yeniYetkili);
                            //    blFirma.Sil(yeniFirma);

                        }
                    }




                }
                else
                    Response.Write("<script>alert('Başvurunuz Tamamlanmıştır.Değişiklik yapamazsınız!');</script>");
            
            }
            else if(stajkodu == null)
            {

            BLL.Firma blFirma = new BLL.Firma();
            BLL.Yetkili blYetkili = new BLL.Yetkili();
            BLL.Tarih blTarih = new BLL.Tarih();

            yeniFirma.adi = firmadi.Text;
            yeniFirma.tel = tel.Text;
            yeniFirma.adresi = adres.Text;
            blFirma.Ekle(yeniFirma);

            
            yeniYetkili.ad_soyad = yetkiliadsoy.Text;
            yeniYetkili.gorev = yetkilimevki.Text;
            yeniYetkili.yetkili_eposta = email.Text;
            yeniYetkili.firma_id = blFirma.Getir1(firmadi.Text).firma_id;
            blYetkili.Ekle(yeniYetkili);


            try { yeniStaj.calisan_eleman_sayisi = short.Parse(calisanelemansayisi.Text); }
            catch { yeniStaj.calisan_eleman_sayisi = 0; }
            try { yeniStaj.lisans_mezunu_personel_sayisi = short.Parse(lisanspersonelsayisi.Text); }
            catch { yeniStaj.lisans_mezunu_personel_sayisi = 0; }
            try { yeniStaj.bolumde_calisan_muhendis_sayisi = short.Parse(muhendissayisi.Text); }
            catch { yeniStaj.bolumde_calisan_muhendis_sayisi = 0; }
            try { yeniStaj.staj_ogrencisi_kontenjani = short.Parse(stajkontenjani.Text); }
            catch { yeniStaj.staj_ogrencisi_kontenjani = 0; }
            try { yeniStaj.makine_parki = short.Parse(makineparki.Text); }
            catch { yeniStaj.makine_parki = 0; }
            yeniStaj.sosyal_hizmetler = sosyalhizmetler.Text;
            yeniStaj.eklemek_istedikleriniz = eklemekistedikleriniz.Text;
            baslangic_tarihi = calBaslangic.SelectedDate;
            bitis_tarihi = calBitis.SelectedDate;
            yeniStaj.staj_baslangic = baslangic_tarihi;
            yeniStaj.staj_bitis = bitis_tarihi;
            yeniStaj.yetkili_id = blYetkili.Getir(yeniYetkili.firma_id).yetkili_id; ;
            yeniStaj.tc_no = tc_no;
            yeniStaj.firma_id = yeniYetkili.firma_id;
            yeniStaj.durum_id = 5;
            yeniStaj.staj_kodu = tc_no.Substring(8);
            yeniStaj.staj_sonuc = 0;
            BLL.Staj blStaj = new BLL.Staj();
            if (cmrtesidahildir.Checked)
            {
                yeniStaj.staj_ctesi = true;
                trhsnc= blTarih.TarihHesapla1(baslangic_tarihi, bitis_tarihi);
                if (trhsnc == 20 &&  blStaj.Ekle(yeniStaj))
                {
                    Response.Write("<script>alert('Kayıt Olma işlemi Başarılı!');</script>");
                    System.Threading.Thread.Sleep(1000);
                    Server.Transfer("Anasayfa.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Kayıt Olma işlemi başarısız!Tarihleri kontrol ediniz');</script>");
                    blYetkili.Sil(yeniYetkili);
                    blFirma.Sil(yeniFirma);

                }
            }
            else
            {
                yeniStaj.staj_ctesi = false;
                trhsnc = blTarih.TarihHesapla(baslangic_tarihi, bitis_tarihi);
                if (trhsnc == 20 && blStaj.Ekle(yeniStaj))
                {
                    Response.Write("<script>alert('Kayıt Olma işlemi Başarılı!');</script>");
                    System.Threading.Thread.Sleep(1000);
                    Server.Transfer("Anasayfa.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Kayıt Olma işlemi başarısız!Tarihleri kontrol ediniz');</script>");
                    blYetkili.Sil(yeniYetkili);
                    blFirma.Sil(yeniFirma);

                }
            }
    

            }
            else 
                Response.Write("<script>alert('Daha önce Kayıt işlemi yapılmıştır!');</script>");

        }
        


        protected void btnIptalet_Click(object sender, EventArgs e)
        {
            calisanelemansayisi.Text = "";
            lisanspersonelsayisi.Text = "";
            muhendissayisi.Text = "";
            stajkontenjani.Text = "";
            makineparki.Text = "";
            sosyalhizmetler.Text = "";
            eklemekistedikleriniz.Text = "";
            firmadi.Text = "";
            tel.Text = "";
            adres.Text = "";
            yetkiliadsoy.Text = "";
            yetkilimevki.Text = "";
            email.Text = "";
            Server.Transfer("Anasayfa.aspx");
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            //calisanelemansayisi.Text = calisanelemansayisi.Text;
        }

        protected void calBaslangic_SelectionChanged(object sender, EventArgs e)
        {
            baslangic_tarihi = this.calBaslangic.SelectedDate;
        }

        protected void calBitis_SelectionChanged(object sender, EventArgs e)
        {
            BLL.Tarih blTarih = new BLL.Tarih(); 
            bitis_tarihi = this.calBitis.SelectedDate;
            baslangicTarihi=this.calBaslangic.SelectedDate;
            if(cmrtesidahildir.Checked)
            trhsnc = blTarih.TarihHesapla1(baslangicTarihi, bitis_tarihi);
            else 
            trhsnc = blTarih.TarihHesapla(baslangicTarihi, bitis_tarihi);
            lbl_staj_gun_sayisi.Text = "Seçilen tarih aralığı gün sayısı: " + trhsnc.ToString();

        }
    }
}