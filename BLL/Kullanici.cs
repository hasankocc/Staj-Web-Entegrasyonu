using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.Linq;
using System.Threading.Tasks;

namespace BLL
{
    public class Kullanici
    {
        DAL.veritabaniDataContext vT = new DAL.veritabaniDataContext();
        public bool Ekle(DAL.Kullanici kullanici)
        {
            try
            {
                vT.Kullanicis.InsertOnSubmit(kullanici);
                vT.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool Duzenle(DAL.Kullanici eskiKullanici , DAL.Kullanici yeniKullanici)
        {
            
            
            try
            {
                DAL.Kullanici geciciKullanici = vT.Kullanicis.Where(x => x.tc_no == eskiKullanici.tc_no).First();
                geciciKullanici.sifre = yeniKullanici.sifre;
                vT.SubmitChanges();
             
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Sil(string tc_no)
        {
            try
            {
                DAL.Kullanici silinecek = Getir(tc_no);
                vT.Kullanicis.DeleteOnSubmit(silinecek);
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
        public DAL.Kullanici Getir1(string kullanici_adi)
        {
            return vT.Kullanicis.Where(x => x.eposta == kullanici_adi).FirstOrDefault();
        }
        public List<DAL.Kullanici> ListeGetir(string kullanici_adi)
        {
            return vT.Kullanicis.Where(x => x.eposta == kullanici_adi).ToList();
        }
        public bool GirisKontrol(string eposta,string sifre)
        {
            try
            {
               int sayi = vT.Kullanicis.Where(x => x.eposta == eposta && x.sifre == sifre).Count();
                if (sayi==1) return true;
                else return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
       
    }
}
