using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   
    public class Tarih
    {

        DAL.veritabaniDataContext vT = new DAL.veritabaniDataContext();
        DateTime trh;
        List<DateTime> listTatil=new List<DateTime>();
        public static int CalismaHesapla(DateTime basTarih, DateTime bitTarih)//bu metod ile iki tarih arasındaki çalışma günlerini sayıyoruz
        {
            DateTime geciciTarih = basTarih;
            int gunSayi = 0;
            string gun = string.Empty;
            while (geciciTarih <= bitTarih)
            {
                gun = geciciTarih.ToString("dddd");
                if (gun != "Cumartesi" && gun != "Pazar")
                {
                    gunSayi++;
                }
                geciciTarih = geciciTarih.AddDays(1);
            }
            return gunSayi;
        }
        public static int CalismaHesapla1(DateTime basTarih, DateTime bitTarih)//bu metod ile iki tarih arasındaki çalışma günlerini sayıyoruz
        {
            DateTime geciciTarih = basTarih;
            int gunSayi = 0;
            string gun = string.Empty;
            while (geciciTarih <= bitTarih)
            {
                gun = geciciTarih.ToString("dddd");
                if (gun != "Pazar")
                {
                    gunSayi++;
                }
                geciciTarih = geciciTarih.AddDays(1);
            }
            return gunSayi;
        }
        public bool Ekle(DAL.Tarih tarih)
        {
            try
            {
                vT.Tarihs.InsertOnSubmit(tarih);
                vT.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Sil(DAL.Tarih tarih)
        {
            try
            {
                vT.Tarihs.DeleteOnSubmit(tarih);
                vT.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public DAL.Tarih Getir(DateTime tarih)
        {
            return vT.Tarihs.Where(x => x.tarih1 == tarih).FirstOrDefault();
        }
        public List<DAL.Tarih> ListeGetir()
        {
            return vT.Tarihs.ToList();
        }
        public int TarihHesapla(DateTime baslangic, DateTime bitis)
        {
            int snc;
            BLL.Tarih blTarih = new Tarih();
            int i = 0;
            while (i != -1)
            {
                try
                {
                    listTatil.Add(blTarih.ListeGetir().ElementAt(i).tarih1);
                    i++;
                }
                catch 
                {
                    i = -1;
                }
            }
            DateTime ilkT = Convert.ToDateTime(baslangic);
            DateTime sonT = Convert.ToDateTime(bitis);

            int resmiTatil = 0;
            foreach (DateTime rTatil in listTatil)//Resmi tatil listemizi foreach ile geziyoruz
            {
                //resmi tatiller hafta sonuna denk geliyorsa aşagıdaki metod ile hafta sonralını çıkarttığımızdan tekrar saymasına gerek yok
                //hafta içine denk gelen resmi tatilleri sayıyoruz.
                if ((rTatil.ToString("dddd") != "Cumartesi" && rTatil.ToString("dddd") != "Pazar") && (rTatil >= ilkT && rTatil <= sonT))
                {
                    resmiTatil++;
                }

            }
            int sonuc = CalismaHesapla(ilkT, sonT);
            snc = sonuc - resmiTatil;
            return snc; 
        }
        public int TarihHesapla1(DateTime baslangic, DateTime bitis)
        {
            int snc;
            BLL.Tarih blTarih = new Tarih();
            int i = 0;
            while (i != -1)
            {
                try
                {
                    listTatil.Add(ListeGetir().ElementAt(i).tarih1);
                    i++;
                }
                catch
                {
                    i = -1;
                }
            }
            DateTime ilkT = Convert.ToDateTime(baslangic);
            DateTime sonT = Convert.ToDateTime(bitis);

            int resmiTatil = 0;
            foreach (DateTime rTatil in listTatil)//Resmi tatil listemizi foreach ile geziyoruz
            {
                //resmi tatiller hafta sonuna denk geliyorsa aşagıdaki metod ile hafta sonralını çıkarttığımızdan tekrar saymasına gerek yok
                //hafta içine denk gelen resmi tatilleri sayıyoruz.
                if (( rTatil.ToString("dddd") != "Pazar") && (rTatil >= ilkT && rTatil <= sonT))
                {
                    resmiTatil++;
                }

            }
            int sonuc = CalismaHesapla1(ilkT, sonT);
            snc = sonuc - resmiTatil;
            return snc;
        }
    }

}
