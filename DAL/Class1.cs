using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Class1
    {
            
        veritabaniDataContext context;
        public Class1()
        {
            context = new veritabaniDataContext(); 

        }
        public Kullanici get()
        {
            try
            {
                return context.Kullanicis.FirstOrDefault();
            }
            catch(Exception ex)
            {             
               String s=ex.Message;
            }
            return null;          
        }
    }
}
