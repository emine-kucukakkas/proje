using DALL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLL
{
    public class ilacBLSinifBL : IDisposable
    {
        EczaneBilgiContext ecz = new EczaneBilgiContext();

        public void Dispose()
        {
            ((IDisposable)ecz).Dispose();
        }

        public bool Ekle(ilacBLSinifBL s)
        {
            ecz.Ilaclar.Add(s);
            return ecz.SaveChanges() > 0;
        }

        
        


    }
}
   
