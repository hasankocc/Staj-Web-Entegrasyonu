using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Staj
    {
        DAL.veritabaniDataContext vT = new DAL.veritabaniDataContext();
        public bool Ekle(DAL.Staj kullanici)
        {
            try
            {
                vT.Stajs.InsertOnSubmit(kullanici);
                vT.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool Duzenle(DAL.Staj eskiStaj, DAL.Staj yeniStaj)
        {
            try
            {
                DAL.Staj geciciStaj = vT.Stajs.Where(x => x.staj_id == eskiStaj.staj_id).First();
                geciciStaj.calisan_eleman_sayisi = yeniStaj.calisan_eleman_sayisi;
                geciciStaj.lisans_mezunu_personel_sayisi = yeniStaj.lisans_mezunu_personel_sayisi;
                geciciStaj.bolumde_calisan_muhendis_sayisi = yeniStaj.bolumde_calisan_muhendis_sayisi;
                geciciStaj.staj_ogrencisi_kontenjani = yeniStaj.staj_ogrencisi_kontenjani;
                geciciStaj.makine_parki = yeniStaj.makine_parki;
                geciciStaj.sosyal_hizmetler = yeniStaj.sosyal_hizmetler;
                geciciStaj.staj_ctesi = yeniStaj.staj_ctesi;
                geciciStaj.staj_baslangic = yeniStaj.staj_baslangic;
                geciciStaj.staj_bitis = yeniStaj.staj_bitis;
                geciciStaj.durum_id = yeniStaj.durum_id;
                geciciStaj.staj_sonuc = yeniStaj.staj_sonuc;
                geciciStaj.staj_yorum = yeniStaj.staj_yorum;

                vT.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Sil(DAL.Staj kullanici)
        {
            try
            {
                vT.Stajs.DeleteOnSubmit(kullanici);
                vT.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public DAL.Kullanici Getir(string tc_no)
        {
            return vT.Kullanicis.Where(x => x.tc_no == tc_no).FirstOrDefault(); 
        }

       
        public List<DAL.Staj> ListeGetir()
        {
            return vT.Stajs.ToList();
        }

        public List<DAL.Staj> ListeGetir1(string tc_no)
        {
            return vT.Stajs.Where(x => x.tc_no == tc_no).ToList();
        }

        public List<DAL.Staj> ListeGetir2(int staj_id)
        {
            return vT.Stajs.Where(x => x.staj_id == staj_id).ToList();
        }

    }
}
