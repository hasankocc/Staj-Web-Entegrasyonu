using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Bolum
    {
        DAL.veritabaniDataContext vT = new DAL.veritabaniDataContext();
        public bool Ekle(DAL.Bolum kullanici)
        {
            try
            {
                vT.Bolums.InsertOnSubmit(kullanici);
                vT.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Duzenle(DAL.Bolum eskiBolum, DAL.Bolum yeniBolum)
        {
            try
            {

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Sil(string bolum_id)
        {
            try
            {
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public DAL.Bolum Getir(int bolum_id)
        {
            return vT.Bolums.Where(x => x.bolum_id == bolum_id).FirstOrDefault();
        }
        public List<DAL.Bolum> ListeGetir()
        {
            return null;
        }
    }
}
