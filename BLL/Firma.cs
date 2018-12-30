using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class Firma
    {
        DAL.veritabaniDataContext vT = new DAL.veritabaniDataContext();
        public bool Ekle(DAL.Firma kullanici)
        {
            try
            {
                vT.Firmas.InsertOnSubmit(kullanici);
                vT.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool Duzenle(DAL.Firma eskiFirma, DAL.Firma yeniFirma)
        {
            try
            {
                DAL.Firma geciciFirma = vT.Firmas.Where(x => x.firma_id == eskiFirma.firma_id).First();
                geciciFirma.adi= yeniFirma.adi;
                geciciFirma.adresi = yeniFirma.adresi;
                geciciFirma.tel= yeniFirma.tel;
              
              
                vT.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Sil(DAL.Firma kullanici)
        {
            try
            {
                vT.Firmas.DeleteOnSubmit(kullanici);
                vT.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public DAL.Firma Getir(int firma_id)
        {
            return vT.Firmas.Where(x => x.firma_id == firma_id).FirstOrDefault(); 
        }
        public DAL.Firma Getir1(string adi)
        {
            return vT.Firmas.Where(x => x.adi == adi).FirstOrDefault();  
        }
        public List<DAL.Firma> ListeGetir()
        {
            return null;
        }
    }
}
