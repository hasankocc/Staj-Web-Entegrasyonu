using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class Yetkili
    {
        DAL.veritabaniDataContext vT = new DAL.veritabaniDataContext();
        public bool Ekle(DAL.Yetkili kullanici)
        {
            try
            {
                vT.Yetkilis.InsertOnSubmit(kullanici);
                vT.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Duzenle(DAL.Yetkili eskiYetkili, DAL.Yetkili yeniYetkili)
        {
            try
            {
                DAL.Yetkili geciciYetkili = vT.Yetkilis.Where(x => x.yetkili_id == eskiYetkili.yetkili_id).First();
                geciciYetkili.ad_soyad = yeniYetkili.ad_soyad;
                geciciYetkili.yetkili_eposta = yeniYetkili.yetkili_eposta;
                geciciYetkili.gorev = yeniYetkili.gorev;
                vT.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Sil(DAL.Yetkili kullanici )
        {
            try
            {
                vT.Yetkilis.DeleteOnSubmit(kullanici);
                vT.SubmitChanges();
                return true;
                
            }
            catch (Exception)
            {
                return false;
            }
        }
        public DAL.Yetkili Getir(int yetkili_id)
        {
            return vT.Yetkilis.Where(x => x.yetkili_id == yetkili_id).FirstOrDefault(); 
        }
        public DAL.Yetkili Getir1(int firma_id)
        {
            return vT.Yetkilis.Where(x => x.firma_id == firma_id).FirstOrDefault();
        }
        public List<DAL.Yetkili> ListeGetir(int yetkili_id)
        {
            return null;
        }
        public List<DAL.Yetkili> ListeGetir()
        {
            return null;
        }
    }
}
