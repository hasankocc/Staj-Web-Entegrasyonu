using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Dosya
    {
        DAL.veritabaniDataContext vT = new DAL.veritabaniDataContext();
        public bool Ekle(DAL.Dosya dosya)
        {
            try
            {
                vT.Dosyas.InsertOnSubmit(dosya);
                vT.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Sil(DAL.Dosya dosya)
        {
            try
            {
                DAL.Dosya silinecek = Getir(dosya.staj_id);
                vT.Dosyas.DeleteOnSubmit(silinecek);
                vT.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public DAL.Dosya Getir(int staj_id)
        {
            return vT.Dosyas.Where(x => x.staj_id == staj_id).FirstOrDefault();
        }
        public List<DAL.Dosya> ListGetir()
        {
            return null;
        }
      

    }
}
